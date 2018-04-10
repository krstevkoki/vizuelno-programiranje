namespace MathTimer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIgrac = new System.Windows.Forms.TextBox();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnPogodi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.pbPoeni = new System.Windows.Forms.ProgressBar();
            this.pbVreme = new System.Windows.Forms.ProgressBar();
            this.lblVreme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNovaIgra = new System.Windows.Forms.Button();
            this.btnNajdobri = new System.Windows.Forms.Button();
            this.btnIskluci = new System.Windows.Forms.Button();
            this.timerVreme = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Играч:";
            // 
            // txtIgrac
            // 
            this.txtIgrac.Location = new System.Drawing.Point(82, 37);
            this.txtIgrac.Name = "txtIgrac";
            this.txtIgrac.Size = new System.Drawing.Size(156, 22);
            this.txtIgrac.TabIndex = 1;
            this.txtIgrac.Leave += new System.EventHandler(this.txtIgrac_Leave);
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(27, 80);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.ReadOnly = true;
            this.txtOperand1.Size = new System.Drawing.Size(105, 22);
            this.txtOperand1.TabIndex = 2;
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(162, 80);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.ReadOnly = true;
            this.txtOperator.Size = new System.Drawing.Size(60, 22);
            this.txtOperator.TabIndex = 3;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(251, 80);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.ReadOnly = true;
            this.txtOperand2.Size = new System.Drawing.Size(105, 22);
            this.txtOperand2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(454, 80);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(105, 22);
            this.txtResult.TabIndex = 6;
            // 
            // btnPogodi
            // 
            this.btnPogodi.Location = new System.Drawing.Point(601, 76);
            this.btnPogodi.Name = "btnPogodi";
            this.btnPogodi.Size = new System.Drawing.Size(94, 30);
            this.btnPogodi.TabIndex = 7;
            this.btnPogodi.Text = "Погоди";
            this.btnPogodi.UseVisualStyleBackColor = true;
            this.btnPogodi.Click += new System.EventHandler(this.btnPogodi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поени:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Location = new System.Drawing.Point(101, 143);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(0, 17);
            this.lblPoeni.TabIndex = 9;
            // 
            // pbPoeni
            // 
            this.pbPoeni.Location = new System.Drawing.Point(27, 163);
            this.pbPoeni.Name = "pbPoeni";
            this.pbPoeni.Size = new System.Drawing.Size(668, 33);
            this.pbPoeni.TabIndex = 10;
            // 
            // pbVreme
            // 
            this.pbVreme.Location = new System.Drawing.Point(27, 235);
            this.pbVreme.Name = "pbVreme";
            this.pbVreme.Size = new System.Drawing.Size(668, 32);
            this.pbVreme.TabIndex = 13;
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Location = new System.Drawing.Point(200, 215);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(0, 17);
            this.lblVreme.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Преостанато време:";
            // 
            // btnNovaIgra
            // 
            this.btnNovaIgra.Location = new System.Drawing.Point(27, 289);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(94, 30);
            this.btnNovaIgra.TabIndex = 14;
            this.btnNovaIgra.Text = "Нова игра";
            this.btnNovaIgra.UseVisualStyleBackColor = true;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
            // 
            // btnNajdobri
            // 
            this.btnNajdobri.Location = new System.Drawing.Point(297, 289);
            this.btnNajdobri.Name = "btnNajdobri";
            this.btnNajdobri.Size = new System.Drawing.Size(131, 30);
            this.btnNajdobri.TabIndex = 15;
            this.btnNajdobri.Text = "Најдобри играчи";
            this.btnNajdobri.UseVisualStyleBackColor = true;
            this.btnNajdobri.Click += new System.EventHandler(this.btnNajdobri_Click);
            // 
            // btnIskluci
            // 
            this.btnIskluci.Location = new System.Drawing.Point(601, 289);
            this.btnIskluci.Name = "btnIskluci";
            this.btnIskluci.Size = new System.Drawing.Size(94, 30);
            this.btnIskluci.TabIndex = 16;
            this.btnIskluci.Text = "Исклучи";
            this.btnIskluci.UseVisualStyleBackColor = true;
            this.btnIskluci.Click += new System.EventHandler(this.btnIskluci_Click);
            // 
            // timerVreme
            // 
            this.timerVreme.Tick += new System.EventHandler(this.timerVreme_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPogodi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 329);
            this.Controls.Add(this.btnIskluci);
            this.Controls.Add(this.btnNajdobri);
            this.Controls.Add(this.btnNovaIgra);
            this.Controls.Add(this.pbVreme);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbPoeni);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPogodi);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.txtIgrac);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Math Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIgrac;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnPogodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.ProgressBar pbPoeni;
        private System.Windows.Forms.ProgressBar pbVreme;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNovaIgra;
        private System.Windows.Forms.Button btnNajdobri;
        private System.Windows.Forms.Button btnIskluci;
        private System.Windows.Forms.Timer timerVreme;
    }
}

