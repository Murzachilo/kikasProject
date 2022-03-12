
namespace nik
{
    partial class ProstoDel
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
            this.делаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advokastkayaKontoraDataSet = new nik.AdvokastkayaKontoraDataSet();
            this.делаTableAdapter = new nik.AdvokastkayaKontoraDataSetTableAdapters.ДелаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.advokastkayaKontoraDataSet3 = new nik.AdvokastkayaKontoraDataSet3();
            this.делаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.делаTableAdapter1 = new nik.AdvokastkayaKontoraDataSet3TableAdapters.ДелаTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.advokastkayaKontoraDataSet1 = new nik.AdvokastkayaKontoraDataSet();
            this.делаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сутьДелаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.завершениеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // делаBindingSource
            // 
            this.делаBindingSource.DataMember = "Дела";
            this.делаBindingSource.DataSource = this.advokastkayaKontoraDataSet;
            // 
            // advokastkayaKontoraDataSet
            // 
            this.advokastkayaKontoraDataSet.DataSetName = "AdvokastkayaKontoraDataSet";
            this.advokastkayaKontoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // делаTableAdapter
            // 
            this.делаTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(663, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Режим админа";
            // 
            // advokastkayaKontoraDataSet3
            // 
            this.advokastkayaKontoraDataSet3.DataSetName = "AdvokastkayaKontoraDataSet3";
            this.advokastkayaKontoraDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // делаBindingSource1
            // 
            this.делаBindingSource1.DataMember = "Дела";
            this.делаBindingSource1.DataSource = this.advokastkayaKontoraDataSet3;
            // 
            // делаTableAdapter1
            // 
            this.делаTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.кодКлиентаDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.сутьДелаDataGridViewTextBoxColumn1,
            this.началоDataGridViewTextBoxColumn1,
            this.завершениеDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.делаBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(24, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(859, 141);
            this.dataGridView2.TabIndex = 6;
            // 
            // advokastkayaKontoraDataSet1
            // 
            this.advokastkayaKontoraDataSet1.DataSetName = "AdvokastkayaKontoraDataSet";
            this.advokastkayaKontoraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // делаBindingSource2
            // 
            this.делаBindingSource2.DataMember = "Дела";
            this.делаBindingSource2.DataSource = this.advokastkayaKontoraDataSet1;
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            this.кодDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // кодКлиентаDataGridViewTextBoxColumn1
            // 
            this.кодКлиентаDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.кодКлиентаDataGridViewTextBoxColumn1.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn1.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодКлиентаDataGridViewTextBoxColumn1.Name = "кодКлиентаDataGridViewTextBoxColumn1";
            this.кодКлиентаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сутьДелаDataGridViewTextBoxColumn1
            // 
            this.сутьДелаDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.сутьДелаDataGridViewTextBoxColumn1.DataPropertyName = "Суть дела";
            this.сутьДелаDataGridViewTextBoxColumn1.HeaderText = "Суть дела";
            this.сутьДелаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.сутьДелаDataGridViewTextBoxColumn1.Name = "сутьДелаDataGridViewTextBoxColumn1";
            this.сутьДелаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // началоDataGridViewTextBoxColumn1
            // 
            this.началоDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.началоDataGridViewTextBoxColumn1.DataPropertyName = "Начало";
            this.началоDataGridViewTextBoxColumn1.HeaderText = "Начало";
            this.началоDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.началоDataGridViewTextBoxColumn1.Name = "началоDataGridViewTextBoxColumn1";
            this.началоDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // завершениеDataGridViewTextBoxColumn1
            // 
            this.завершениеDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.завершениеDataGridViewTextBoxColumn1.DataPropertyName = "Завершение";
            this.завершениеDataGridViewTextBoxColumn1.HeaderText = "Завершение";
            this.завершениеDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.завершениеDataGridViewTextBoxColumn1.Name = "завершениеDataGridViewTextBoxColumn1";
            this.завершениеDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ProstoDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 509);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ProstoDel";
            this.Text = "ProstoDel";
            this.Load += new System.EventHandler(this.ProstoDel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AdvokastkayaKontoraDataSet advokastkayaKontoraDataSet;
        private System.Windows.Forms.BindingSource делаBindingSource;
        private AdvokastkayaKontoraDataSetTableAdapters.ДелаTableAdapter делаTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private AdvokastkayaKontoraDataSet3 advokastkayaKontoraDataSet3;
        private System.Windows.Forms.BindingSource делаBindingSource1;
        private AdvokastkayaKontoraDataSet3TableAdapters.ДелаTableAdapter делаTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AdvokastkayaKontoraDataSet advokastkayaKontoraDataSet1;
        private System.Windows.Forms.BindingSource делаBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сутьДелаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn началоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn завершениеDataGridViewTextBoxColumn1;
    }
}