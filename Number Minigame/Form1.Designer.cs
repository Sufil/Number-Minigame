
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
            this.GB_Number_Container = new System.Windows.Forms.GroupBox();
            this.GB_Numbers_To_Find = new System.Windows.Forms.GroupBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.RBtn_Normal = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Btn_Rules = new System.Windows.Forms.Button();
            this.CB_Colours = new System.Windows.Forms.CheckBox();
            this.GB_Colours = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Btn_Theme
            // 
            this.Btn_Theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Btn_Theme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Theme.Location = new System.Drawing.Point(61, 30);
            this.Btn_Theme.Name = "Btn_Theme";
            this.Btn_Theme.Size = new System.Drawing.Size(173, 38);
            this.Btn_Theme.TabIndex = 0;
            this.Btn_Theme.Text = "Light Mode";
            this.Btn_Theme.UseVisualStyleBackColor = true;
            this.Btn_Theme.Click += new System.EventHandler(this.Btn_Theme_Click);
            // 
            // GB_Number_Container
            // 
            this.GB_Number_Container.ForeColor = System.Drawing.Color.GhostWhite;
            this.GB_Number_Container.Location = new System.Drawing.Point(368, 12);
            this.GB_Number_Container.Name = "GB_Number_Container";
            this.GB_Number_Container.Size = new System.Drawing.Size(610, 600);
            this.GB_Number_Container.TabIndex = 1;
            this.GB_Number_Container.TabStop = false;
            this.GB_Number_Container.Visible = false;
            // 
            // GB_Numbers_To_Find
            // 
            this.GB_Numbers_To_Find.ForeColor = System.Drawing.Color.GhostWhite;
            this.GB_Numbers_To_Find.Location = new System.Drawing.Point(1030, 12);
            this.GB_Numbers_To_Find.Name = "GB_Numbers_To_Find";
            this.GB_Numbers_To_Find.Size = new System.Drawing.Size(346, 600);
            this.GB_Numbers_To_Find.TabIndex = 2;
            this.GB_Numbers_To_Find.TabStop = false;
            this.GB_Numbers_To_Find.Visible = false;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.Btn_Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Start.Location = new System.Drawing.Point(61, 539);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(173, 45);
            this.Btn_Start.TabIndex = 3;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // RBtn_Normal
            // 
            this.RBtn_Normal.Checked = true;
            this.RBtn_Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.RBtn_Normal.ForeColor = System.Drawing.Color.FloralWhite;
            this.RBtn_Normal.Location = new System.Drawing.Point(61, 454);
            this.RBtn_Normal.Name = "RBtn_Normal";
            this.RBtn_Normal.Size = new System.Drawing.Size(139, 30);
            this.RBtn_Normal.TabIndex = 4;
            this.RBtn_Normal.TabStop = true;
            this.RBtn_Normal.Text = "Play by myself";
            this.RBtn_Normal.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton1.ForeColor = System.Drawing.Color.FloralWhite;
            this.radioButton1.Location = new System.Drawing.Point(61, 490);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(173, 30);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "Let Computer play";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Btn_Rules
            // 
            this.Btn_Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Btn_Rules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Rules.Location = new System.Drawing.Point(61, 88);
            this.Btn_Rules.Name = "Btn_Rules";
            this.Btn_Rules.Size = new System.Drawing.Size(173, 38);
            this.Btn_Rules.TabIndex = 6;
            this.Btn_Rules.Text = "How to Play";
            this.Btn_Rules.UseVisualStyleBackColor = true;
            // 
            // CB_Colours
            // 
            this.CB_Colours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CB_Colours.ForeColor = System.Drawing.Color.FloralWhite;
            this.CB_Colours.Location = new System.Drawing.Point(61, 148);
            this.CB_Colours.Name = "CB_Colours";
            this.CB_Colours.Size = new System.Drawing.Size(222, 24);
            this.CB_Colours.TabIndex = 7;
            this.CB_Colours.Text = "Show Colour Explanation";
            this.CB_Colours.UseVisualStyleBackColor = true;
            this.CB_Colours.CheckedChanged += new System.EventHandler(this.CB_Colours_CheckedChanged);
            // 
            // GB_Colours
            // 
            this.GB_Colours.ForeColor = System.Drawing.Color.GhostWhite;
            this.GB_Colours.Location = new System.Drawing.Point(61, 178);
            this.GB_Colours.Name = "GB_Colours";
            this.GB_Colours.Size = new System.Drawing.Size(222, 270);
            this.GB_Colours.TabIndex = 2;
            this.GB_Colours.TabStop = false;
            this.GB_Colours.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1388, 624);
            this.Controls.Add(this.GB_Colours);
            this.Controls.Add(this.CB_Colours);
            this.Controls.Add(this.Btn_Rules);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.RBtn_Normal);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.GB_Numbers_To_Find);
            this.Controls.Add(this.GB_Number_Container);
            this.Controls.Add(this.Btn_Theme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Theme;
        private System.Windows.Forms.GroupBox GB_Number_Container;
        private System.Windows.Forms.GroupBox GB_Numbers_To_Find;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.RadioButton RBtn_Normal;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Btn_Rules;
        private System.Windows.Forms.CheckBox CB_Colours;
        private System.Windows.Forms.GroupBox GB_Colours;
    }
}

