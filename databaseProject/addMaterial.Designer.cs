namespace databaseProject
{
    partial class addMaterial
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.publishLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.authorFirstLabel = new System.Windows.Forms.Label();
            this.authorLastLabel = new System.Windows.Forms.Label();
            this.producerFirstLabel = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.publishTextbox = new System.Windows.Forms.TextBox();
            this.typeTextbox = new System.Windows.Forms.TextBox();
            this.languageTextbox = new System.Windows.Forms.TextBox();
            this.authorFirstTextbox = new System.Windows.Forms.TextBox();
            this.authorLastTextbox = new System.Windows.Forms.TextBox();
            this.producerFirstTextbox = new System.Windows.Forms.TextBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.producerLastLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genreCombobox = new System.Windows.Forms.ComboBox();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_DBDataSet = new databaseProject.Library_DBDataSet();
            this.producerLastTextbox = new System.Windows.Forms.TextBox();
            this.genresTableAdapter = new databaseProject.Library_DBDataSetTableAdapters.GenresTableAdapter();
            this.conditionCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(49, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // publishLabel
            // 
            this.publishLabel.AutoSize = true;
            this.publishLabel.Location = new System.Drawing.Point(49, 64);
            this.publishLabel.Name = "publishLabel";
            this.publishLabel.Size = new System.Drawing.Size(67, 13);
            this.publishLabel.TabIndex = 1;
            this.publishLabel.Text = "Publish Date";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(49, 93);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Type";
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(49, 126);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(51, 13);
            this.conditionLabel.TabIndex = 3;
            this.conditionLabel.Text = "Condition";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(49, 162);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(55, 13);
            this.languageLabel.TabIndex = 4;
            this.languageLabel.Text = "Language";
            // 
            // authorFirstLabel
            // 
            this.authorFirstLabel.AutoSize = true;
            this.authorFirstLabel.Location = new System.Drawing.Point(49, 202);
            this.authorFirstLabel.Name = "authorFirstLabel";
            this.authorFirstLabel.Size = new System.Drawing.Size(91, 13);
            this.authorFirstLabel.TabIndex = 5;
            this.authorFirstLabel.Text = "Author First Name";
            // 
            // authorLastLabel
            // 
            this.authorLastLabel.AutoSize = true;
            this.authorLastLabel.Location = new System.Drawing.Point(49, 234);
            this.authorLastLabel.Name = "authorLastLabel";
            this.authorLastLabel.Size = new System.Drawing.Size(92, 13);
            this.authorLastLabel.TabIndex = 6;
            this.authorLastLabel.Text = "Author Last Name";
            // 
            // producerFirstLabel
            // 
            this.producerFirstLabel.AutoSize = true;
            this.producerFirstLabel.Location = new System.Drawing.Point(49, 261);
            this.producerFirstLabel.Name = "producerFirstLabel";
            this.producerFirstLabel.Size = new System.Drawing.Size(103, 13);
            this.producerFirstLabel.TabIndex = 7;
            this.producerFirstLabel.Text = "Producer First Name";
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(179, 32);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(162, 20);
            this.titleTextbox.TabIndex = 8;
            // 
            // publishTextbox
            // 
            this.publishTextbox.Location = new System.Drawing.Point(179, 64);
            this.publishTextbox.Name = "publishTextbox";
            this.publishTextbox.Size = new System.Drawing.Size(162, 20);
            this.publishTextbox.TabIndex = 9;
            // 
            // typeTextbox
            // 
            this.typeTextbox.Location = new System.Drawing.Point(179, 93);
            this.typeTextbox.Name = "typeTextbox";
            this.typeTextbox.Size = new System.Drawing.Size(162, 20);
            this.typeTextbox.TabIndex = 11;
            // 
            // languageTextbox
            // 
            this.languageTextbox.Location = new System.Drawing.Point(179, 162);
            this.languageTextbox.Name = "languageTextbox";
            this.languageTextbox.Size = new System.Drawing.Size(162, 20);
            this.languageTextbox.TabIndex = 12;
            // 
            // authorFirstTextbox
            // 
            this.authorFirstTextbox.Location = new System.Drawing.Point(179, 202);
            this.authorFirstTextbox.Name = "authorFirstTextbox";
            this.authorFirstTextbox.Size = new System.Drawing.Size(162, 20);
            this.authorFirstTextbox.TabIndex = 13;
            // 
            // authorLastTextbox
            // 
            this.authorLastTextbox.Location = new System.Drawing.Point(179, 234);
            this.authorLastTextbox.Name = "authorLastTextbox";
            this.authorLastTextbox.Size = new System.Drawing.Size(162, 20);
            this.authorLastTextbox.TabIndex = 14;
            // 
            // producerFirstTextbox
            // 
            this.producerFirstTextbox.Location = new System.Drawing.Point(179, 261);
            this.producerFirstTextbox.Name = "producerFirstTextbox";
            this.producerFirstTextbox.Size = new System.Drawing.Size(162, 20);
            this.producerFirstTextbox.TabIndex = 15;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(52, 399);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 16;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(266, 399);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add Material";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // producerLastLabel
            // 
            this.producerLastLabel.AutoSize = true;
            this.producerLastLabel.Location = new System.Drawing.Point(49, 301);
            this.producerLastLabel.Name = "producerLastLabel";
            this.producerLastLabel.Size = new System.Drawing.Size(104, 13);
            this.producerLastLabel.TabIndex = 19;
            this.producerLastLabel.Text = "Producer Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Genre";
            // 
            // genreCombobox
            // 
            this.genreCombobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.genresBindingSource, "GenreName", true));
            this.genreCombobox.DataSource = this.genresBindingSource;
            this.genreCombobox.DisplayMember = "GenreName";
            this.genreCombobox.FormattingEnabled = true;
            this.genreCombobox.Location = new System.Drawing.Point(179, 338);
            this.genreCombobox.Name = "genreCombobox";
            this.genreCombobox.Size = new System.Drawing.Size(162, 21);
            this.genreCombobox.TabIndex = 21;
            this.genreCombobox.ValueMember = "GenreID";
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.library_DBDataSet;
            // 
            // library_DBDataSet
            // 
            this.library_DBDataSet.DataSetName = "Library_DBDataSet";
            this.library_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producerLastTextbox
            // 
            this.producerLastTextbox.Location = new System.Drawing.Point(179, 301);
            this.producerLastTextbox.Name = "producerLastTextbox";
            this.producerLastTextbox.Size = new System.Drawing.Size(162, 20);
            this.producerLastTextbox.TabIndex = 22;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // conditionCombobox
            // 
            this.conditionCombobox.FormattingEnabled = true;
            this.conditionCombobox.Items.AddRange(new object[] {
            "Mint",
            "Good",
            "Fair",
            "Poor"});
            this.conditionCombobox.Location = new System.Drawing.Point(179, 126);
            this.conditionCombobox.Name = "conditionCombobox";
            this.conditionCombobox.Size = new System.Drawing.Size(162, 21);
            this.conditionCombobox.TabIndex = 23;
            // 
            // addMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 511);
            this.Controls.Add(this.conditionCombobox);
            this.Controls.Add(this.producerLastTextbox);
            this.Controls.Add(this.genreCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.producerLastLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.producerFirstTextbox);
            this.Controls.Add(this.authorLastTextbox);
            this.Controls.Add(this.authorFirstTextbox);
            this.Controls.Add(this.languageTextbox);
            this.Controls.Add(this.typeTextbox);
            this.Controls.Add(this.publishTextbox);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.producerFirstLabel);
            this.Controls.Add(this.authorLastLabel);
            this.Controls.Add(this.authorFirstLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.publishLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "addMaterial";
            this.Text = "Add a Material";
            this.Load += new System.EventHandler(this.addMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label publishLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label authorFirstLabel;
        private System.Windows.Forms.Label authorLastLabel;
        private System.Windows.Forms.Label producerFirstLabel;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.TextBox publishTextbox;
        private System.Windows.Forms.TextBox typeTextbox;
        private System.Windows.Forms.TextBox languageTextbox;
        private System.Windows.Forms.TextBox authorFirstTextbox;
        private System.Windows.Forms.TextBox authorLastTextbox;
        private System.Windows.Forms.TextBox producerFirstTextbox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label producerLastLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox genreCombobox;
        private System.Windows.Forms.TextBox producerLastTextbox;
        private Library_DBDataSet library_DBDataSet;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private Library_DBDataSetTableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.ComboBox conditionCombobox;
    }
}