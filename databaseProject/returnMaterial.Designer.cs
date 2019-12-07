namespace databaseProject
{
    partial class returnMaterial
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
            this.materialLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.materialTextbox = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.conditionCombobox = new System.Windows.Forms.ComboBox();
            this.checkoutLabel = new System.Windows.Forms.Label();
            this.checkoutTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(84, 72);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(58, 13);
            this.materialLabel.TabIndex = 0;
            this.materialLabel.Text = "Material ID";
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(84, 110);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(51, 13);
            this.conditionLabel.TabIndex = 1;
            this.conditionLabel.Text = "Condition";
            // 
            // materialTextbox
            // 
            this.materialTextbox.Location = new System.Drawing.Point(229, 72);
            this.materialTextbox.Name = "materialTextbox";
            this.materialTextbox.Size = new System.Drawing.Size(170, 20);
            this.materialTextbox.TabIndex = 2;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(106, 167);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(285, 167);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // conditionCombobox
            // 
            this.conditionCombobox.FormattingEnabled = true;
            this.conditionCombobox.Items.AddRange(new object[] {
            "Mint",
            "Good",
            "Fair",
            "Poor"});
            this.conditionCombobox.Location = new System.Drawing.Point(229, 110);
            this.conditionCombobox.Name = "conditionCombobox";
            this.conditionCombobox.Size = new System.Drawing.Size(170, 21);
            this.conditionCombobox.TabIndex = 6;
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.Location = new System.Drawing.Point(84, 34);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(67, 13);
            this.checkoutLabel.TabIndex = 7;
            this.checkoutLabel.Text = "Checkout ID";
            // 
            // checkoutTextbox
            // 
            this.checkoutTextbox.Location = new System.Drawing.Point(229, 34);
            this.checkoutTextbox.Name = "checkoutTextbox";
            this.checkoutTextbox.Size = new System.Drawing.Size(170, 20);
            this.checkoutTextbox.TabIndex = 8;
            // 
            // returnMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.checkoutTextbox);
            this.Controls.Add(this.checkoutLabel);
            this.Controls.Add(this.conditionCombobox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.materialTextbox);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.materialLabel);
            this.Name = "returnMaterial";
            this.Text = "returnMaterial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.TextBox materialTextbox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ComboBox conditionCombobox;
        private System.Windows.Forms.Label checkoutLabel;
        private System.Windows.Forms.TextBox checkoutTextbox;
    }
}