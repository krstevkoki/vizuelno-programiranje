namespace WindowsFormsApp1
{
    partial class Form3
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblVozrast = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblKod = new System.Windows.Forms.Label();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.txbAdresa = new System.Windows.Forms.TextBox();
            this.txbGrad = new System.Windows.Forms.TextBox();
            this.txbVozrast = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbKod = new System.Windows.Forms.TextBox();
            this.mtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.errorProviderVozrast = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbUslovi = new System.Windows.Forms.CheckBox();
            this.btnVnesi = new System.Windows.Forms.Button();
            this.linkUslovi = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVozrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIme.Location = new System.Drawing.Point(45, 19);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(173, 26);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Име и презиме:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdresa.Location = new System.Drawing.Point(125, 58);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(93, 26);
            this.lblAdresa.TabIndex = 1;
            this.lblAdresa.Text = "Адреса:";
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGrad.Location = new System.Drawing.Point(151, 122);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(67, 26);
            this.lblGrad.TabIndex = 2;
            this.lblGrad.Text = "Град:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTelefon.Location = new System.Drawing.Point(12, 169);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(206, 26);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Мобилен телефон:";
            // 
            // lblVozrast
            // 
            this.lblVozrast.AutoSize = true;
            this.lblVozrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVozrast.Location = new System.Drawing.Point(117, 213);
            this.lblVozrast.Name = "lblVozrast";
            this.lblVozrast.Size = new System.Drawing.Size(101, 26);
            this.lblVozrast.TabIndex = 4;
            this.lblVozrast.Text = "Возраст:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMail.Location = new System.Drawing.Point(128, 261);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(90, 26);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "е-маил:";
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKod.Location = new System.Drawing.Point(160, 306);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(58, 26);
            this.lblKod.TabIndex = 6;
            this.lblKod.Text = "Код:";
            // 
            // txbIme
            // 
            this.txbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbIme.Location = new System.Drawing.Point(240, 21);
            this.txbIme.MaxLength = 20;
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(193, 26);
            this.txbIme.TabIndex = 7;
            // 
            // txbAdresa
            // 
            this.txbAdresa.AcceptsReturn = true;
            this.txbAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbAdresa.Location = new System.Drawing.Point(240, 60);
            this.txbAdresa.MaxLength = 120;
            this.txbAdresa.Multiline = true;
            this.txbAdresa.Name = "txbAdresa";
            this.txbAdresa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbAdresa.Size = new System.Drawing.Size(193, 44);
            this.txbAdresa.TabIndex = 8;
            // 
            // txbGrad
            // 
            this.txbGrad.AutoCompleteCustomSource.AddRange(new string[] {
            "Скопје",
            "Битола",
            "Неготино",
            "Кавадарци"});
            this.txbGrad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbGrad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbGrad.Location = new System.Drawing.Point(240, 124);
            this.txbGrad.Name = "txbGrad";
            this.txbGrad.Size = new System.Drawing.Size(193, 26);
            this.txbGrad.TabIndex = 9;
            // 
            // txbVozrast
            // 
            this.txbVozrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbVozrast.Location = new System.Drawing.Point(240, 215);
            this.txbVozrast.Name = "txbVozrast";
            this.txbVozrast.Size = new System.Drawing.Size(193, 26);
            this.txbVozrast.TabIndex = 11;
            this.txbVozrast.Validating += new System.ComponentModel.CancelEventHandler(this.txbVozrast_Validating);
            // 
            // txbMail
            // 
            this.txbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbMail.Location = new System.Drawing.Point(240, 263);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(193, 26);
            this.txbMail.TabIndex = 12;
            this.txbMail.Validating += new System.ComponentModel.CancelEventHandler(this.txbMail_Validating);
            // 
            // txbKod
            // 
            this.txbKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbKod.Location = new System.Drawing.Point(240, 308);
            this.txbKod.Name = "txbKod";
            this.txbKod.Size = new System.Drawing.Size(193, 26);
            this.txbKod.TabIndex = 13;
            this.txbKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbKod_KeyPress);
            // 
            // mtbTelefon
            // 
            this.mtbTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbTelefon.Location = new System.Drawing.Point(240, 171);
            this.mtbTelefon.Mask = "(999) 000-000";
            this.mtbTelefon.Name = "mtbTelefon";
            this.mtbTelefon.Size = new System.Drawing.Size(193, 26);
            this.mtbTelefon.TabIndex = 14;
            this.mtbTelefon.Text = "07";
            // 
            // errorProviderVozrast
            // 
            this.errorProviderVozrast.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // cbUslovi
            // 
            this.cbUslovi.AutoSize = true;
            this.cbUslovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUslovi.Location = new System.Drawing.Point(240, 360);
            this.cbUslovi.Name = "cbUslovi";
            this.cbUslovi.Size = new System.Drawing.Size(123, 22);
            this.cbUslovi.TabIndex = 15;
            this.cbUslovi.Text = "Ги прифаќам";
            this.cbUslovi.UseVisualStyleBackColor = true;
            this.cbUslovi.CheckedChanged += new System.EventHandler(this.cbUslovi_CheckedChanged);
            // 
            // btnVnesi
            // 
            this.btnVnesi.Enabled = false;
            this.btnVnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVnesi.Location = new System.Drawing.Point(133, 411);
            this.btnVnesi.Name = "btnVnesi";
            this.btnVnesi.Size = new System.Drawing.Size(214, 40);
            this.btnVnesi.TabIndex = 16;
            this.btnVnesi.Text = "Внеси";
            this.btnVnesi.UseVisualStyleBackColor = true;
            this.btnVnesi.Click += new System.EventHandler(this.btnVnesi_Click);
            // 
            // linkUslovi
            // 
            this.linkUslovi.AutoSize = true;
            this.linkUslovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkUslovi.Location = new System.Drawing.Point(369, 360);
            this.linkUslovi.Name = "linkUslovi";
            this.linkUslovi.Size = new System.Drawing.Size(72, 18);
            this.linkUslovi.TabIndex = 17;
            this.linkUslovi.TabStop = true;
            this.linkUslovi.Text = "условите";
            this.linkUslovi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUslovi_LinkClicked);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 463);
            this.Controls.Add(this.linkUslovi);
            this.Controls.Add(this.btnVnesi);
            this.Controls.Add(this.cbUslovi);
            this.Controls.Add(this.mtbTelefon);
            this.Controls.Add(this.txbKod);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.txbVozrast);
            this.Controls.Add(this.txbGrad);
            this.Controls.Add(this.txbAdresa);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblVozrast);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblIme);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVozrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblVozrast;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.TextBox txbAdresa;
        private System.Windows.Forms.TextBox txbGrad;
        private System.Windows.Forms.TextBox txbVozrast;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbKod;
        private System.Windows.Forms.MaskedTextBox mtbTelefon;
        private System.Windows.Forms.ErrorProvider errorProviderVozrast;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.Button btnVnesi;
        private System.Windows.Forms.CheckBox cbUslovi;
        private System.Windows.Forms.LinkLabel linkUslovi;
    }
}