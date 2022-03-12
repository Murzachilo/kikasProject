
namespace nik
{
    partial class Archive
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.advokastkayaKontoraDataSet = new nik.AdvokastkayaKontoraDataSet();
            this.делаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.делаTableAdapter = new nik.AdvokastkayaKontoraDataSetTableAdapters.ДелаTableAdapter();
            this.делаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сутьДелаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.завершениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.делаBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.advokastkayaKontoraDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advokastkayaKontoraDataSet1 = new nik.AdvokastkayaKontoraDataSet1();
            this.делаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.делаBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.делаTableAdapter1 = new nik.AdvokastkayaKontoraDataSet1TableAdapters.ДелаTableAdapter();
            this.делаBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.процедурыTableAdapter = new nik.AdvokastkayaKontoraDataSetTableAdapters.ПроцедурыTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.fKПроцедурыДелаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKПроцедурыДелаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.advokastkayaKontoraDataSet2 = new nik.AdvokastkayaKontoraDataSet();
            this.делаBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сутьДелаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.завершениеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПроцедурыДелаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПроцедурыДелаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(717, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Изменить запись";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(730, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Режим админа";
            // 
            // advokastkayaKontoraDataSet
            // 
            this.advokastkayaKontoraDataSet.DataSetName = "AdvokastkayaKontoraDataSet";
            this.advokastkayaKontoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // делаBindingSource
            // 
            this.делаBindingSource.DataMember = "Дела";
            this.делаBindingSource.DataSource = this.advokastkayaKontoraDataSet;
            // 
            // делаTableAdapter
            // 
            this.делаTableAdapter.ClearBeforeFill = true;
            // 
            // делаBindingSource1
            // 
            this.делаBindingSource1.DataMember = "Дела";
            this.делаBindingSource1.DataSource = this.advokastkayaKontoraDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.сутьДелаDataGridViewTextBoxColumn,
            this.началоDataGridViewTextBoxColumn,
            this.завершениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.делаBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 80);
            this.dataGridView1.TabIndex = 5;
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
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            this.кодКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сутьДелаDataGridViewTextBoxColumn
            // 
            this.сутьДелаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.сутьДелаDataGridViewTextBoxColumn.DataPropertyName = "Суть дела";
            this.сутьДелаDataGridViewTextBoxColumn.HeaderText = "Суть дела";
            this.сутьДелаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сутьДелаDataGridViewTextBoxColumn.Name = "сутьДелаDataGridViewTextBoxColumn";
            this.сутьДелаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // началоDataGridViewTextBoxColumn
            // 
            this.началоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.началоDataGridViewTextBoxColumn.DataPropertyName = "Начало";
            this.началоDataGridViewTextBoxColumn.HeaderText = "Начало";
            this.началоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.началоDataGridViewTextBoxColumn.Name = "началоDataGridViewTextBoxColumn";
            this.началоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // завершениеDataGridViewTextBoxColumn
            // 
            this.завершениеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.завершениеDataGridViewTextBoxColumn.DataPropertyName = "Завершение";
            this.завершениеDataGridViewTextBoxColumn.HeaderText = "Завершение";
            this.завершениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.завершениеDataGridViewTextBoxColumn.Name = "завершениеDataGridViewTextBoxColumn";
            this.завершениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // делаBindingSource5
            // 
            this.делаBindingSource5.DataMember = "Дела";
            this.делаBindingSource5.DataSource = this.advokastkayaKontoraDataSet1BindingSource;
            // 
            // advokastkayaKontoraDataSet1BindingSource
            // 
            this.advokastkayaKontoraDataSet1BindingSource.DataSource = this.advokastkayaKontoraDataSet1;
            this.advokastkayaKontoraDataSet1BindingSource.Position = 0;
            // 
            // advokastkayaKontoraDataSet1
            // 
            this.advokastkayaKontoraDataSet1.DataSetName = "AdvokastkayaKontoraDataSet1";
            this.advokastkayaKontoraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // делаBindingSource2
            // 
            this.делаBindingSource2.DataMember = "Дела";
            this.делаBindingSource2.DataSource = this.advokastkayaKontoraDataSet;
            // 
            // делаBindingSource3
            // 
            this.делаBindingSource3.DataMember = "Дела";
            this.делаBindingSource3.DataSource = this.advokastkayaKontoraDataSet1;
            // 
            // делаTableAdapter1
            // 
            this.делаTableAdapter1.ClearBeforeFill = true;
            // 
            // делаBindingSource4
            // 
            this.делаBindingSource4.DataMember = "Дела";
            this.делаBindingSource4.DataSource = this.advokastkayaKontoraDataSet;
            // 
            // процедурыTableAdapter
            // 
            this.процедурыTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(733, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Меню";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fKПроцедурыДелаBindingSource
            // 
            this.fKПроцедурыДелаBindingSource.DataMember = "FK_Процедуры_Дела";
            this.fKПроцедурыДелаBindingSource.DataSource = this.делаBindingSource;
            // 
            // fKПроцедурыДелаBindingSource1
            // 
            this.fKПроцедурыДелаBindingSource1.DataMember = "FK_Процедуры_Дела";
            this.fKПроцедурыДелаBindingSource1.DataSource = this.делаBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.кодКлиентаDataGridViewTextBoxColumn1,
            this.сутьДелаDataGridViewTextBoxColumn1,
            this.началоDataGridViewTextBoxColumn1,
            this.завершениеDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.делаBindingSource6;
            this.dataGridView2.Location = new System.Drawing.Point(169, 283);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(331, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // advokastkayaKontoraDataSet2
            // 
            this.advokastkayaKontoraDataSet2.DataSetName = "AdvokastkayaKontoraDataSet";
            this.advokastkayaKontoraDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // делаBindingSource6
            // 
            this.делаBindingSource6.DataMember = "Дела";
            this.делаBindingSource6.DataSource = this.advokastkayaKontoraDataSet2;
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            this.кодDataGridViewTextBoxColumn1.Width = 125;
            // 
            // кодКлиентаDataGridViewTextBoxColumn1
            // 
            this.кодКлиентаDataGridViewTextBoxColumn1.DataPropertyName = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn1.HeaderText = "Код клиента";
            this.кодКлиентаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодКлиентаDataGridViewTextBoxColumn1.Name = "кодКлиентаDataGridViewTextBoxColumn1";
            this.кодКлиентаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // сутьДелаDataGridViewTextBoxColumn1
            // 
            this.сутьДелаDataGridViewTextBoxColumn1.DataPropertyName = "Суть дела";
            this.сутьДелаDataGridViewTextBoxColumn1.HeaderText = "Суть дела";
            this.сутьДелаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.сутьДелаDataGridViewTextBoxColumn1.Name = "сутьДелаDataGridViewTextBoxColumn1";
            this.сутьДелаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // началоDataGridViewTextBoxColumn1
            // 
            this.началоDataGridViewTextBoxColumn1.DataPropertyName = "Начало";
            this.началоDataGridViewTextBoxColumn1.HeaderText = "Начало";
            this.началоDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.началоDataGridViewTextBoxColumn1.Name = "началоDataGridViewTextBoxColumn1";
            this.началоDataGridViewTextBoxColumn1.Width = 125;
            // 
            // завершениеDataGridViewTextBoxColumn1
            // 
            this.завершениеDataGridViewTextBoxColumn1.DataPropertyName = "Завершение";
            this.завершениеDataGridViewTextBoxColumn1.HeaderText = "Завершение";
            this.завершениеDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.завершениеDataGridViewTextBoxColumn1.Name = "завершениеDataGridViewTextBoxColumn1";
            this.завершениеDataGridViewTextBoxColumn1.Width = 125;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 507);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Archive";
            this.Text = "Архив дел";
            this.Load += new System.EventHandler(this.Archive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПроцедурыДелаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПроцедурыДелаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.делаBindingSource6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private AdvokastkayaKontoraDataSet advokastkayaKontoraDataSet;
        private System.Windows.Forms.BindingSource делаBindingSource;
        private AdvokastkayaKontoraDataSetTableAdapters.ДелаTableAdapter делаTableAdapter;
        private System.Windows.Forms.BindingSource делаBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource делаBindingSource2;
        private AdvokastkayaKontoraDataSet1 advokastkayaKontoraDataSet1;
        private System.Windows.Forms.BindingSource делаBindingSource3;
        private AdvokastkayaKontoraDataSet1TableAdapters.ДелаTableAdapter делаTableAdapter1;
        private System.Windows.Forms.BindingSource делаBindingSource4;
        private System.Windows.Forms.BindingSource advokastkayaKontoraDataSet1BindingSource;
        private System.Windows.Forms.BindingSource fKПроцедурыДелаBindingSource;
        private AdvokastkayaKontoraDataSetTableAdapters.ПроцедурыTableAdapter процедурыTableAdapter;
        private System.Windows.Forms.BindingSource делаBindingSource5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сутьДелаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn началоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn завершениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKПроцедурыДелаBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AdvokastkayaKontoraDataSet advokastkayaKontoraDataSet2;
        private System.Windows.Forms.BindingSource делаBindingSource6;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn сутьДелаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn началоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn завершениеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
    }
}