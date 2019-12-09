namespace databaseProject
{
    partial class checkoutMaterial
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
            this.components = new System.ComponentModel.Container();
            this.titleCombobox = new System.Windows.Forms.ComboBox();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_DBDataSet = new databaseProject.Library_DBDataSet();
            this.materialsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new databaseProject.Library_DBDataSetTableAdapters.MaterialsTableAdapter();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorCombobox = new System.Windows.Forms.ComboBox();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conditionCombobox = new System.Windows.Forms.ComboBox();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.authorsTableAdapter = new databaseProject.Library_DBDataSetTableAdapters.AuthorsTableAdapter();
            this.homeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.accountLabel = new System.Windows.Forms.Label();
            this.accountTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleCombobox
            // 
            this.titleCombobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialsBindingSource, "Title", true));
            this.titleCombobox.DataSource = this.materialsBindingSource1;
            this.titleCombobox.DisplayMember = "Title";
            this.titleCombobox.FormattingEnabled = true;
            this.titleCombobox.Location = new System.Drawing.Point(159, 58);
            this.titleCombobox.Name = "titleCombobox";
            this.titleCombobox.Size = new System.Drawing.Size(188, 21);
            this.titleCombobox.TabIndex = 0;
            this.titleCombobox.ValueMember = "MaterialID";
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.library_DBDataSet;
            // 
            // library_DBDataSet
            // 
            this.library_DBDataSet.DataSetName = "Library_DBDataSet";
            this.library_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialsBindingSource1
            // 
            this.materialsBindingSource1.DataMember = "Materials";
            this.materialsBindingSource1.DataSource = this.libraryDBDataSetBindingSource;
            // 
            // libraryDBDataSetBindingSource
            // 
            this.libraryDBDataSetBindingSource.DataSource = this.library_DBDataSet;
            this.libraryDBDataSetBindingSource.Position = 0;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(38, 58);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(41, 121);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author";
            // 
            // authorCombobox
            // 
            this.authorCombobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.authorsBindingSource, "FName", true));
            this.authorCombobox.DataSource = this.authorsBindingSource;
            this.authorCombobox.DisplayMember = "FName";
            this.authorCombobox.FormattingEnabled = true;
            this.authorCombobox.Location = new System.Drawing.Point(159, 121);
            this.authorCombobox.Name = "authorCombobox";
            this.authorCombobox.Size = new System.Drawing.Size(188, 21);
            this.authorCombobox.TabIndex = 3;
            this.authorCombobox.ValueMember = "AuthorID";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.libraryDBDataSetBindingSource;
            // 
            // conditionCombobox
            // 
            this.conditionCombobox.FormattingEnabled = true;
            this.conditionCombobox.Items.AddRange(new object[] {
            "Mint",
            "Good",
            "Fair",
            "Poor"});
            this.conditionCombobox.Location = new System.Drawing.Point(159, 194);
            this.conditionCombobox.Name = "conditionCombobox";
            this.conditionCombobox.Size = new System.Drawing.Size(188, 21);
            this.conditionCombobox.TabIndex = 4;
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(41, 194);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(51, 13);
            this.conditionLabel.TabIndex = 5;
            this.conditionLabel.Text = "Condition";
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(41, 340);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(272, 340);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(44, 267);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(61, 13);
            this.accountLabel.TabIndex = 8;
            this.accountLabel.Text = "Account ID";
            // 
            // accountTextbox
            // 
            this.accountTextbox.Location = new System.Drawing.Point(159, 267);
            this.accountTextbox.Name = "accountTextbox";
            this.accountTextbox.Size = new System.Drawing.Size(188, 20);
            this.accountTextbox.TabIndex = 9;
            // 
            // checkoutMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.accountTextbox);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.conditionCombobox);
            this.Controls.Add(this.authorCombobox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleCombobox);
            this.Name = "checkoutMaterial";
            this.Text = "checkoutMaterial";
            this.Load += new System.EventHandler(this.checkoutMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox titleCombobox;
        private System.Windows.Forms.BindingSource libraryDBDataSetBindingSource;
        private Library_DBDataSet library_DBDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private Library_DBDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.BindingSource materialsBindingSource1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.ComboBox authorCombobox;
        private System.Windows.Forms.ComboBox conditionCombobox;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private Library_DBDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.TextBox accountTextbox;
    }
}