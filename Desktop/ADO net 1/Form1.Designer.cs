namespace ExampleAdoNet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ConnDB = new System.Windows.Forms.Button();
            this.textBox_addres = new System.Windows.Forms.TextBox();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_database = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ConnDB
            // 
            this.btn_ConnDB.Location = new System.Drawing.Point(467, 353);
            this.btn_ConnDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ConnDB.Name = "btn_ConnDB";
            this.btn_ConnDB.Size = new System.Drawing.Size(139, 38);
            this.btn_ConnDB.TabIndex = 0;
            this.btn_ConnDB.Text = "Подключиться";
            this.btn_ConnDB.UseVisualStyleBackColor = true;
            this.btn_ConnDB.Click += new System.EventHandler(this.btn_ConnDB_Click);
            // 
            // textBox_addres
            // 
            this.textBox_addres.Location = new System.Drawing.Point(221, 54);
            this.textBox_addres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_addres.Name = "textBox_addres";
            this.textBox_addres.Size = new System.Drawing.Size(159, 22);
            this.textBox_addres.TabIndex = 1;
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(221, 167);
            this.textBox_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(159, 22);
            this.textBox_user.TabIndex = 2;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(221, 225);
            this.textBox_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(159, 22);
            this.textBox_pass.TabIndex = 3;
            // 
            // textBox_database
            // 
            this.textBox_database.Location = new System.Drawing.Point(221, 278);
            this.textBox_database.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_database.Name = "textBox_database";
            this.textBox_database.Size = new System.Drawing.Size(159, 22);
            this.textBox_database.TabIndex = 4;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(221, 111);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(159, 22);
            this.textBox_port.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Адрес сервера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Порт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя пользов.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "База данных";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(107, 361);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(303, 22);
            this.textBox_result.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 438);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_database);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.textBox_addres);
            this.Controls.Add(this.btn_ConnDB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ConnDB;
        private System.Windows.Forms.TextBox textBox_addres;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_database;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_result;
    }
}

