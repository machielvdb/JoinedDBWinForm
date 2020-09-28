namespace JoinedDBWinForm
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
            this.lbPersonen = new System.Windows.Forms.ListBox();
            this.btnBewerken = new System.Windows.Forms.Button();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.tbLeeftijd = new System.Windows.Forms.TextBox();
            this.tbBadge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPersonen
            // 
            this.lbPersonen.FormattingEnabled = true;
            this.lbPersonen.Location = new System.Drawing.Point(12, 13);
            this.lbPersonen.Name = "lbPersonen";
            this.lbPersonen.Size = new System.Drawing.Size(120, 160);
            this.lbPersonen.TabIndex = 0;
            this.lbPersonen.SelectedIndexChanged += new System.EventHandler(this.lbPersonen_SelectedIndexChanged);
            // 
            // btnBewerken
            // 
            this.btnBewerken.Location = new System.Drawing.Point(139, 13);
            this.btnBewerken.Name = "btnBewerken";
            this.btnBewerken.Size = new System.Drawing.Size(100, 23);
            this.btnBewerken.TabIndex = 1;
            this.btnBewerken.Text = "Bewerken";
            this.btnBewerken.UseVisualStyleBackColor = true;
            this.btnBewerken.Click += new System.EventHandler(this.btnBewerken_Click);
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(139, 146);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(100, 23);
            this.btnOpslaan.TabIndex = 2;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(139, 42);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(100, 20);
            this.tbVoornaam.TabIndex = 3;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(139, 68);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(100, 20);
            this.tbAchternaam.TabIndex = 4;
            // 
            // tbLeeftijd
            // 
            this.tbLeeftijd.Location = new System.Drawing.Point(139, 94);
            this.tbLeeftijd.Name = "tbLeeftijd";
            this.tbLeeftijd.Size = new System.Drawing.Size(100, 20);
            this.tbLeeftijd.TabIndex = 5;
            // 
            // tbBadge
            // 
            this.tbBadge.Location = new System.Drawing.Point(139, 120);
            this.tbBadge.Name = "tbBadge";
            this.tbBadge.Size = new System.Drawing.Size(100, 20);
            this.tbBadge.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 185);
            this.Controls.Add(this.tbBadge);
            this.Controls.Add(this.tbLeeftijd);
            this.Controls.Add(this.tbAchternaam);
            this.Controls.Add(this.tbVoornaam);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnBewerken);
            this.Controls.Add(this.lbPersonen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPersonen;
        private System.Windows.Forms.Button btnBewerken;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.TextBox tbLeeftijd;
        private System.Windows.Forms.TextBox tbBadge;
    }
}

