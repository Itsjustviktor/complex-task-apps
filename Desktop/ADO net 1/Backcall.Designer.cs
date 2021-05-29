
namespace ExampleAdoNet
{
    partial class Backcall
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solveCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер телефона";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск по данным:";
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(12, 86);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(141, 40);
            this.find.TabIndex = 8;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCol,
            this.numberCol,
            this.problemCol,
            this.solveCol});
            this.dg1.Location = new System.Drawing.Point(12, 190);
            this.dg1.Name = "dg1";
            this.dg1.RowHeadersWidth = 51;
            this.dg1.RowTemplate.Height = 24;
            this.dg1.Size = new System.Drawing.Size(861, 268);
            this.dg1.TabIndex = 9;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Имя";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Width = 125;
            // 
            // numberCol
            // 
            this.numberCol.HeaderText = "Номер телефона";
            this.numberCol.MinimumWidth = 6;
            this.numberCol.Name = "numberCol";
            this.numberCol.ReadOnly = true;
            this.numberCol.Width = 200;
            // 
            // problemCol
            // 
            this.problemCol.HeaderText = "Проблема";
            this.problemCol.MinimumWidth = 6;
            this.problemCol.Name = "problemCol";
            this.problemCol.Width = 250;
            // 
            // solveCol
            // 
            this.solveCol.HeaderText = "Решение";
            this.solveCol.MinimumWidth = 6;
            this.solveCol.Name = "solveCol";
            this.solveCol.Width = 125;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(12, 137);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(141, 40);
            this.refresh.TabIndex = 10;
            this.refresh.Text = "Обновить таблицу";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(779, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(729, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Добавить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Backcall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 503);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.find);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Backcall";
            this.Text = "Backcall";
            this.Load += new System.EventHandler(this.Backcall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn solveCol;
    }
}