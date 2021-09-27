
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
      this.nums = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // nums
      // 
      this.nums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.nums.Dock = System.Windows.Forms.DockStyle.Top;
      this.nums.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.nums.Location = new System.Drawing.Point(0, 0);
      this.nums.Margin = new System.Windows.Forms.Padding(5);
      this.nums.Multiline = true;
      this.nums.Name = "nums";
      this.nums.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.nums.Size = new System.Drawing.Size(535, 172);
      this.nums.TabIndex = 0;
      this.nums.TextChanged += new System.EventHandler(this.nums_TextChanged);
      this.nums.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nums_KeyDown);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label1.Location = new System.Drawing.Point(0, 183);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(535, 25);
      this.label1.TabIndex = 1;
      this.label1.Text = "Тут что-то будет выведено";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(535, 208);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.nums);
      this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "Form1";
      this.Text = "Упорядоченность чисел по возрастанию";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox nums;
    private System.Windows.Forms.Label label1;
  }
}

