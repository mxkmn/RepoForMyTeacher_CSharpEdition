/* 
 * Это попытка сделать из говнокода https://github.com/m4r1vs/Audioly хоть 
 * что-то адекватное, но либа не имеет нормальной документации, так что
 * всё очень плохо - возможно ненадёжно, неясно как работает, поток берётся
 * с самого первого аудиодевайса в системе, поскольку все попытки помеять
 * девайс заканчиваются исключительно ошибками.
 * Какой язык, такие и программисты :(
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.BassWasapi;

namespace CourseWork {
  internal class Analyzer {
    private WASAPIPROC _process;                          //callback function to obtain data
    public Analyzer() {
      _process = new WASAPIPROC(Process);

      int availableDevice = -1;
      for (int i = 0; i < BassWasapi.BASS_WASAPI_GetDeviceCount(); i++) {
        var device = BassWasapi.BASS_WASAPI_GetDeviceInfo(i);
        if (device.IsEnabled && device.IsLoopback) {
          availableDevice = i;
          break;
        }
      }
      if (availableDevice == -1)
        throw new Exception("Аудиопоток недоступен");

      Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATETHREADS, false);
      if (!Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
        throw new Exception(Bass.BASS_ErrorGetCode().ToString());

      if (!BassWasapi.BASS_WASAPI_Init(availableDevice, 0, 0, BASSWASAPIInit.BASS_WASAPI_BUFFER, 1f, 0.05f, _process, IntPtr.Zero))
        MessageBox.Show(Bass.BASS_ErrorGetCode().ToString());

      BassWasapi.BASS_WASAPI_Start();
    }

    public byte[] getRawData() {
      int b0 = 0;
      float[] fftBufferData = new float[8192];
      List<byte> _spectrumdata = new List<byte>();

      if (BassWasapi.BASS_WASAPI_GetData(fftBufferData, (int)BASSData.BASS_DATA_FFT8192) < -1)
        return _spectrumdata.ToArray();

      for (int x = 0; x < 64; x++) {
        float peak = 0;
        int b1 = (int)Math.Pow(2, x * 10.0 / 63);
        if (b1 > 1023)
          b1 = 1023;
        if (b1 <= b0)
          b1 = b0 + 1;
        for (; b0 < b1; b0++) {
          if (peak < fftBufferData[1 + b0])
            peak = fftBufferData[1 + b0];
        }
        int y = (int)(1.5 * Math.Sqrt(peak) * 255);
        y = y > 255 ? 255 : (y < 0 ? 0 : y);
        _spectrumdata.Add((byte)y);
      }

      return _spectrumdata.ToArray();
    }
    private int Process(IntPtr buffer, int length, IntPtr user) { // WASAPI callback, required for continuous recording
      return length;
    }
  }
}
