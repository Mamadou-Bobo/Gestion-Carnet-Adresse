
namespace CarnetAdresseApp
{
    partial class frmAjoutNumero
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
            this.txtNumero = new Guna.UI.WinForms.GunaTextBox();
            this.btnEnregistrer = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cbbContact = new Guna.UI.WinForms.GunaComboBox();
            this.btnAnnuler = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(200, 132);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(77, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Numéro";
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.BaseColor = System.Drawing.Color.White;
            this.txtNumero.BorderColor = System.Drawing.Color.Silver;
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNumero.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNumero.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumero.Location = new System.Drawing.Point(313, 126);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.SelectedText = "";
            this.txtNumero.Size = new System.Drawing.Size(279, 36);
            this.txtNumero.TabIndex = 1;
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
            this.btnEnregistrer.Location = new System.Drawing.Point(205, 279);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEnregistrer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEnregistrer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.OnHoverImage = null;
            this.btnEnregistrer.OnPressedColor = System.Drawing.Color.Black;
            this.btnEnregistrer.Size = new System.Drawing.Size(152, 42);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(200, 204);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(73, 25);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Contact";
            // 
            // cbbContact
            // 
            this.cbbContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbContact.BackColor = System.Drawing.Color.Transparent;
            this.cbbContact.BaseColor = System.Drawing.Color.White;
            this.cbbContact.BorderColor = System.Drawing.Color.Silver;
            this.cbbContact.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbContact.FocusedColor = System.Drawing.Color.Empty;
            this.cbbContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbContact.ForeColor = System.Drawing.Color.Black;
            this.cbbContact.FormattingEnabled = true;
            this.cbbContact.Location = new System.Drawing.Point(313, 199);
            this.cbbContact.Name = "cbbContact";
            this.cbbContact.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbContact.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbContact.Size = new System.Drawing.Size(279, 35);
            this.cbbContact.TabIndex = 4;
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
            this.btnAnnuler.Location = new System.Drawing.Point(440, 279);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAnnuler.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAnnuler.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAnnuler.OnHoverImage = null;
            this.btnAnnuler.OnPressedColor = System.Drawing.Color.Black;
            this.btnAnnuler.Size = new System.Drawing.Size(152, 42);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "annuler";
            this.btnAnnuler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmAjoutNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.cbbContact);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAjoutNumero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout Numéro";
            this.Load += new System.EventHandler(this.frmAjoutNumero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtNumero;
        private Guna.UI.WinForms.GunaButton btnEnregistrer;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cbbContact;
        private Guna.UI.WinForms.GunaButton btnAnnuler;
    }
}