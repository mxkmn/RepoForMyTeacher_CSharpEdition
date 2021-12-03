
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
      ((System.ComponentModel.ISupportInitialize)(this.drawing)).BeginInit();
      this.SuspendLayout();
      // 
      // drawing
      // 
      this.drawing.Location = new System.Drawing.Point(0, 0);
      this.drawing.Name = "drawing";
      this.drawing.Size = new System.Drawing.Size(750, 750);
      this.drawing.TabIndex = 0;
      this.drawing.TabStop = false;
      this.drawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseInteraction);
      // 
      // ticker
      // 
      this.ticker.Enabled = true;
      this.ticker.Interval = 16;
      this.ticker.Tick += new System.EventHandler(this.OnTick);
      // 
      // DrawerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(749, 751);
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
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox drawing;
    private System.Windows.Forms.Timer ticker;
  }
}