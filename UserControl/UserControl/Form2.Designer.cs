namespace UserControl
{
    partial class Form2
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
            this.addButton = new System.Windows.Forms.Button();
            this.departmentListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(295, 70);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(328, 24);
            this.departmentComboBox.TabIndex = 1;
            this.departmentComboBox.Text = "....Select....";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(494, 129);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(129, 30);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Data";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // departmentListBox
            // 
            this.departmentListBox.FormattingEnabled = true;
            this.departmentListBox.ItemHeight = 16;
            this.departmentListBox.Location = new System.Drawing.Point(54, 212);
            this.departmentListBox.Name = "departmentListBox";
            this.departmentListBox.Size = new System.Drawing.Size(314, 84);
            this.departmentListBox.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.departmentListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.departmentComboBox);
            this.Name = "Form2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox departmentListBox;
    }
}