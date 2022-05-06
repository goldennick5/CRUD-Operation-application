namespace DoorsApplication
{
    partial class MainSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSite));
            this.Products_but = new System.Windows.Forms.Button();
            this.Workers_but = new System.Windows.Forms.Button();
            this.Customers_but = new System.Windows.Forms.Button();
            this.Choice = new System.Windows.Forms.Label();
            this.Journal_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Products_but
            // 
            this.Products_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Products_but.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products_but.Location = new System.Drawing.Point(103, 216);
            this.Products_but.Name = "Products_but";
            this.Products_but.Size = new System.Drawing.Size(169, 62);
            this.Products_but.TabIndex = 0;
            this.Products_but.Text = "Товары";
            this.Products_but.UseVisualStyleBackColor = false;
            this.Products_but.Click += new System.EventHandler(this.Products_Click);
            // 
            // Workers_but
            // 
            this.Workers_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Workers_but.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workers_but.Location = new System.Drawing.Point(278, 216);
            this.Workers_but.Name = "Workers_but";
            this.Workers_but.Size = new System.Drawing.Size(248, 62);
            this.Workers_but.TabIndex = 1;
            this.Workers_but.Text = "Персонал";
            this.Workers_but.UseVisualStyleBackColor = false;
            this.Workers_but.Click += new System.EventHandler(this.Workers_Click);
            // 
            // Customers_but
            // 
            this.Customers_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Customers_but.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers_but.Location = new System.Drawing.Point(532, 216);
            this.Customers_but.Name = "Customers_but";
            this.Customers_but.Size = new System.Drawing.Size(169, 62);
            this.Customers_but.TabIndex = 2;
            this.Customers_but.Text = "Клиенты";
            this.Customers_but.UseVisualStyleBackColor = false;
            this.Customers_but.Click += new System.EventHandler(this.Customers_Click);
            // 
            // Choice
            // 
            this.Choice.AutoSize = true;
            this.Choice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Choice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Choice.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choice.Location = new System.Drawing.Point(228, 120);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(322, 40);
            this.Choice.TabIndex = 3;
            this.Choice.Text = "Выберите таблицу";
            // 
            // Journal_but
            // 
            this.Journal_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Journal_but.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Journal_but.Location = new System.Drawing.Point(103, 295);
            this.Journal_but.Name = "Journal_but";
            this.Journal_but.Size = new System.Drawing.Size(598, 62);
            this.Journal_but.TabIndex = 4;
            this.Journal_but.Text = "Журнал";
            this.Journal_but.UseVisualStyleBackColor = false;
            this.Journal_but.Click += new System.EventHandler(this.Journal_but_Click);
            // 
            // MainSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Journal_but);
            this.Controls.Add(this.Choice);
            this.Controls.Add(this.Customers_but);
            this.Controls.Add(this.Workers_but);
            this.Controls.Add(this.Products_but);
            this.Name = "MainSite";
            this.Text = "MainSite";
            this.Load += new System.EventHandler(this.MainSite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Products_but;
        private System.Windows.Forms.Button Workers_but;
        private System.Windows.Forms.Button Customers_but;
        private System.Windows.Forms.Label Choice;
        private System.Windows.Forms.Button Journal_but;
    }
}