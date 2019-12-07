namespace databaseProject
{
    partial class removeMaterial
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
            this.removeLabel = new System.Windows.Forms.Label();
            this.removeTextbox = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeLabel
            // 
            this.removeLabel.AutoSize = true;
            this.removeLabel.Location = new System.Drawing.Point(85, 70);
            this.removeLabel.Name = "removeLabel";
            this.removeLabel.Size = new System.Drawing.Size(98, 13);
            this.removeLabel.TabIndex = 0;
            this.removeLabel.Text = "Remove MaterialID";
            // 
            // removeTextbox
            // 
            this.removeTextbox.Location = new System.Drawing.Point(240, 63);
            this.removeTextbox.Name = "removeTextbox";
            this.removeTextbox.Size = new System.Drawing.Size(224, 20);
            this.removeTextbox.TabIndex = 1;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(191, 145);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Home Page";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(351, 145);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeMaterial
            // 
            this.AcceptButton = this.removeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 362);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.removeTextbox);
            this.Controls.Add(this.removeLabel);
            this.Name = "removeMaterial";
            this.Text = "Remove Material";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label removeLabel;
        private System.Windows.Forms.TextBox removeTextbox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button removeButton;
    }
}