namespace MathTimer
{
    partial class DisplayBestPlayers
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
            this.dgvIgraci = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Поени = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIgraci
            // 
            this.dgvIgraci.AllowUserToDeleteRows = false;
            this.dgvIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgraci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Поени});
            this.dgvIgraci.Location = new System.Drawing.Point(12, 12);
            this.dgvIgraci.Name = "dgvIgraci";
            this.dgvIgraci.ReadOnly = true;
            this.dgvIgraci.RowTemplate.Height = 24;
            this.dgvIgraci.Size = new System.Drawing.Size(760, 150);
            this.dgvIgraci.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Позиција";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Играч";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Поени
            // 
            this.Поени.HeaderText = "Поени";
            this.Поени.Name = "Поени";
            this.Поени.ReadOnly = true;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(635, 368);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(137, 33);
            this.btnNazad.TabIndex = 1;
            this.btnNazad.Text = "Врати се назад";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // DisplayBestPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 413);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.dgvIgraci);
            this.Name = "DisplayBestPlayers";
            this.Text = "Best Players";
            this.Load += new System.EventHandler(this.DisplayBestPlayers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIgraci;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Поени;
    }
}