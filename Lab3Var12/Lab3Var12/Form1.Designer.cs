
namespace Lab3Var12 {
  partial class Form1 {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.hLabel = new System.Windows.Forms.Label();
      this.sLabel = new System.Windows.Forms.Label();
      this.vLabel = new System.Windows.Forms.Label();
      this.colorSquare = new System.Windows.Forms.Button();
      this.bLabel = new System.Windows.Forms.Label();
      this.gLabel = new System.Windows.Forms.Label();
      this.rLabel = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.rBetween = new System.Windows.Forms.Label();
      this.rChanger = new System.Windows.Forms.NumericUpDown();
      this.gChanger = new System.Windows.Forms.NumericUpDown();
      this.gBetween = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.bChanger = new System.Windows.Forms.NumericUpDown();
      this.bBetween = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.changeRgbButton = new System.Windows.Forms.Button();
      this.changeHsvButton = new System.Windows.Forms.Button();
      this.vChanger = new System.Windows.Forms.NumericUpDown();
      this.vBetween = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.sChanger = new System.Windows.Forms.NumericUpDown();
      this.sBetween = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.rChanger)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gChanger)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bChanger)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.vChanger)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sChanger)).BeginInit();
      this.SuspendLayout();
      // 
      // hLabel
      // 
      this.hLabel.Location = new System.Drawing.Point(10, 10);
      this.hLabel.Name = "hLabel";
      this.hLabel.Size = new System.Drawing.Size(110, 25);
      this.hLabel.TabIndex = 3;
      this.hLabel.Text = "h";
      this.hLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // sLabel
      // 
      this.sLabel.Location = new System.Drawing.Point(10, 35);
      this.sLabel.Name = "sLabel";
      this.sLabel.Size = new System.Drawing.Size(110, 25);
      this.sLabel.TabIndex = 4;
      this.sLabel.Text = "s";
      this.sLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // vLabel
      // 
      this.vLabel.Location = new System.Drawing.Point(10, 60);
      this.vLabel.Name = "vLabel";
      this.vLabel.Size = new System.Drawing.Size(110, 25);
      this.vLabel.TabIndex = 5;
      this.vLabel.Text = "v";
      this.vLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // colorSquare
      // 
      this.colorSquare.Enabled = false;
      this.colorSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.colorSquare.Location = new System.Drawing.Point(130, 10);
      this.colorSquare.Name = "colorSquare";
      this.colorSquare.Size = new System.Drawing.Size(75, 75);
      this.colorSquare.TabIndex = 6;
      this.colorSquare.UseVisualStyleBackColor = false;
      // 
      // bLabel
      // 
      this.bLabel.Location = new System.Drawing.Point(215, 60);
      this.bLabel.Name = "bLabel";
      this.bLabel.Size = new System.Drawing.Size(110, 25);
      this.bLabel.TabIndex = 12;
      this.bLabel.Text = "b";
      this.bLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // gLabel
      // 
      this.gLabel.Location = new System.Drawing.Point(215, 35);
      this.gLabel.Name = "gLabel";
      this.gLabel.Size = new System.Drawing.Size(110, 25);
      this.gLabel.TabIndex = 11;
      this.gLabel.Text = "g";
      this.gLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // rLabel
      // 
      this.rLabel.Location = new System.Drawing.Point(215, 10);
      this.rLabel.Name = "rLabel";
      this.rLabel.Size = new System.Drawing.Size(110, 25);
      this.rLabel.TabIndex = 10;
      this.rLabel.Text = "r";
      this.rLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(10, 120);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(208, 25);
      this.label1.TabIndex = 13;
      this.label1.Text = "Изменение красного:";
      // 
      // rBetween
      // 
      this.rBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.rBetween.Location = new System.Drawing.Point(10, 145);
      this.rBetween.Name = "rBetween";
      this.rBetween.Size = new System.Drawing.Size(208, 25);
      this.rBetween.TabIndex = 14;
      this.rBetween.Text = "в промежутке от 0 до 255";
      // 
      // rChanger
      // 
      this.rChanger.Location = new System.Drawing.Point(224, 120);
      this.rChanger.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.rChanger.Name = "rChanger";
      this.rChanger.Size = new System.Drawing.Size(101, 29);
      this.rChanger.TabIndex = 15;
      this.rChanger.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPressedRgb);
      // 
      // gChanger
      // 
      this.gChanger.Location = new System.Drawing.Point(223, 170);
      this.gChanger.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.gChanger.Name = "gChanger";
      this.gChanger.Size = new System.Drawing.Size(101, 29);
      this.gChanger.TabIndex = 18;
      this.gChanger.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPressedRgb);
      // 
      // gBetween
      // 
      this.gBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.gBetween.Location = new System.Drawing.Point(9, 195);
      this.gBetween.Name = "gBetween";
      this.gBetween.Size = new System.Drawing.Size(208, 25);
      this.gBetween.TabIndex = 17;
      this.gBetween.Text = "в промежутке от 0 до 255";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(9, 170);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(208, 25);
      this.label3.TabIndex = 16;
      this.label3.Text = "Изменение зелёного:";
      // 
      // bChanger
      // 
      this.bChanger.Location = new System.Drawing.Point(222, 220);
      this.bChanger.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.bChanger.Name = "bChanger";
      this.bChanger.Size = new System.Drawing.Size(101, 29);
      this.bChanger.TabIndex = 21;
      this.bChanger.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPressedRgb);
      // 
      // bBetween
      // 
      this.bBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.bBetween.Location = new System.Drawing.Point(8, 245);
      this.bBetween.Name = "bBetween";
      this.bBetween.Size = new System.Drawing.Size(208, 25);
      this.bBetween.TabIndex = 20;
      this.bBetween.Text = "в промежутке от 0 до 255";
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(8, 220);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(208, 25);
      this.label5.TabIndex = 19;
      this.label5.Text = "Изменение синего:";
      // 
      // changeRgbButton
      // 
      this.changeRgbButton.Location = new System.Drawing.Point(11, 274);
      this.changeRgbButton.Name = "changeRgbButton";
      this.changeRgbButton.Size = new System.Drawing.Size(314, 35);
      this.changeRgbButton.TabIndex = 22;
      this.changeRgbButton.Text = "Изменить цвета";
      this.changeRgbButton.UseVisualStyleBackColor = true;
      this.changeRgbButton.Click += new System.EventHandler(this.ChangeRgb);
      // 
      // changeHsvButton
      // 
      this.changeHsvButton.Location = new System.Drawing.Point(11, 450);
      this.changeHsvButton.Name = "changeHsvButton";
      this.changeHsvButton.Size = new System.Drawing.Size(314, 35);
      this.changeHsvButton.TabIndex = 29;
      this.changeHsvButton.Text = "Изменить насыщ. / яркость";
      this.changeHsvButton.UseVisualStyleBackColor = true;
      this.changeHsvButton.Click += new System.EventHandler(this.ChangeHsv);
      // 
      // vChanger
      // 
      this.vChanger.Location = new System.Drawing.Point(222, 396);
      this.vChanger.Name = "vChanger";
      this.vChanger.Size = new System.Drawing.Size(101, 29);
      this.vChanger.TabIndex = 28;
      this.vChanger.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPressedHsv);
      // 
      // vBetween
      // 
      this.vBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.vBetween.Location = new System.Drawing.Point(8, 421);
      this.vBetween.Name = "vBetween";
      this.vBetween.Size = new System.Drawing.Size(208, 25);
      this.vBetween.TabIndex = 27;
      this.vBetween.Text = "в промежутке от 0 до 100";
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(8, 396);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(208, 25);
      this.label4.TabIndex = 26;
      this.label4.Text = "Изменение яркости:";
      // 
      // sChanger
      // 
      this.sChanger.Location = new System.Drawing.Point(223, 346);
      this.sChanger.Name = "sChanger";
      this.sChanger.Size = new System.Drawing.Size(101, 29);
      this.sChanger.TabIndex = 25;
      this.sChanger.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPressedHsv);
      // 
      // sBetween
      // 
      this.sBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.sBetween.Location = new System.Drawing.Point(9, 371);
      this.sBetween.Name = "sBetween";
      this.sBetween.Size = new System.Drawing.Size(208, 25);
      this.sBetween.TabIndex = 24;
      this.sBetween.Text = "в промежутке от 0 до 100";
      // 
      // label7
      // 
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(9, 346);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(208, 25);
      this.label7.TabIndex = 23;
      this.label7.Text = "Изменение насыщ.:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(334, 491);
      this.Controls.Add(this.changeHsvButton);
      this.Controls.Add(this.vChanger);
      this.Controls.Add(this.vBetween);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.sChanger);
      this.Controls.Add(this.sBetween);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.changeRgbButton);
      this.Controls.Add(this.bChanger);
      this.Controls.Add(this.bBetween);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.gChanger);
      this.Controls.Add(this.gBetween);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.rChanger);
      this.Controls.Add(this.rBetween);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.bLabel);
      this.Controls.Add(this.gLabel);
      this.Controls.Add(this.rLabel);
      this.Controls.Add(this.colorSquare);
      this.Controls.Add(this.vLabel);
      this.Controls.Add(this.sLabel);
      this.Controls.Add(this.hLabel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Работа с цветом";
      ((System.ComponentModel.ISupportInitialize)(this.rChanger)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gChanger)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bChanger)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.vChanger)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sChanger)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label hLabel;
    private System.Windows.Forms.Label sLabel;
    private System.Windows.Forms.Label vLabel;
    private System.Windows.Forms.Button colorSquare;
    private System.Windows.Forms.Label bLabel;
    private System.Windows.Forms.Label gLabel;
    private System.Windows.Forms.Label rLabel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label rBetween;
    private System.Windows.Forms.NumericUpDown rChanger;
    private System.Windows.Forms.NumericUpDown gChanger;
    private System.Windows.Forms.Label gBetween;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown bChanger;
    private System.Windows.Forms.Label bBetween;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button changeRgbButton;
    private System.Windows.Forms.Button changeHsvButton;
    private System.Windows.Forms.NumericUpDown vChanger;
    private System.Windows.Forms.Label vBetween;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown sChanger;
    private System.Windows.Forms.Label sBetween;
    private System.Windows.Forms.Label label7;
  }
}

