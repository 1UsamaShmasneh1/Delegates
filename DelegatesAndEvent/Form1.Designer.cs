namespace DelegatesAndEvent
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
            this.SubButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubButton
            // 
            this.SubButton.Location = new System.Drawing.Point(410, 103);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(125, 60);
            this.SubButton.TabIndex = 0;
            this.SubButton.Text = "Sub";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(197, 103);
            this.AddButton.Name = "AddButton";
            this.AddButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddButton.Size = new System.Drawing.Size(125, 60);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SubButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button AddButton;
    }
}