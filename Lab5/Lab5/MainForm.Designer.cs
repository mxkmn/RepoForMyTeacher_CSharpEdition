
namespace Lab5 {
  partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.pbMain = new System.Windows.Forms.PictureBox();
      this.txtLog = new System.Windows.Forms.RichTextBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.lblScore = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
      this.SuspendLayout();
      // 
      // pbMain
      // 
      this.pbMain.Location = new System.Drawing.Point(12, 12);
      this.pbMain.Name = "pbMain";
      this.pbMain.Size = new System.Drawing.Size(450, 450);
      this.pbMain.TabIndex = 0;
      this.pbMain.TabStop = false;
      this.pbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPicture);
      this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureClicked);
      // 
      // txtLog
      // 
      this.txtLog.Location = new System.Drawing.Point(12, 468);
      this.txtLog.Name = "txtLog";
      this.txtLog.Size = new System.Drawing.Size(450, 81);
      this.txtLog.TabIndex = 1;
      this.txtLog.Text = "";
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 16;
      this.timer1.Tick += new System.EventHandler(this.UpdatePicture);
      // 
      // lblScore
      // 
      this.lblScore.AutoSize = true;
      this.lblScore.Location = new System.Drawing.Point(22, 22);
      this.lblScore.Name = "lblScore";
      this.lblScore.Size = new System.Drawing.Size(44, 21);
      this.lblScore.TabIndex = 2;
      this.lblScore.Text = "Счёт";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(474, 561);
      this.Controls.Add(this.lblScore);
      this.Controls.Add(this.txtLog);
      this.Controls.Add(this.pbMain);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "Обработка событий";
      ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pbMain;
    private System.Windows.Forms.RichTextBox txtLog;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label lblScore;
  }
}

