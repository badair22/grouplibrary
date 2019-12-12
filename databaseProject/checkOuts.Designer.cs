namespace databaseProject
{
    partial class checkOuts
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
            this.homeButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.library_DBDataSet = new databaseProject.Library_DBDataSet();
            this.checkOutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkOutsTableAdapter = new databaseProject.Library_DBDataSetTableAdapters.CheckOutsTableAdapter();
            this.checkOutIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(359, 306);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkOutIDDataGridViewTextBoxColumn,
            this.accountIDDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.checkOutsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(136, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 239);
            this.dataGridView1.TabIndex = 1;
            // 
            // library_DBDataSet
            // 
            this.library_DBDataSet.DataSetName = "Library_DBDataSet";
            this.library_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkOutsBindingSource
            // 
            this.checkOutsBindingSource.DataMember = "CheckOuts";
            this.checkOutsBindingSource.DataSource = this.library_DBDataSet;
            // 
            // checkOutsTableAdapter
            // 
            this.checkOutsTableAdapter.ClearBeforeFill = true;
            // 
            // checkOutIDDataGridViewTextBoxColumn
            // 
            this.checkOutIDDataGridViewTextBoxColumn.DataPropertyName = "CheckOutID";
            this.checkOutIDDataGridViewTextBoxColumn.HeaderText = "CheckOutID";
            this.checkOutIDDataGridViewTextBoxColumn.Name = "checkOutIDDataGridViewTextBoxColumn";
            this.checkOutIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountIDDataGridViewTextBoxColumn
            // 
            this.accountIDDataGridViewTextBoxColumn.DataPropertyName = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.HeaderText = "AccountID";
            this.accountIDDataGridViewTextBoxColumn.Name = "accountIDDataGridViewTextBoxColumn";
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            // 
            // checkOuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.homeButton);
            this.Name = "checkOuts";
            this.Text = "Checked Out Materials";
            this.Load += new System.EventHandler(this.checkOuts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOutsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Library_DBDataSet library_DBDataSet;
        private System.Windows.Forms.BindingSource checkOutsBindingSource;
        private Library_DBDataSetTableAdapters.CheckOutsTableAdapter checkOutsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
    }
}