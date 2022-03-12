
namespace nik
{
    partial class zakdog
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
            this.advokastkayaKontoraDataSet = new nik.AdvokastkayaKontoraDataSet();
            this.договорBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договорTableAdapter = new nik.AdvokastkayaKontoraDataSetTableAdapters.ДоговорTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодУслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // advokastkayaKontoraDataSet
            // 
            this.advokastkayaKontoraDataSet.DataSetName = "AdvokastkayaKontoraDataSet";
            this.advokastkayaKontoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договорBindingSource
            // 
            this.договорBindingSource.DataMember = "Договор";
            this.договорBindingSource.DataSource = this.advokastkayaKontoraDataSet;
            // 
            // договорTableAdapter
            // 
            this.договорTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "Изменить запись";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "Добавить запись";
            this.button4.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(699, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "*Режим админа";
            // 
            // zakdog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "zakdog";
            this.Text = "zakdog";
            this.Load += new System.EventHandler(this.zakdog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advokastkayaKontoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AdvokastkayaKontoraDataSet advokastkayaKontoraDataSet;
        private System.Windows.Forms.BindingSource договорBindingSource;
        private AdvokastkayaKontoraDataSetTableAdapters.ДоговорTableAdapter договорTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодУслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}