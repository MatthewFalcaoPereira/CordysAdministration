namespace CordysAdministration
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corrieSeDatabaseDataSet = new CordysAdministration.CorrieSeDatabaseDataSet();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelInput1 = new System.Windows.Forms.Label();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.labelInput2 = new System.Windows.Forms.Label();
            this.comboBoxTableSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInput3 = new System.Windows.Forms.Label();
            this.textBoxInput3 = new System.Windows.Forms.TextBox();
            this.labelInput4 = new System.Windows.Forms.Label();
            this.textBoxInput4 = new System.Windows.Forms.TextBox();
            this.labelInsert = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.productsTableAdapter = new CordysAdministration.CorrieSeDatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corrieSeDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(565, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.corrieSeDatabaseDataSet;
            // 
            // corrieSeDatabaseDataSet
            // 
            this.corrieSeDatabaseDataSet.DataSetName = "CorrieSeDatabaseDataSet";
            this.corrieSeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(749, 422);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(86, 45);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(872, 423);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(86, 45);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelInput1
            // 
            this.labelInput1.AutoSize = true;
            this.labelInput1.Location = new System.Drawing.Point(58, 78);
            this.labelInput1.Name = "labelInput1";
            this.labelInput1.Size = new System.Drawing.Size(44, 13);
            this.labelInput1.TabIndex = 4;
            this.labelInput1.Text = "Product";
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Location = new System.Drawing.Point(163, 75);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput1.TabIndex = 5;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Location = new System.Drawing.Point(163, 152);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput2.TabIndex = 6;
            // 
            // labelInput2
            // 
            this.labelInput2.AutoSize = true;
            this.labelInput2.Location = new System.Drawing.Point(58, 155);
            this.labelInput2.Name = "labelInput2";
            this.labelInput2.Size = new System.Drawing.Size(32, 13);
            this.labelInput2.TabIndex = 7;
            this.labelInput2.Text = "Store";
            this.labelInput2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxTableSelect
            // 
            this.comboBoxTableSelect.FormattingEnabled = true;
            this.comboBoxTableSelect.Location = new System.Drawing.Point(872, 43);
            this.comboBoxTableSelect.Name = "comboBoxTableSelect";
            this.comboBoxTableSelect.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTableSelect.TabIndex = 9;
            this.comboBoxTableSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(784, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Table Selected:";
            // 
            // labelInput3
            // 
            this.labelInput3.AutoSize = true;
            this.labelInput3.Location = new System.Drawing.Point(58, 245);
            this.labelInput3.Name = "labelInput3";
            this.labelInput3.Size = new System.Drawing.Size(30, 13);
            this.labelInput3.TabIndex = 11;
            this.labelInput3.Text = "Date";
            // 
            // textBoxInput3
            // 
            this.textBoxInput3.Location = new System.Drawing.Point(163, 242);
            this.textBoxInput3.Name = "textBoxInput3";
            this.textBoxInput3.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput3.TabIndex = 12;
            this.textBoxInput3.TextChanged += new System.EventHandler(this.textBoxInput3_TextChanged);
            // 
            // labelInput4
            // 
            this.labelInput4.AutoSize = true;
            this.labelInput4.Location = new System.Drawing.Point(58, 341);
            this.labelInput4.Name = "labelInput4";
            this.labelInput4.Size = new System.Drawing.Size(46, 13);
            this.labelInput4.TabIndex = 13;
            this.labelInput4.Text = "Quantity";
            // 
            // textBoxInput4
            // 
            this.textBoxInput4.Location = new System.Drawing.Point(163, 338);
            this.textBoxInput4.Name = "textBoxInput4";
            this.textBoxInput4.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput4.TabIndex = 14;
            // 
            // labelInsert
            // 
            this.labelInsert.AutoSize = true;
            this.labelInsert.Location = new System.Drawing.Point(58, 404);
            this.labelInsert.Name = "labelInsert";
            this.labelInsert.Size = new System.Drawing.Size(47, 13);
            this.labelInsert.TabIndex = 15;
            this.labelInsert.Text = "INSERT";
            this.labelInsert.Visible = false;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(178, 404);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(49, 13);
            this.labelDelete.TabIndex = 16;
            this.labelDelete.Text = "DELETE";
            this.labelDelete.Visible = false;
            this.labelDelete.Click += new System.EventHandler(this.labelDelete_Click);
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Location = new System.Drawing.Point(58, 439);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(51, 13);
            this.labelUpdate.TabIndex = 17;
            this.labelUpdate.Text = "UPDATE";
            this.labelUpdate.Visible = false;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(620, 422);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(86, 45);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 479);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelInsert);
            this.Controls.Add(this.textBoxInput4);
            this.Controls.Add(this.labelInput4);
            this.Controls.Add(this.textBoxInput3);
            this.Controls.Add(this.labelInput3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTableSelect);
            this.Controls.Add(this.labelInput2);
            this.Controls.Add(this.textBoxInput2);
            this.Controls.Add(this.textBoxInput1);
            this.Controls.Add(this.labelInput1);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corrieSeDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelInput1;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.Label labelInput2;
        private System.Windows.Forms.ComboBox comboBoxTableSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInput3;
        private System.Windows.Forms.TextBox textBoxInput3;
        private System.Windows.Forms.Label labelInput4;
        private System.Windows.Forms.TextBox textBoxInput4;
        private System.Windows.Forms.Label labelInsert;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelUpdate;
        private CorrieSeDatabaseDataSet corrieSeDatabaseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private CorrieSeDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonDelete;
    }
}

