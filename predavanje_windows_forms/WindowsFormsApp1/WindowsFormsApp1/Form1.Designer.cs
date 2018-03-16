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
            this.lblExample = new System.Windows.Forms.Label();
            this.btnExample = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExample.Location = new System.Drawing.Point(26, 100);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(303, 29);
            this.lblExample.TabIndex = 0;
            this.lblExample.Text = "Не го притискај копчето!";
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(79, 168);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(200, 43);
            this.btnExample.TabIndex = 1;
            this.btnExample.Text = "Добро";
            this.btnExample.UseVisualStyleBackColor = true;
            this.btnExample.Click += new System.EventHandler(this.btnExample_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 330);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.lblExample);
            this.Name = "Form1";
            this.Text = "Прва форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Button btnExample;
    }
}

