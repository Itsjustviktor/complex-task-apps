
namespace ExampleAdoNet
{
    partial class Orders
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
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textb_id = new System.Windows.Forms.TextBox();
            this.textb_number = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textb_first = new System.Windows.Forms.TextBox();
            this.textb_second = new System.Windows.Forms.TextBox();
            this.textb_third = new System.Windows.Forms.TextBox();
            this.checkb_id = new System.Windows.Forms.CheckBox();
            this.checkb_number = new System.Windows.Forms.CheckBox();
            this.checkb_second = new System.Windows.Forms.CheckBox();
            this.checkb_first = new System.Windows.Forms.CheckBox();
            this.checkb_third = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.label3 = new System.Windows.Forms.Label();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tracknumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // dg1
            // 
            this.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.numberCol,
            this.statusCol,
            this.dateCol,
            this.priceCol,
            this.tracknumCol});
            this.dg1.Location = new System.Drawing.Point(14, 227);
            this.dg1.Name = "dg1";
            this.dg1.RowHeadersWidth = 51;
            this.dg1.RowTemplate.Height = 24;
            this.dg1.Size = new System.Drawing.Size(872, 338);
            this.dg1.TabIndex = 0;
            this.dg1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg1_RowHeaderMouseDoubleClick);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(905, 459);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(125, 51);
            this.refresh.TabIndex = 1;
            this.refresh.Text = "обновить таблицу";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск по данным:";
            // 
            // textb_id
            // 
            this.textb_id.Enabled = false;
            this.textb_id.Location = new System.Drawing.Point(34, 65);
            this.textb_id.Name = "textb_id";
            this.textb_id.Size = new System.Drawing.Size(180, 22);
            this.textb_id.TabIndex = 3;
            // 
            // textb_number
            // 
            this.textb_number.Enabled = false;
            this.textb_number.Location = new System.Drawing.Point(34, 104);
            this.textb_number.Name = "textb_number";
            this.textb_number.Size = new System.Drawing.Size(180, 22);
            this.textb_number.TabIndex = 5;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(34, 153);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(128, 40);
            this.find.TabIndex = 7;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Имя";
            // 
            // textb_first
            // 
            this.textb_first.Enabled = false;
            this.textb_first.Location = new System.Drawing.Point(435, 104);
            this.textb_first.Name = "textb_first";
            this.textb_first.Size = new System.Drawing.Size(180, 22);
            this.textb_first.TabIndex = 11;
            // 
            // textb_second
            // 
            this.textb_second.Enabled = false;
            this.textb_second.Location = new System.Drawing.Point(435, 65);
            this.textb_second.Name = "textb_second";
            this.textb_second.Size = new System.Drawing.Size(180, 22);
            this.textb_second.TabIndex = 9;
            // 
            // textb_third
            // 
            this.textb_third.Enabled = false;
            this.textb_third.Location = new System.Drawing.Point(435, 141);
            this.textb_third.Name = "textb_third";
            this.textb_third.Size = new System.Drawing.Size(180, 22);
            this.textb_third.TabIndex = 13;
            // 
            // checkb_id
            // 
            this.checkb_id.AutoSize = true;
            this.checkb_id.Location = new System.Drawing.Point(240, 65);
            this.checkb_id.Name = "checkb_id";
            this.checkb_id.Size = new System.Drawing.Size(90, 21);
            this.checkb_id.TabIndex = 15;
            this.checkb_id.Text = "id заказа";
            this.checkb_id.UseVisualStyleBackColor = true;
            this.checkb_id.CheckedChanged += new System.EventHandler(this.checkb_id_CheckedChanged);
            // 
            // checkb_number
            // 
            this.checkb_number.AutoSize = true;
            this.checkb_number.Location = new System.Drawing.Point(240, 104);
            this.checkb_number.Name = "checkb_number";
            this.checkb_number.Size = new System.Drawing.Size(143, 21);
            this.checkb_number.TabIndex = 16;
            this.checkb_number.Text = "Номер телефона";
            this.checkb_number.UseVisualStyleBackColor = true;
            this.checkb_number.CheckedChanged += new System.EventHandler(this.checkb_number_CheckedChanged);
            // 
            // checkb_second
            // 
            this.checkb_second.AutoSize = true;
            this.checkb_second.Location = new System.Drawing.Point(641, 65);
            this.checkb_second.Name = "checkb_second";
            this.checkb_second.Size = new System.Drawing.Size(92, 21);
            this.checkb_second.TabIndex = 17;
            this.checkb_second.Text = "Фамилия";
            this.checkb_second.UseVisualStyleBackColor = true;
            this.checkb_second.CheckedChanged += new System.EventHandler(this.checkb_second_CheckedChanged);
            // 
            // checkb_first
            // 
            this.checkb_first.AutoSize = true;
            this.checkb_first.Location = new System.Drawing.Point(641, 103);
            this.checkb_first.Name = "checkb_first";
            this.checkb_first.Size = new System.Drawing.Size(57, 21);
            this.checkb_first.TabIndex = 18;
            this.checkb_first.Text = "Имя";
            this.checkb_first.UseVisualStyleBackColor = true;
            this.checkb_first.CheckedChanged += new System.EventHandler(this.checkb_first_CheckedChanged);
            // 
            // checkb_third
            // 
            this.checkb_third.AutoSize = true;
            this.checkb_third.Location = new System.Drawing.Point(640, 142);
            this.checkb_third.Name = "checkb_third";
            this.checkb_third.Size = new System.Drawing.Size(93, 21);
            this.checkb_third.TabIndex = 19;
            this.checkb_third.Text = "Отчество";
            this.checkb_third.UseVisualStyleBackColor = true;
            this.checkb_third.CheckedChanged += new System.EventHandler(this.checkb_third_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "*Для выбора критерий поставьте галочку рядом с полем и введите значение";
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "--------------------------";
            // 
            // idCol
            // 
            this.idCol.HeaderText = "id заказа";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            // 
            // numberCol
            // 
            this.numberCol.HeaderText = "Номер телефона";
            this.numberCol.MinimumWidth = 6;
            this.numberCol.Name = "numberCol";
            // 
            // statusCol
            // 
            this.statusCol.HeaderText = "Статус заказа";
            this.statusCol.MinimumWidth = 6;
            this.statusCol.Name = "statusCol";
            // 
            // dateCol
            // 
            this.dateCol.HeaderText = "Дата заказа";
            this.dateCol.MinimumWidth = 6;
            this.dateCol.Name = "dateCol";
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Цена заказа";
            this.priceCol.MinimumWidth = 6;
            this.priceCol.Name = "priceCol";
            // 
            // tracknumCol
            // 
            this.tracknumCol.HeaderText = "Трек номер";
            this.tracknumCol.MinimumWidth = 6;
            this.tracknumCol.Name = "tracknumCol";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 577);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkb_third);
            this.Controls.Add(this.checkb_first);
            this.Controls.Add(this.checkb_second);
            this.Controls.Add(this.checkb_number);
            this.Controls.Add(this.checkb_id);
            this.Controls.Add(this.textb_third);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textb_first);
            this.Controls.Add(this.textb_second);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.find);
            this.Controls.Add(this.textb_number);
            this.Controls.Add(this.textb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dg1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textb_id;
        private System.Windows.Forms.TextBox textb_number;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textb_first;
        private System.Windows.Forms.TextBox textb_second;
        private System.Windows.Forms.TextBox textb_third;
        private System.Windows.Forms.CheckBox checkb_id;
        private System.Windows.Forms.CheckBox checkb_number;
        private System.Windows.Forms.CheckBox checkb_second;
        private System.Windows.Forms.CheckBox checkb_first;
        private System.Windows.Forms.CheckBox checkb_third;
        private System.Windows.Forms.Label label2;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tracknumCol;
    }
}