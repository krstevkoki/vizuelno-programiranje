namespace Hangman
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
            this.lblZbor = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtBukva = new System.Windows.Forms.TextBox();
            this.btnPogodi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProbaniBukvi = new System.Windows.Forms.TextBox();
            this.pbObidi = new System.Windows.Forms.ProgressBar();
            this.pbVreme = new System.Windows.Forms.ProgressBar();
            this.timerVreme = new System.Windows.Forms.Timer(this.components);
            this.lblObidi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.започниНоваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сеПредавамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исклучиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblZbor
            // 
            this.lblZbor.AutoSize = true;
            this.lblZbor.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZbor.Location = new System.Drawing.Point(15, 58);
            this.lblZbor.Name = "lblZbor";
            this.lblZbor.Size = new System.Drawing.Size(0, 76);
            this.lblZbor.TabIndex = 0;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(916, 44);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 29);
            this.lblTimer.TabIndex = 1;
            // 
            // txtBukva
            // 
            this.txtBukva.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBukva.Location = new System.Drawing.Point(18, 161);
            this.txtBukva.MaxLength = 1;
            this.txtBukva.Name = "txtBukva";
            this.txtBukva.Size = new System.Drawing.Size(100, 83);
            this.txtBukva.TabIndex = 2;
            // 
            // btnPogodi
            // 
            this.btnPogodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPogodi.Location = new System.Drawing.Point(124, 161);
            this.btnPogodi.Name = "btnPogodi";
            this.btnPogodi.Size = new System.Drawing.Size(85, 83);
            this.btnPogodi.TabIndex = 3;
            this.btnPogodi.Text = "OK";
            this.btnPogodi.UseVisualStyleBackColor = true;
            this.btnPogodi.Click += new System.EventHandler(this.btnPogodi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProbaniBukvi);
            this.groupBox1.Location = new System.Drawing.Point(12, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Погодени букви";
            // 
            // txtProbaniBukvi
            // 
            this.txtProbaniBukvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProbaniBukvi.Location = new System.Drawing.Point(6, 21);
            this.txtProbaniBukvi.Name = "txtProbaniBukvi";
            this.txtProbaniBukvi.ReadOnly = true;
            this.txtProbaniBukvi.Size = new System.Drawing.Size(960, 53);
            this.txtProbaniBukvi.TabIndex = 0;
            this.txtProbaniBukvi.TabStop = false;
            // 
            // pbObidi
            // 
            this.pbObidi.Location = new System.Drawing.Point(18, 398);
            this.pbObidi.Name = "pbObidi";
            this.pbObidi.Size = new System.Drawing.Size(960, 32);
            this.pbObidi.TabIndex = 5;
            // 
            // pbVreme
            // 
            this.pbVreme.Location = new System.Drawing.Point(18, 453);
            this.pbVreme.Name = "pbVreme";
            this.pbVreme.Size = new System.Drawing.Size(960, 32);
            this.pbVreme.TabIndex = 6;
            // 
            // timerVreme
            // 
            this.timerVreme.Interval = 1000;
            this.timerVreme.Tick += new System.EventHandler(this.timerVreme_Tick);
            // 
            // lblObidi
            // 
            this.lblObidi.AutoSize = true;
            this.lblObidi.Location = new System.Drawing.Point(15, 378);
            this.lblObidi.Name = "lblObidi";
            this.lblObidi.Size = new System.Drawing.Size(0, 17);
            this.lblObidi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Преостанато време:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.започниНоваToolStripMenuItem,
            this.сеПредавамToolStripMenuItem,
            this.исклучиToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // започниНоваToolStripMenuItem
            // 
            this.започниНоваToolStripMenuItem.Name = "започниНоваToolStripMenuItem";
            this.започниНоваToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.започниНоваToolStripMenuItem.Text = "Започни нова :)";
            this.започниНоваToolStripMenuItem.Click += new System.EventHandler(this.започниНоваToolStripMenuItem_Click);
            // 
            // сеПредавамToolStripMenuItem
            // 
            this.сеПредавамToolStripMenuItem.Name = "сеПредавамToolStripMenuItem";
            this.сеПредавамToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.сеПредавамToolStripMenuItem.Text = "Се предавам :(";
            this.сеПредавамToolStripMenuItem.Click += new System.EventHandler(this.сеПредавамToolStripMenuItem_Click);
            // 
            // исклучиToolStripMenuItem
            // 
            this.исклучиToolStripMenuItem.Name = "исклучиToolStripMenuItem";
            this.исклучиToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.исклучиToolStripMenuItem.Text = "Исклучи";
            this.исклучиToolStripMenuItem.Click += new System.EventHandler(this.исклучиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPogodi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblObidi);
            this.Controls.Add(this.pbVreme);
            this.Controls.Add(this.pbObidi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPogodi);
            this.Controls.Add(this.txtBukva);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblZbor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Бесилка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZbor;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtBukva;
        private System.Windows.Forms.Button btnPogodi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProbaniBukvi;
        private System.Windows.Forms.ProgressBar pbObidi;
        private System.Windows.Forms.ProgressBar pbVreme;
        private System.Windows.Forms.Timer timerVreme;
        private System.Windows.Forms.Label lblObidi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem започниНоваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сеПредавамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исклучиToolStripMenuItem;
    }
}

