﻿
namespace Number_Minigame
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Theme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Theme
            // 
            this.Btn_Theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Btn_Theme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Theme.Location = new System.Drawing.Point(26, 30);
            this.Btn_Theme.Name = "Btn_Theme";
            this.Btn_Theme.Size = new System.Drawing.Size(173, 38);
            this.Btn_Theme.TabIndex = 0;
            this.Btn_Theme.Text = "Light Mode";
            this.Btn_Theme.UseVisualStyleBackColor = true;
            this.Btn_Theme.Click += new System.EventHandler(this.Btn_Theme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1388, 624);
            this.Controls.Add(this.Btn_Theme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Theme;
    }
}

