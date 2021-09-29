
namespace Lab2Num1Var12 {
  partial class Form1 {
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
      this.label1 = new System.Windows.Forms.Label();
      this.numData = new System.Windows.Forms.NumericUpDown();
      this.outLabel = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.показатьЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.numData)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(11, 38);
      this.label1.Margin = new System.Windows.Forms.Padding(0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(143, 25);
      this.label1.TabIndex = 1;
      this.label1.Text = "Введите число:";
      // 
      // numData
      // 
      this.numData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.numData.AutoSize = true;
      this.numData.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.numData.Location = new System.Drawing.Point(157, 36);
      this.numData.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
      this.numData.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numData.Name = "numData";
      this.numData.Size = new System.Drawing.Size(120, 32);
      this.numData.TabIndex = 2;
      this.numData.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numData.ValueChanged += new System.EventHandler(this.numData_Changed);
      this.numData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numData_KeyUp);
      // 
      // outLabel
      // 
      this.outLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.outLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.outLabel.Location = new System.Drawing.Point(0, 79);
      this.outLabel.Name = "outLabel";
      this.outLabel.Size = new System.Drawing.Size(289, 30);
      this.outLabel.TabIndex = 3;
      this.outLabel.Text = "тут будут твои копейки";
      this.outLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьЗаданиеToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(289, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // показатьЗаданиеToolStripMenuItem
      // 
      this.показатьЗаданиеToolStripMenuItem.Name = "показатьЗаданиеToolStripMenuItem";
      this.показатьЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
      this.показатьЗаданиеToolStripMenuItem.Text = "Показать задание";
      this.показатьЗаданиеToolStripMenuItem.Click += new System.EventHandler(this.PrintInfo);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(289, 118);
      this.Controls.Add(this.outLabel);
      this.Controls.Add(this.numData);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Стоимость товара";
      ((System.ComponentModel.ISupportInitialize)(this.numData)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numData;
    private System.Windows.Forms.Label outLabel;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem показатьЗаданиеToolStripMenuItem;
  }
}

