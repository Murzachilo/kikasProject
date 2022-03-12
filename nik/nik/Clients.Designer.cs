
namespace nik
{
    partial class Form2
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
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advokastkayaKontoraDataSet = new nik.AdvokastkayaKontoraDataSet();
            this.клиентTableAdapter = new nik.AdvokastkayaKontoraDataSetTableAdapters.КлиентTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.advokastkayaKontoraDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процедурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процедурыTableAdapter = new nik.AdvokastkayaKontoraDataSetTableAdapters.ПроцедурыTableAdapter();
            this.клиентBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.клиентBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.клиентBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.advokastkayaKontoraDataSet2 = new nik.AdvokastkayaKontoraDataSet2();
            this.клиентBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter1 = new nik.AdvokastkayaKontoraDataSet2TableAdapters.КлиентTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияИНомерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоПропискиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоРегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедурыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.advokastkayaKontoraDataSet;
            // 
            // advokastkayaKontoraDataSet
            // 
            this.advokastkayaKontoraDataSet.DataSetName = "AdvokastkayaKontoraDataSet";
            this.advokastkayaKontoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(973, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1062, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Режим админа";
            // 
            // advokastkayaKontoraDataSetBindingSource
            // 
            this.advokastkayaKontoraDataSetBindingSource.DataSource = this.advokastkayaKontoraDataSet;
            this.advokastkayaKontoraDataSetBindingSource.Position = 0;
            // 
            // процедурыBindingSource
            // 
            this.процедурыBindingSource.DataMember = "Процедуры";
            this.процедурыBindingSource.DataSource = this.advokastkayaKontoraDataSetBindingSource;
            // 
            // процедурыTableAdapter
            // 
            this.процедурыTableAdapter.ClearBeforeFill = true;
            // 
            // клиентBindingSource1
            // 
            this.клиентBindingSource1.DataMember = "Клиент";
            this.клиентBindingSource1.DataSource = this.advokastkayaKontoraDataSet;
            // 
            // клиентBindingSource2
            // 
            this.клиентBindingSource2.DataMember = "Клиент";
            this.клиентBindingSource2.DataSource = this.advokastkayaKontoraDataSetBindingSource;
            // 
            // клиентBindingSource3
            // 
            this.клиентBindingSource3.DataMember = "Клиент";
            this.клиентBindingSource3.DataSource = this.advokastkayaKontoraDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.серияИНомерПаспортаDataGridViewTextBoxColumn,
            this.местоПропискиDataGridViewTextBoxColumn,
            this.местоРегистрацииDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(7, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 148);
            this.dataGridView1.TabIndex = 5;
            // 
            // advokastkayaKontoraDataSet2
            // 
            this.advokastkayaKontoraDataSet2.DataSetName = "AdvokastkayaKontoraDataSet2";
            this.advokastkayaKontoraDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентBindingSource4
            // 
            this.клиентBindingSource4.DataMember = "Клиент";
            this.клиентBindingSource4.DataSource = this.advokastkayaKontoraDataSet2;
            // 
            // клиентTableAdapter1
            // 
            this.клиентTableAdapter1.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // серияИНомерПаспортаDataGridViewTextBoxColumn
            // 
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия и номер паспорта";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.HeaderText = "Серия и номер паспорта";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.Name = "серияИНомерПаспортаDataGridViewTextBoxColumn";
            // 
            // местоПропискиDataGridViewTextBoxColumn
            // 
            this.местоПропискиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.местоПропискиDataGridViewTextBoxColumn.DataPropertyName = "Место прописки";
            this.местоПропискиDataGridViewTextBoxColumn.HeaderText = "Место прописки";
            this.местоПропискиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.местоПропискиDataGridViewTextBoxColumn.Name = "местоПропискиDataGridViewTextBoxColumn";
            // 
            // местоРегистрацииDataGridViewTextBoxColumn
            // 
            this.местоРегистрацииDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.местоРегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Место регистрации";
            this.местоРегистрацииDataGridViewTextBoxColumn.HeaderText = "Место регистрации";
            this.местоРегистрацииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.местоРегистрацииDataGridViewTextBoxColumn.Name = "местоРегистрацииDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 598);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Список клиентов";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедурыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AdvokastkayaKontoraDataSet advokastkayaKontoraDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private AdvokastkayaKontoraDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource advokastkayaKontoraDataSetBindingSource;
        private System.Windows.Forms.BindingSource процедурыBindingSource;
        private AdvokastkayaKontoraDataSetTableAdapters.ПроцедурыTableAdapter процедурыTableAdapter;
        private System.Windows.Forms.BindingSource клиентBindingSource1;
        private System.Windows.Forms.BindingSource клиентBindingSource2;
        private System.Windows.Forms.BindingSource клиентBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdvokastkayaKontoraDataSet2 advokastkayaKontoraDataSet2;
        private System.Windows.Forms.BindingSource клиентBindingSource4;
        private AdvokastkayaKontoraDataSet2TableAdapters.КлиентTableAdapter клиентTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияИНомерПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоПропискиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоРегистрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
    }
}