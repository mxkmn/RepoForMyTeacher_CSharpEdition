
namespace CourseWork {
  partial class MenuForm {
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
      this.drawerButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // drawerButton
      // 
      this.drawerButton.Location = new System.Drawing.Point(12, 688);
      this.drawerButton.Name = "drawerButton";
      this.drawerButton.Size = new System.Drawing.Size(725, 51);
      this.drawerButton.TabIndex = 0;
      this.drawerButton.Text = "Перейти к отрисовщику";
      this.drawerButton.UseVisualStyleBackColor = true;
      this.drawerButton.Click += new System.EventHandler(this.drawerButton_Click);
      // 
      // MenuForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(749, 751);
      this.Controls.Add(this.drawerButton);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MenuForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Конфигуратор";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button drawerButton;
  }
}

