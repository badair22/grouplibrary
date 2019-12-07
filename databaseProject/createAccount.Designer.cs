namespace databaseProject
{
    partial class createAccount
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
            this.firstLabel = new System.Windows.Forms.Label();
            this.lastLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.firstTextbox = new System.Windows.Forms.TextBox();
            this.lastTextbox = new System.Windows.Forms.TextBox();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(123, 57);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(57, 13);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.Text = "First Name";
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(123, 93);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(58, 13);
            this.lastLabel.TabIndex = 1;
            this.lastLabel.Text = "Last Name";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(123, 132);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Phone Number";
            // 
            // firstTextbox
            // 
            this.firstTextbox.Location = new System.Drawing.Point(253, 57);
            this.firstTextbox.Name = "firstTextbox";
            this.firstTextbox.Size = new System.Drawing.Size(147, 20);
            this.firstTextbox.TabIndex = 4;
            // 
            // lastTextbox
            // 
            this.lastTextbox.Location = new System.Drawing.Point(253, 93);
            this.lastTextbox.Name = "lastTextbox";
            this.lastTextbox.Size = new System.Drawing.Size(147, 20);
            this.lastTextbox.TabIndex = 5;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(253, 132);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(147, 20);
            this.phoneTextbox.TabIndex = 6;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(126, 261);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 8;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(325, 261);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(123, 171);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address";
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(253, 171);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(147, 20);
            this.addressTextbox.TabIndex = 11;
            // 
            // createAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.lastTextbox);
            this.Controls.Add(this.firstTextbox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lastLabel);
            this.Controls.Add(this.firstLabel);
            this.Name = "createAccount";
            this.Text = "createAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox firstTextbox;
        private System.Windows.Forms.TextBox lastTextbox;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextbox;
    }
}