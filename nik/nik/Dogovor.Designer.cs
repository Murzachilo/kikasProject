
namespace nik
{
    partial class Dogovor
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
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.договорBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advokastkayaKontoraDataSet = new nik.AdvokastkayaKontoraDataSet();
            this.договорTableAdapter = new nik.AdvokastkayaKontoraDataSetTableAdapters.ДоговорTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.договорBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.advokastkayaKontoraDataSet4 = new nik.AdvokastkayaKontoraDataSet4();
            this.договорTableAdapter1 = new nik.AdvokastkayaKontoraDataSet4TableAdapters.ДоговорTableAdapter();
            this.договорBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new nik.AdvokastkayaKontoraDataSetTableAdapters.КлиентTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.сотрудникDataGridViewTextBoxColumn,
            this.клиентDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.кодУслугиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.договорBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 114);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сотрудникDataGridViewTextBoxColumn
            // 
            this.сотрудникDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.сотрудникDataGridViewTextBoxColumn.DataPropertyName = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сотрудникDataGridViewTextBoxColumn.Name = "сотрудникDataGridViewTextBoxColumn";
            this.сотрудникDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // клиентDataGridViewTextBoxColumn
            // 
            this.клиентDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.клиентDataGridViewTextBoxColumn.DataPropertyName = "Клиент";
            this.клиентDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.клиентDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.клиентDataGridViewTextBoxColumn.Name = "клиентDataGridViewTextBoxColumn";
            this.клиентDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодУслугиDataGridViewTextBoxColumn
            // 
            this.кодУслугиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.кодУслугиDataGridViewTextBoxColumn.DataPropertyName = "КодУслуги";
            this.кодУслугиDataGridViewTextBoxColumn.HeaderText = "КодУслуги";
            this.кодУслугиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодУслугиDataGridViewTextBoxColumn.Name = "кодУслугиDataGridViewTextBoxColumn";
            this.кодУслугиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // договорBindingSource
            // 
            this.договорBindingSource.DataMember = "Договор";
            this.договорBindingSource.DataSource = this.advokastkayaKontoraDataSet;
            // 
            // advokastkayaKontoraDataSet
            // 
            this.advokastkayaKontoraDataSet.DataSetName = "AdvokastkayaKontoraDataSet";
            this.advokastkayaKontoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договорTableAdapter
            // 
            this.договорTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(708, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "*Режим админа";
            // 
            // договорBindingSource1
            // 
            this.договорBindingSource1.DataMember = "Договор";
            this.договорBindingSource1.DataSource = this.advokastkayaKontoraDataSet4;
            // 
            // advokastkayaKontoraDataSet4
            // 
            this.advokastkayaKontoraDataSet4.DataSetName = "AdvokastkayaKontoraDataSet4";
            this.advokastkayaKontoraDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договорTableAdapter1
            // 
            this.договорTableAdapter1.ClearBeforeFill = true;
            // 
            // договорBindingSource2
            // 
            this.договорBindingSource2.DataMember = "Договор";
            this.договорBindingSource2.DataSource = this.advokastkayaKontoraDataSet;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.advokastkayaKontoraDataSet;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // Dogovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dogovor";
            this.Text = "Dogovor";
            this.Load += new System.EventHandler(this.Dogovor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AdvokastkayaKontoraDataSet advokastkayaKontoraDataSet;
        private System.Windows.Forms.BindingSource договорBindingSource;
        private AdvokastkayaKontoraDataSetTableAdapters.ДоговорTableAdapter договорTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодУслугиDataGridViewTextBoxColumn;
        private AdvokastkayaKontoraDataSet4 advokastkayaKontoraDataSet4;
        private System.Windows.Forms.BindingSource договорBindingSource1;
        private AdvokastkayaKontoraDataSet4TableAdapters.ДоговорTableAdapter договорTableAdapter1;
        private System.Windows.Forms.BindingSource договорBindingSource2;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private AdvokastkayaKontoraDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
    }
}