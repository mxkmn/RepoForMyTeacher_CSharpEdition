
namespace Lab2Num2Var14 {
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
      this.equalNums = new System.Windows.Forms.NumericUpDown();
      this.numsRow = new System.Windows.Forms.TextBox();
      this.outText = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.очиститьПоследовательностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.прочитатьЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.equalNums)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(53, 34);
      this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(367, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "Количество повторяющихся элементов: ";
      // 
      // equalNums
      // 
      this.equalNums.Location = new System.Drawing.Point(418, 32);
      this.equalNums.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.equalNums.Name = "equalNums";
      this.equalNums.Size = new System.Drawing.Size(120, 32);
      this.equalNums.TabIndex = 1;
      this.equalNums.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.equalNums.ValueChanged += new System.EventHandler(this.OnChange);
      this.equalNums.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnPress);
      // 
      // numsRow
      // 
      this.numsRow.Location = new System.Drawing.Point(0, 76);
      this.numsRow.Multiline = true;
      this.numsRow.Name = "numsRow";
      this.numsRow.PlaceholderText = "Введите последовательность (без лишних пробелов)";
      this.numsRow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.numsRow.Size = new System.Drawing.Size(598, 105);
      this.numsRow.TabIndex = 2;
      this.numsRow.TextChanged += new System.EventHandler(this.OnChange);
      this.numsRow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnPress);
      // 
      // outText
      // 
      this.outText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.outText.Location = new System.Drawing.Point(0, 184);
      this.outText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.outText.Name = "outText";
      this.outText.Size = new System.Drawing.Size(598, 43);
      this.outText.TabIndex = 3;
      this.outText.Text = "Тут что-то будет выведено";
      this.outText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьПоследовательностьToolStripMenuItem,
            this.прочитатьЗаданиеToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(598, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // очиститьПоследовательностьToolStripMenuItem
      // 
      this.очиститьПоследовательностьToolStripMenuItem.Name = "очиститьПоследовательностьToolStripMenuItem";
      this.очиститьПоследовательностьToolStripMenuItem.Size = new System.Drawing.Size(187, 20);
      this.очиститьПоследовательностьToolStripMenuItem.Text = "Очистить последовательность";
      this.очиститьПоследовательностьToolStripMenuItem.Click += new System.EventHandler(this.ClearData);
      // 
      // прочитатьЗаданиеToolStripMenuItem
      // 
      this.прочитатьЗаданиеToolStripMenuItem.Name = "прочитатьЗаданиеToolStripMenuItem";
      this.прочитатьЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
      this.прочитатьЗаданиеToolStripMenuItem.Text = "Прочитать задание";
      this.прочитатьЗаданиеToolStripMenuItem.Click += new System.EventHandler(this.PrintInfo);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(598, 229);
      this.Controls.Add(this.outText);
      this.Controls.Add(this.numsRow);
      this.Controls.Add(this.equalNums);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "Form1";
      this.Text = "Нахождение чисел в последовательности";
      ((System.ComponentModel.ISupportInitialize)(this.equalNums)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown equalNums;
    private System.Windows.Forms.TextBox numsRow;
    private System.Windows.Forms.Label outText;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem очиститьПоследовательностьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem прочитатьЗаданиеToolStripMenuItem;
  }
}

