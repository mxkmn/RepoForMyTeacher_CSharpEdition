
namespace CourseWork {
  partial class DrawerForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.drawing = new System.Windows.Forms.PictureBox();
      this.ticker = new System.Windows.Forms.Timer(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.debugCheckBox = new System.Windows.Forms.CheckBox();
      this.speedBar = new System.Windows.Forms.TrackBar();
      this.label2 = new System.Windows.Forms.Label();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.label3 = new System.Windows.Forms.Label();
      this.tickButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.drawing)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
      this.SuspendLayout();
      // 
      // drawing
      // 
      this.drawing.Location = new System.Drawing.Point(0, 0);
      this.drawing.Name = "drawing";
      this.drawing.Size = new System.Drawing.Size(650, 255);
      this.drawing.TabIndex = 0;
      this.drawing.TabStop = false;
      this.drawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseInteraction);
      this.drawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDebug);
      // 
      // ticker
      // 
      this.ticker.Enabled = true;
      this.ticker.Interval = 16;
      this.ticker.Tick += new System.EventHandler(this.OnTick);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 270);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(625, 28);
      this.label1.TabIndex = 1;
      this.label1.Text = "Настройки";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // debugCheckBox
      // 
      this.debugCheckBox.Location = new System.Drawing.Point(260, 315);
      this.debugCheckBox.Name = "debugCheckBox";
      this.debugCheckBox.Size = new System.Drawing.Size(125, 69);
      this.debugCheckBox.TabIndex = 4;
      this.debugCheckBox.Text = "Включить дебаг-режим";
      this.debugCheckBox.UseVisualStyleBackColor = true;
      this.debugCheckBox.CheckedChanged += new System.EventHandler(this.OnDebugChange);
      // 
      // speedBar
      // 
      this.speedBar.LargeChange = 1;
      this.speedBar.Location = new System.Drawing.Point(438, 328);
      this.speedBar.Maximum = 5;
      this.speedBar.Name = "speedBar";
      this.speedBar.Size = new System.Drawing.Size(199, 45);
      this.speedBar.TabIndex = 3;
      this.speedBar.Value = 5;
      this.speedBar.Scroll += new System.EventHandler(this.OnSpeedChange);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(438, 298);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(199, 27);
      this.label2.TabIndex = 4;
      this.label2.Text = "Скорость перемещений";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(12, 328);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(92, 25);
      this.radioButton1.TabIndex = 5;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "В центре";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new System.EventHandler(this.GenerateInCenter);
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(12, 359);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(69, 25);
      this.radioButton2.TabIndex = 6;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Везде";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new System.EventHandler(this.GenerateEverywhere);
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new System.Drawing.Point(12, 390);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(200, 25);
      this.radioButton3.TabIndex = 7;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "Спектр звуковых частот";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new System.EventHandler(this.GenerateBySound);
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(12, 298);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(200, 27);
      this.label3.TabIndex = 8;
      this.label3.Text = "Генерация частиц";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tickButton
      // 
      this.tickButton.Location = new System.Drawing.Point(438, 379);
      this.tickButton.Name = "tickButton";
      this.tickButton.Size = new System.Drawing.Size(199, 30);
      this.tickButton.TabIndex = 9;
      this.tickButton.Text = "+ шаг";
      this.tickButton.UseVisualStyleBackColor = true;
      this.tickButton.Click += new System.EventHandler(this.OnTick);
      // 
      // DrawerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(649, 423);
      this.Controls.Add(this.tickButton);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.radioButton3);
      this.Controls.Add(this.radioButton2);
      this.Controls.Add(this.radioButton1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.speedBar);
      this.Controls.Add(this.debugCheckBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.drawing);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DrawerForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Отрисовка частиц";
      ((System.ComponentModel.ISupportInitialize)(this.drawing)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox drawing;
    private System.Windows.Forms.Timer ticker;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox debugCheckBox;
    private System.Windows.Forms.TrackBar speedBar;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button tickButton;
  }
}