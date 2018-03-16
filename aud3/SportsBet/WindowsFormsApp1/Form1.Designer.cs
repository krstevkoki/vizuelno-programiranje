namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.lstGames = new System.Windows.Forms.ListBox();
            this.lstTicket = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnAddToGames = new System.Windows.Forms.Button();
            this.btnAddToTicket = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msbCode = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nup2 = new System.Windows.Forms.NumericUpDown();
            this.nupX = new System.Windows.Forms.NumericUpDown();
            this.nup1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbCode1 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCoefficient = new System.Windows.Forms.TextBox();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.nudPayment = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.ItemHeight = 16;
            this.lstTeams.Location = new System.Drawing.Point(12, 33);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTeams.Size = new System.Drawing.Size(431, 516);
            this.lstTeams.TabIndex = 0;
            // 
            // lstGames
            // 
            this.lstGames.FormattingEnabled = true;
            this.lstGames.ItemHeight = 16;
            this.lstGames.Location = new System.Drawing.Point(488, 33);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(431, 516);
            this.lstGames.TabIndex = 1;
            // 
            // lstTicket
            // 
            this.lstTicket.FormattingEnabled = true;
            this.lstTicket.ItemHeight = 16;
            this.lstTicket.Location = new System.Drawing.Point(958, 33);
            this.lstTicket.Name = "lstTicket";
            this.lstTicket.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstTicket.Size = new System.Drawing.Size(431, 516);
            this.lstTicket.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тимови";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Билтен";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(955, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тикет";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(0, 177);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(431, 26);
            this.btnAddTeam.TabIndex = 6;
            this.btnAddTeam.Text = "Додади нов тим";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnAddToGames
            // 
            this.btnAddToGames.Location = new System.Drawing.Point(0, 209);
            this.btnAddToGames.Name = "btnAddToGames";
            this.btnAddToGames.Size = new System.Drawing.Size(431, 28);
            this.btnAddToGames.TabIndex = 7;
            this.btnAddToGames.Text = "Додади во билтен";
            this.btnAddToGames.UseVisualStyleBackColor = true;
            this.btnAddToGames.Click += new System.EventHandler(this.btnAddToGames_Click);
            // 
            // btnAddToTicket
            // 
            this.btnAddToTicket.Location = new System.Drawing.Point(0, 200);
            this.btnAddToTicket.Name = "btnAddToTicket";
            this.btnAddToTicket.Size = new System.Drawing.Size(431, 31);
            this.btnAddToTicket.TabIndex = 8;
            this.btnAddToTicket.Text = "Додади во тикет";
            this.btnAddToTicket.UseVisualStyleBackColor = true;
            this.btnAddToTicket.Click += new System.EventHandler(this.btnAddToTicket_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msbCode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nup2);
            this.groupBox1.Controls.Add(this.nupX);
            this.groupBox1.Controls.Add(this.nup1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAddToGames);
            this.groupBox1.Controls.Add(this.btnAddTeam);
            this.groupBox1.Location = new System.Drawing.Point(12, 585);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 237);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Креирај билтен";
            // 
            // msbCode
            // 
            this.msbCode.Location = new System.Drawing.Point(82, 140);
            this.msbCode.Mask = "0000";
            this.msbCode.Name = "msbCode";
            this.msbCode.Size = new System.Drawing.Size(80, 22);
            this.msbCode.TabIndex = 16;
            this.msbCode.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Шифра";
            // 
            // nup2
            // 
            this.nup2.DecimalPlaces = 2;
            this.nup2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nup2.Location = new System.Drawing.Point(366, 82);
            this.nup2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup2.Name = "nup2";
            this.nup2.Size = new System.Drawing.Size(61, 22);
            this.nup2.TabIndex = 14;
            this.nup2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupX
            // 
            this.nupX.DecimalPlaces = 2;
            this.nupX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupX.Location = new System.Drawing.Point(179, 82);
            this.nupX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupX.Name = "nupX";
            this.nupX.Size = new System.Drawing.Size(60, 22);
            this.nupX.TabIndex = 13;
            this.nupX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nup1
            // 
            this.nup1.DecimalPlaces = 2;
            this.nup1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nup1.Location = new System.Drawing.Point(16, 82);
            this.nup1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup1.Name = "nup1";
            this.nup1.Size = new System.Drawing.Size(58, 22);
            this.nup1.TabIndex = 12;
            this.nup1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Х";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Постави коефициенти";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTip);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.mtbCode1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnAddToTicket);
            this.groupBox2.Location = new System.Drawing.Point(488, 585);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 237);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додади натпревар во тикетот";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(337, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Избери натпревар од билтенот или внеси шифра";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudPayment);
            this.groupBox3.Controls.Add(this.txtProfit);
            this.groupBox3.Controls.Add(this.txtCoefficient);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Location = new System.Drawing.Point(958, 585);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 237);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Уплати тикет";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(0, 209);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(431, 28);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Печати тикет";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Шифра";
            // 
            // mtbCode1
            // 
            this.mtbCode1.Location = new System.Drawing.Point(9, 126);
            this.mtbCode1.Mask = "0000";
            this.mtbCode1.Name = "mtbCode1";
            this.mtbCode1.Size = new System.Drawing.Size(121, 22);
            this.mtbCode1.TabIndex = 17;
            this.mtbCode1.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Избери тип";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "1",
            "X",
            "2"});
            this.cbTip.Location = new System.Drawing.Point(277, 126);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(121, 24);
            this.cbTip.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Вкупно коефициент";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Уплата";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Добивка";
            // 
            // txtCoefficient
            // 
            this.txtCoefficient.Location = new System.Drawing.Point(9, 48);
            this.txtCoefficient.Name = "txtCoefficient";
            this.txtCoefficient.ReadOnly = true;
            this.txtCoefficient.Size = new System.Drawing.Size(424, 22);
            this.txtCoefficient.TabIndex = 13;
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(9, 160);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.ReadOnly = true;
            this.txtProfit.Size = new System.Drawing.Size(424, 22);
            this.txtProfit.TabIndex = 15;
            // 
            // nudPayment
            // 
            this.nudPayment.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPayment.Location = new System.Drawing.Point(9, 102);
            this.nudPayment.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudPayment.Name = "nudPayment";
            this.nudPayment.Size = new System.Drawing.Size(422, 22);
            this.nudPayment.TabIndex = 16;
            this.nudPayment.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudPayment.ValueChanged += new System.EventHandler(this.nudPayment_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 832);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTicket);
            this.Controls.Add(this.lstGames);
            this.Controls.Add(this.lstTeams);
            this.Name = "Form1";
            this.Text = "SportsBet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.ListBox lstTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnAddToGames;
        private System.Windows.Forms.Button btnAddToTicket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nup2;
        private System.Windows.Forms.NumericUpDown nupX;
        private System.Windows.Forms.NumericUpDown nup1;
        private System.Windows.Forms.MaskedTextBox msbCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtbCode1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudPayment;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtCoefficient;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

