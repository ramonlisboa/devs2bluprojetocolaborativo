namespace Devs2Blu.ProjetosAula.ViewProject
{
    partial class FormEduHofs
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
            this.labelEduHofs = new System.Windows.Forms.Label();
            this.buttonLigaDesliga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEduHofs
            // 
            this.labelEduHofs.AutoSize = true;
            this.labelEduHofs.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEduHofs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelEduHofs.Location = new System.Drawing.Point(146, 70);
            this.labelEduHofs.Name = "labelEduHofs";
            this.labelEduHofs.Size = new System.Drawing.Size(132, 39);
            this.labelEduHofs.TabIndex = 0;
            this.labelEduHofs.Text = "EduHofs";
            // 
            // buttonLigaDesliga
            // 
            this.buttonLigaDesliga.BackColor = System.Drawing.Color.Black;
            this.buttonLigaDesliga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLigaDesliga.ForeColor = System.Drawing.Color.White;
            this.buttonLigaDesliga.Location = new System.Drawing.Point(324, 221);
            this.buttonLigaDesliga.Name = "buttonLigaDesliga";
            this.buttonLigaDesliga.Size = new System.Drawing.Size(75, 41);
            this.buttonLigaDesliga.TabIndex = 1;
            this.buttonLigaDesliga.Text = "O";
            this.buttonLigaDesliga.UseVisualStyleBackColor = false;
            this.buttonLigaDesliga.Click += new System.EventHandler(this.buttonLigaDesliga_Click);
            // 
            // FormEduHofs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLigaDesliga);
            this.Controls.Add(this.labelEduHofs);
            this.Name = "FormEduHofs";
            this.Text = "FormEduHofs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEduHofs;
        private System.Windows.Forms.Button buttonLigaDesliga;
    }
}