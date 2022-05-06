namespace DoorsApplication
{
    partial class Journal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Jr_come = new System.Windows.Forms.DateTimePicker();
            this.Jr_out = new System.Windows.Forms.DateTimePicker();
            this.Jr_order = new System.Windows.Forms.TextBox();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.Submit_but = new System.Windows.Forms.Button();
            this.Jr_worker = new System.Windows.Forms.TextBox();
            this.Jr_customer = new System.Windows.Forms.TextBox();
            this.Jr_product = new System.Windows.Forms.TextBox();
            this.Journal_delete = new System.Windows.Forms.Button();
            this.Journal_search = new System.Windows.Forms.Button();
            this.Journal_change = new System.Windows.Forms.Button();
            this.Products_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(547, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Журнал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(797, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заказ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата  исполнения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата размещения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGreen;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(746, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Работник:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleGreen;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(776, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 33);
            this.label6.TabIndex = 6;
            this.label6.Text = "Клиент:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleGreen;
            this.label7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(792, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Товар:";
            // 
            // Jr_come
            // 
            this.Jr_come.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jr_come.Location = new System.Drawing.Point(357, 127);
            this.Jr_come.Name = "Jr_come";
            this.Jr_come.Size = new System.Drawing.Size(325, 30);
            this.Jr_come.TabIndex = 8;
            // 
            // Jr_out
            // 
            this.Jr_out.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jr_out.Location = new System.Drawing.Point(357, 179);
            this.Jr_out.Name = "Jr_out";
            this.Jr_out.Size = new System.Drawing.Size(325, 30);
            this.Jr_out.TabIndex = 9;
            // 
            // Jr_order
            // 
            this.Jr_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jr_order.Location = new System.Drawing.Point(906, 123);
            this.Jr_order.Name = "Jr_order";
            this.Jr_order.Size = new System.Drawing.Size(284, 34);
            this.Jr_order.TabIndex = 10;
            // 
            // dgvJournal
            // 
            this.dgvJournal.AllowUserToAddRows = false;
            this.dgvJournal.AllowUserToDeleteRows = false;
            this.dgvJournal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Location = new System.Drawing.Point(36, 360);
            this.dgvJournal.Name = "dgvJournal";
            this.dgvJournal.ReadOnly = true;
            this.dgvJournal.RowHeadersVisible = false;
            this.dgvJournal.RowHeadersWidth = 51;
            this.dgvJournal.RowTemplate.Height = 24;
            this.dgvJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJournal.Size = new System.Drawing.Size(1230, 336);
            this.dgvJournal.TabIndex = 14;
            this.dgvJournal.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJournal_CellEnter);
            // 
            // Submit_but
            // 
            this.Submit_but.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_but.Location = new System.Drawing.Point(69, 271);
            this.Submit_but.Name = "Submit_but";
            this.Submit_but.Size = new System.Drawing.Size(139, 61);
            this.Submit_but.TabIndex = 15;
            this.Submit_but.Text = "Добавить";
            this.Submit_but.UseVisualStyleBackColor = true;
            this.Submit_but.Click += new System.EventHandler(this.Submit_but_Click);
            // 
            // Jr_worker
            // 
            this.Jr_worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jr_worker.Location = new System.Drawing.Point(906, 284);
            this.Jr_worker.Name = "Jr_worker";
            this.Jr_worker.Size = new System.Drawing.Size(284, 34);
            this.Jr_worker.TabIndex = 16;
            // 
            // Jr_customer
            // 
            this.Jr_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jr_customer.Location = new System.Drawing.Point(906, 227);
            this.Jr_customer.Name = "Jr_customer";
            this.Jr_customer.Size = new System.Drawing.Size(284, 34);
            this.Jr_customer.TabIndex = 17;
            // 
            // Jr_product
            // 
            this.Jr_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jr_product.Location = new System.Drawing.Point(906, 178);
            this.Jr_product.Name = "Jr_product";
            this.Jr_product.Size = new System.Drawing.Size(284, 34);
            this.Jr_product.TabIndex = 18;
            // 
            // Journal_delete
            // 
            this.Journal_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Journal_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Journal_delete.Location = new System.Drawing.Point(399, 271);
            this.Journal_delete.Name = "Journal_delete";
            this.Journal_delete.Size = new System.Drawing.Size(132, 61);
            this.Journal_delete.TabIndex = 34;
            this.Journal_delete.Text = "Удалить";
            this.Journal_delete.UseVisualStyleBackColor = false;
            this.Journal_delete.Click += new System.EventHandler(this.Journal_delete_Click);
            // 
            // Journal_search
            // 
            this.Journal_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Journal_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Journal_search.Location = new System.Drawing.Point(553, 271);
            this.Journal_search.Name = "Journal_search";
            this.Journal_search.Size = new System.Drawing.Size(132, 61);
            this.Journal_search.TabIndex = 33;
            this.Journal_search.Text = "Поиск";
            this.Journal_search.UseVisualStyleBackColor = false;
            this.Journal_search.Click += new System.EventHandler(this.Journal_search_Click);
            // 
            // Journal_change
            // 
            this.Journal_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Journal_change.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Journal_change.Location = new System.Drawing.Point(237, 271);
            this.Journal_change.Name = "Journal_change";
            this.Journal_change.Size = new System.Drawing.Size(132, 61);
            this.Journal_change.TabIndex = 32;
            this.Journal_change.Text = "Изменить";
            this.Journal_change.UseVisualStyleBackColor = false;
            this.Journal_change.Click += new System.EventHandler(this.Journal_change_Click);
            // 
            // Products_back
            // 
            this.Products_back.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Products_back.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products_back.Location = new System.Drawing.Point(23, 25);
            this.Products_back.Name = "Products_back";
            this.Products_back.Size = new System.Drawing.Size(93, 50);
            this.Products_back.TabIndex = 35;
            this.Products_back.Text = "Назад";
            this.Products_back.UseVisualStyleBackColor = false;
            this.Products_back.Click += new System.EventHandler(this.Products_back_Click);
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1288, 708);
            this.Controls.Add(this.Products_back);
            this.Controls.Add(this.Journal_delete);
            this.Controls.Add(this.Journal_search);
            this.Controls.Add(this.Journal_change);
            this.Controls.Add(this.Jr_product);
            this.Controls.Add(this.Jr_customer);
            this.Controls.Add(this.Jr_worker);
            this.Controls.Add(this.Submit_but);
            this.Controls.Add(this.dgvJournal);
            this.Controls.Add(this.Jr_order);
            this.Controls.Add(this.Jr_out);
            this.Controls.Add(this.Jr_come);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Journal";
            this.Text = "Journal";
            this.Load += new System.EventHandler(this.Journal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Jr_come;
        private System.Windows.Forms.DateTimePicker Jr_out;
        private System.Windows.Forms.TextBox Jr_order;
        private System.Windows.Forms.DataGridView dgvJournal;
        private System.Windows.Forms.Button Submit_but;
        private System.Windows.Forms.TextBox Jr_worker;
        private System.Windows.Forms.TextBox Jr_customer;
        private System.Windows.Forms.TextBox Jr_product;
        private System.Windows.Forms.Button Journal_delete;
        private System.Windows.Forms.Button Journal_search;
        private System.Windows.Forms.Button Journal_change;
        private System.Windows.Forms.Button Products_back;
    }
}