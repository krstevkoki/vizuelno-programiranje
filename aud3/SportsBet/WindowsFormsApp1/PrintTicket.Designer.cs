namespace WindowsFormsApp1
{
    partial class PrintTicket
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Шифра = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Натпревар = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Коефициент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCoefficient = new System.Windows.Forms.TextBox();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtDanok = new System.Windows.Forms.TextBox();
            this.txtIsplata = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Шифра,
            this.Натпревар,
            this.Коефициент});
            this.dataGridView1.Location = new System.Drawing.Point(0, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(615, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // Шифра
            // 
            this.Шифра.HeaderText = "Шифра";
            this.Шифра.Name = "Шифра";
            this.Шифра.ReadOnly = true;
            this.Шифра.Width = 70;
            // 
            // Натпревар
            // 
            this.Натпревар.HeaderText = "Натпревар";
            this.Натпревар.Name = "Натпревар";
            this.Натпревар.ReadOnly = true;
            this.Натпревар.Width = 250;
            // 
            // Коефициент
            // 
            this.Коефициент.HeaderText = "Коефициент";
            this.Коефициент.Name = "Коефициент";
            this.Коефициент.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вкупно коефициент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Уплата";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(28, 539);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(192, 22);
            this.txtPayment.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Добивка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Данок";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 613);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Исплата";
            // 
            // txtCoefficient
            // 
            this.txtCoefficient.Location = new System.Drawing.Point(28, 608);
            this.txtCoefficient.Name = "txtCoefficient";
            this.txtCoefficient.ReadOnly = true;
            this.txtCoefficient.Size = new System.Drawing.Size(192, 22);
            this.txtCoefficient.TabIndex = 7;
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(327, 527);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.ReadOnly = true;
            this.txtProfit.Size = new System.Drawing.Size(188, 22);
            this.txtProfit.TabIndex = 8;
            // 
            // txtDanok
            // 
            this.txtDanok.Location = new System.Drawing.Point(327, 578);
            this.txtDanok.Name = "txtDanok";
            this.txtDanok.ReadOnly = true;
            this.txtDanok.Size = new System.Drawing.Size(188, 22);
            this.txtDanok.TabIndex = 9;
            // 
            // txtIsplata
            // 
            this.txtIsplata.Location = new System.Drawing.Point(327, 633);
            this.txtIsplata.Name = "txtIsplata";
            this.txtIsplata.ReadOnly = true;
            this.txtIsplata.Size = new System.Drawing.Size(188, 22);
            this.txtIsplata.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(220, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "ФИНКИ БЕТ";
            // 
            // PrintTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 700);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIsplata);
            this.Controls.Add(this.txtDanok);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.txtCoefficient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintTicket";
            this.Text = "PrintTicket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCoefficient;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtDanok;
        private System.Windows.Forms.TextBox txtIsplata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Шифра;
        private System.Windows.Forms.DataGridViewTextBoxColumn Натпревар;
        private System.Windows.Forms.DataGridViewTextBoxColumn Коефициент;
    }
}