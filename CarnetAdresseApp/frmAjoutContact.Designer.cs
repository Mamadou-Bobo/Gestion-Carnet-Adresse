
namespace CarnetAdresseApp
{
    partial class frmAjoutContact
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnAnnuler = new Guna.UI.WinForms.GunaButton();
            this.btnEnregistrer = new Guna.UI.WinForms.GunaButton();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCsp = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cbbSexe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(271, 152);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(52, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Nom";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(271, 100);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(74, 25);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Prénom";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(271, 204);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(43, 25);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "CSP";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(271, 256);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(48, 25);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Sexe";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(271, 308);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(44, 25);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Ville";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnnuler.AnimationHoverSpeed = 0.07F;
            this.btnAnnuler.AnimationSpeed = 0.03F;
            this.btnAnnuler.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAnnuler.BorderColor = System.Drawing.Color.Black;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAnnuler.FocusedColor = System.Drawing.Color.Empty;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Image = null;
            this.btnAnnuler.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAnnuler.Location = new System.Drawing.Point(492, 382);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAnnuler.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAnnuler.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnnuler.OnHoverImage = null;
            this.btnAnnuler.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnnuler.Size = new System.Drawing.Size(148, 42);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "annuler";
            this.btnAnnuler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnregistrer.AnimationHoverSpeed = 0.07F;
            this.btnEnregistrer.AnimationSpeed = 0.03F;
            this.btnEnregistrer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEnregistrer.BorderColor = System.Drawing.Color.Black;
            this.btnEnregistrer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEnregistrer.FocusedColor = System.Drawing.Color.Empty;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Image = null;
            this.btnEnregistrer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEnregistrer.Location = new System.Drawing.Point(276, 382);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEnregistrer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEnregistrer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.OnHoverImage = null;
            this.btnEnregistrer.OnPressedColor = System.Drawing.Color.Black;
            this.btnEnregistrer.Size = new System.Drawing.Size(148, 42);
            this.btnEnregistrer.TabIndex = 12;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrenom.Location = new System.Drawing.Point(397, 96);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(243, 33);
            this.txtPrenom.TabIndex = 14;
            // 
            // txtVille
            // 
            this.txtVille.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVille.Location = new System.Drawing.Point(397, 304);
            this.txtVille.Multiline = true;
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(243, 33);
            this.txtVille.TabIndex = 16;
            // 
            // txtCsp
            // 
            this.txtCsp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCsp.Location = new System.Drawing.Point(397, 200);
            this.txtCsp.Multiline = true;
            this.txtCsp.Name = "txtCsp";
            this.txtCsp.Size = new System.Drawing.Size(243, 33);
            this.txtCsp.TabIndex = 18;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNom.Location = new System.Drawing.Point(397, 148);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(243, 33);
            this.txtNom.TabIndex = 19;
            // 
            // cbbSexe
            // 
            this.cbbSexe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSexe.FormattingEnabled = true;
            this.cbbSexe.Items.AddRange(new object[] {
            "Masculin",
            "Féminin"});
            this.cbbSexe.Location = new System.Drawing.Point(397, 254);
            this.cbbSexe.Name = "cbbSexe";
            this.cbbSexe.Size = new System.Drawing.Size(243, 28);
            this.cbbSexe.TabIndex = 20;
            // 
            // frmAjoutContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 576);
            this.ControlBox = false;
            this.Controls.Add(this.cbbSexe);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCsp);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAjoutContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout contact";
            this.Load += new System.EventHandler(this.frmSaisie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaButton btnEnregistrer;
        private Guna.UI.WinForms.GunaButton btnAnnuler;
        public System.Windows.Forms.TextBox txtPrenom;
        public System.Windows.Forms.TextBox txtNom;
        public System.Windows.Forms.TextBox txtCsp;
        public System.Windows.Forms.ComboBox cbbSexe;
        public System.Windows.Forms.TextBox txtVille;
    }
}