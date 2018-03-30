namespace ExamProblems
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpis1 = new System.Windows.Forms.TextBox();
            this.nudPoeni1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPoeni2 = new System.Windows.Forms.NumericUpDown();
            this.txtOpis2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstIspiti = new System.Windows.Forms.ListBox();
            this.btnDodadiIspit = new System.Windows.Forms.Button();
            this.btnIzbrisiIspit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeni1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeni2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrisiIspit);
            this.groupBox1.Controls.Add(this.btnDodadiIspit);
            this.groupBox1.Controls.Add(this.lstIspiti);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 514);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Испити";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudPoeni1);
            this.groupBox2.Controls.Add(this.txtOpis1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(379, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задача 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Опис:";
            // 
            // txtOpis1
            // 
            this.txtOpis1.AcceptsReturn = true;
            this.txtOpis1.Location = new System.Drawing.Point(10, 43);
            this.txtOpis1.Multiline = true;
            this.txtOpis1.Name = "txtOpis1";
            this.txtOpis1.Size = new System.Drawing.Size(393, 104);
            this.txtOpis1.TabIndex = 1;
            // 
            // nudPoeni1
            // 
            this.nudPoeni1.Location = new System.Drawing.Point(10, 170);
            this.nudPoeni1.Name = "nudPoeni1";
            this.nudPoeni1.Size = new System.Drawing.Size(148, 22);
            this.nudPoeni1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поени:";
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(304, 213);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(98, 25);
            this.btnSave1.TabIndex = 4;
            this.btnSave1.Text = "Зачувај";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nudPoeni2);
            this.groupBox3.Controls.Add(this.txtOpis2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(379, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 244);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Задача 2";
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(304, 213);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(98, 25);
            this.btnSave2.TabIndex = 4;
            this.btnSave2.Text = "Зачувај";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Поени:";
            // 
            // nudPoeni2
            // 
            this.nudPoeni2.Location = new System.Drawing.Point(10, 170);
            this.nudPoeni2.Name = "nudPoeni2";
            this.nudPoeni2.Size = new System.Drawing.Size(148, 22);
            this.nudPoeni2.TabIndex = 2;
            // 
            // txtOpis2
            // 
            this.txtOpis2.AcceptsReturn = true;
            this.txtOpis2.Location = new System.Drawing.Point(10, 43);
            this.txtOpis2.Multiline = true;
            this.txtOpis2.Name = "txtOpis2";
            this.txtOpis2.Size = new System.Drawing.Size(393, 104);
            this.txtOpis2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Опис:";
            // 
            // lstIspiti
            // 
            this.lstIspiti.FormattingEnabled = true;
            this.lstIspiti.ItemHeight = 16;
            this.lstIspiti.Location = new System.Drawing.Point(7, 22);
            this.lstIspiti.Name = "lstIspiti";
            this.lstIspiti.Size = new System.Drawing.Size(346, 388);
            this.lstIspiti.TabIndex = 0;
            this.lstIspiti.SelectedIndexChanged += new System.EventHandler(this.lstIspiti_SelectedIndexChanged);
            // 
            // btnDodadiIspit
            // 
            this.btnDodadiIspit.Location = new System.Drawing.Point(7, 420);
            this.btnDodadiIspit.Name = "btnDodadiIspit";
            this.btnDodadiIspit.Size = new System.Drawing.Size(346, 30);
            this.btnDodadiIspit.TabIndex = 5;
            this.btnDodadiIspit.Text = "Додади испит";
            this.btnDodadiIspit.UseVisualStyleBackColor = true;
            this.btnDodadiIspit.Click += new System.EventHandler(this.btnDodadiIspit_Click);
            // 
            // btnIzbrisiIspit
            // 
            this.btnIzbrisiIspit.Enabled = false;
            this.btnIzbrisiIspit.Location = new System.Drawing.Point(7, 464);
            this.btnIzbrisiIspit.Name = "btnIzbrisiIspit";
            this.btnIzbrisiIspit.Size = new System.Drawing.Size(346, 30);
            this.btnIzbrisiIspit.TabIndex = 6;
            this.btnIzbrisiIspit.Text = "Избриши испит";
            this.btnIzbrisiIspit.UseVisualStyleBackColor = true;
            this.btnIzbrisiIspit.Click += new System.EventHandler(this.btnIzbrisiIspit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDodadiIspit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Испити";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeni1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeni2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzbrisiIspit;
        private System.Windows.Forms.Button btnDodadiIspit;
        private System.Windows.Forms.ListBox lstIspiti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPoeni1;
        private System.Windows.Forms.TextBox txtOpis1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPoeni2;
        private System.Windows.Forms.TextBox txtOpis2;
        private System.Windows.Forms.Label label4;
    }
}

