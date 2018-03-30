namespace Busses
{
    partial class DodadiLinija
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.nupCena = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nupMinuta = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nupCas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestinacija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.validatorDestinacija = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorDestinacija)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.nupCena);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nupMinuta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nupCas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDestinacija);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади линија";
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(171, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Додади";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nupCena
            // 
            this.nupCena.Location = new System.Drawing.Point(10, 145);
            this.nupCena.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nupCena.Name = "nupCena";
            this.nupCena.Size = new System.Drawing.Size(149, 22);
            this.nupCena.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена";
            // 
            // nupMinuta
            // 
            this.nupMinuta.Location = new System.Drawing.Point(105, 99);
            this.nupMinuta.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupMinuta.Name = "nupMinuta";
            this.nupMinuta.Size = new System.Drawing.Size(89, 22);
            this.nupMinuta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Минута";
            // 
            // nupCas
            // 
            this.nupCas.Location = new System.Drawing.Point(10, 100);
            this.nupCas.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupCas.Name = "nupCas";
            this.nupCas.Size = new System.Drawing.Size(89, 22);
            this.nupCas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Час";
            // 
            // txtDestinacija
            // 
            this.txtDestinacija.Location = new System.Drawing.Point(10, 54);
            this.txtDestinacija.Name = "txtDestinacija";
            this.txtDestinacija.Size = new System.Drawing.Size(295, 22);
            this.txtDestinacija.TabIndex = 1;
            this.txtDestinacija.Validating += new System.ComponentModel.CancelEventHandler(this.txtDestinacija_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дестинација";
            // 
            // validatorDestinacija
            // 
            this.validatorDestinacija.ContainerControl = this;
            // 
            // DodadiLinija
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(358, 244);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodadiLinija";
            this.Text = "Нова линија";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorDestinacija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nupCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupMinuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupCas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestinacija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider validatorDestinacija;
    }
}