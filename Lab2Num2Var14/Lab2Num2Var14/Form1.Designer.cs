
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
      ((System.ComponentModel.ISupportInitialize)(this.equalNums)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 15);
      this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(367, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "Количество повторяющихся элементов: ";
      // 
      // equalNums
      // 
      this.equalNums.Location = new System.Drawing.Point(379, 13);
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
      this.numsRow.Location = new System.Drawing.Point(0, 60);
      this.numsRow.Multiline = true;
      this.numsRow.Name = "numsRow";
      this.numsRow.PlaceholderText = "Здесь вводится числовая последовательность";
      this.numsRow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.numsRow.Size = new System.Drawing.Size(514, 105);
      this.numsRow.TabIndex = 2;
      this.numsRow.TextChanged += new System.EventHandler(this.OnChange);
      this.numsRow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnPress);
      // 
      // outText
      // 
      this.outText.Location = new System.Drawing.Point(0, 168);
      this.outText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.outText.Name = "outText";
      this.outText.Size = new System.Drawing.Size(514, 43);
      this.outText.TabIndex = 3;
      this.outText.Text = "Тут что-то будет выведено";
      this.outText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(514, 211);
      this.Controls.Add(this.outText);
      this.Controls.Add(this.numsRow);
      this.Controls.Add(this.equalNums);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.Name = "Form1";
      this.Text = "Нахождение n чисел подряд в последовательности";
      ((System.ComponentModel.ISupportInitialize)(this.equalNums)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown equalNums;
    private System.Windows.Forms.TextBox numsRow;
    private System.Windows.Forms.Label outText;
  }
}

