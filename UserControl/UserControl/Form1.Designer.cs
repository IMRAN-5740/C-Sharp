namespace UserControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.anotherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(263, 125);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(328, 24);
            this.departmentComboBox.TabIndex = 0;
            this.departmentComboBox.Text = "....Select....";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(382, 186);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(129, 30);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show Data";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // anotherButton
            // 
            this.anotherButton.Location = new System.Drawing.Point(468, 324);
            this.anotherButton.Name = "anotherButton";
            this.anotherButton.Size = new System.Drawing.Size(132, 23);
            this.anotherButton.TabIndex = 2;
            this.anotherButton.Text = "Another Form";
            this.anotherButton.UseVisualStyleBackColor = true;
            this.anotherButton.Click += new System.EventHandler(this.anotherButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anotherButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.departmentComboBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button anotherButton;
    }
}

