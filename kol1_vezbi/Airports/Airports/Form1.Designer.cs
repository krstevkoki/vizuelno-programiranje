namespace Airports
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstAerodromi = new System.Windows.Forms.ListBox();
            this.lstDestinacii = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodadiAerodrom = new System.Windows.Forms.Button();
            this.btnIzbrisiAerodrom = new System.Windows.Forms.Button();
            this.btnDodadiDest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNajskapaDest = new System.Windows.Forms.TextBox();
            this.txtProsecnaDolzina = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аеродроми";
            // 
            // lstAerodromi
            // 
            this.lstAerodromi.FormattingEnabled = true;
            this.lstAerodromi.ItemHeight = 16;
            this.lstAerodromi.Location = new System.Drawing.Point(13, 34);
            this.lstAerodromi.Name = "lstAerodromi";
            this.lstAerodromi.Size = new System.Drawing.Size(320, 308);
            this.lstAerodromi.TabIndex = 1;
            this.lstAerodromi.SelectedIndexChanged += new System.EventHandler(this.lstAerodromi_SelectedIndexChanged);
            // 
            // lstDestinacii
            // 
            this.lstDestinacii.FormattingEnabled = true;
            this.lstDestinacii.ItemHeight = 16;
            this.lstDestinacii.Location = new System.Drawing.Point(341, 34);
            this.lstDestinacii.Name = "lstDestinacii";
            this.lstDestinacii.Size = new System.Drawing.Size(361, 308);
            this.lstDestinacii.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дестинации";
            // 
            // btnDodadiAerodrom
            // 
            this.btnDodadiAerodrom.Location = new System.Drawing.Point(12, 361);
            this.btnDodadiAerodrom.Name = "btnDodadiAerodrom";
            this.btnDodadiAerodrom.Size = new System.Drawing.Size(320, 23);
            this.btnDodadiAerodrom.TabIndex = 4;
            this.btnDodadiAerodrom.Text = "Додади аеродром";
            this.btnDodadiAerodrom.UseVisualStyleBackColor = true;
            this.btnDodadiAerodrom.Click += new System.EventHandler(this.btnDodadiAerodrom_Click);
            // 
            // btnIzbrisiAerodrom
            // 
            this.btnIzbrisiAerodrom.Location = new System.Drawing.Point(12, 417);
            this.btnIzbrisiAerodrom.Name = "btnIzbrisiAerodrom";
            this.btnIzbrisiAerodrom.Size = new System.Drawing.Size(320, 23);
            this.btnIzbrisiAerodrom.TabIndex = 5;
            this.btnIzbrisiAerodrom.Text = "Избриши аеродром";
            this.btnIzbrisiAerodrom.UseVisualStyleBackColor = true;
            this.btnIzbrisiAerodrom.Click += new System.EventHandler(this.btnIzbrisiAerodrom_Click);
            // 
            // btnDodadiDest
            // 
            this.btnDodadiDest.Location = new System.Drawing.Point(12, 469);
            this.btnDodadiDest.Name = "btnDodadiDest";
            this.btnDodadiDest.Size = new System.Drawing.Size(320, 23);
            this.btnDodadiDest.TabIndex = 6;
            this.btnDodadiDest.Text = "Додади дестинација";
            this.btnDodadiDest.UseVisualStyleBackColor = true;
            this.btnDodadiDest.Click += new System.EventHandler(this.btnDodadiDest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProsecnaDolzina);
            this.groupBox1.Controls.Add(this.txtNajskapaDest);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(339, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дестинации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Најскапа дестинација";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Просечна должина на дестинациите";
            // 
            // txtNajskapaDest
            // 
            this.txtNajskapaDest.Location = new System.Drawing.Point(9, 40);
            this.txtNajskapaDest.Name = "txtNajskapaDest";
            this.txtNajskapaDest.ReadOnly = true;
            this.txtNajskapaDest.Size = new System.Drawing.Size(348, 22);
            this.txtNajskapaDest.TabIndex = 10;
            // 
            // txtProsecnaDolzina
            // 
            this.txtProsecnaDolzina.Location = new System.Drawing.Point(9, 95);
            this.txtProsecnaDolzina.Name = "txtProsecnaDolzina";
            this.txtProsecnaDolzina.ReadOnly = true;
            this.txtProsecnaDolzina.Size = new System.Drawing.Size(348, 22);
            this.txtProsecnaDolzina.TabIndex = 11;
            this.txtProsecnaDolzina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodadiDest);
            this.Controls.Add(this.btnIzbrisiAerodrom);
            this.Controls.Add(this.btnDodadiAerodrom);
            this.Controls.Add(this.lstDestinacii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstAerodromi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Аеродроми";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAerodromi;
        private System.Windows.Forms.ListBox lstDestinacii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodadiAerodrom;
        private System.Windows.Forms.Button btnIzbrisiAerodrom;
        private System.Windows.Forms.Button btnDodadiDest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProsecnaDolzina;
        private System.Windows.Forms.TextBox txtNajskapaDest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

