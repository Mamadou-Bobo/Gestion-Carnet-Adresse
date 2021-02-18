
using System.Windows.Forms;

namespace CarnetAdresseApp
{
    partial class frmContact
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAjouter = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnContacts = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtRecherche = new Guna.UI.WinForms.GunaTextBox();
            this.dgContacts = new Guna.UI.WinForms.GunaDataGridView();
            this.idContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbNumeroTel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearch = new Guna.UI.WinForms.GunaImageButton();
            this.btnImprimer = new Guna.UI.WinForms.GunaButton();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.gunaPanel1.Controls.Add(this.gunaAdvenceButton1);
            this.gunaPanel1.Controls.Add(this.btnAjouter);
            this.gunaPanel1.Controls.Add(this.btnContacts);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(273, 666);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Animated = true;
            this.gunaAdvenceButton1.AnimationHoverSpeed = 1F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = global::CarnetAdresseApp.Properties.Resources.icons8_plus_50;
            this.gunaAdvenceButton1.ImageOffsetX = 10;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(0, 371);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(89)))), ((int)(((byte)(189)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(273, 73);
            this.gunaAdvenceButton1.TabIndex = 3;
            this.gunaAdvenceButton1.Text = "Ajouter numéro";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaAdvenceButton1.TextOffsetX = 20;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Animated = true;
            this.btnAjouter.AnimationHoverSpeed = 1F;
            this.btnAjouter.AnimationSpeed = 0.03F;
            this.btnAjouter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(131)))));
            this.btnAjouter.BorderColor = System.Drawing.Color.Transparent;
            this.btnAjouter.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAjouter.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAjouter.CheckedForeColor = System.Drawing.Color.White;
            this.btnAjouter.CheckedImage = null;
            this.btnAjouter.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAjouter.FocusedColor = System.Drawing.Color.Empty;
            this.btnAjouter.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = global::CarnetAdresseApp.Properties.Resources.icons8_plus_50;
            this.btnAjouter.ImageOffsetX = 10;
            this.btnAjouter.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAjouter.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAjouter.Location = new System.Drawing.Point(0, 246);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnAjouter.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAjouter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAjouter.OnHoverImage = null;
            this.btnAjouter.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(89)))), ((int)(((byte)(189)))));
            this.btnAjouter.OnPressedColor = System.Drawing.Color.Black;
            this.btnAjouter.Size = new System.Drawing.Size(273, 73);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter contact";
            this.btnAjouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAjouter.TextOffsetX = 20;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Animated = true;
            this.btnContacts.AnimationHoverSpeed = 1F;
            this.btnContacts.AnimationSpeed = 0.03F;
            this.btnContacts.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(92)))), ((int)(((byte)(116)))));
            this.btnContacts.BorderColor = System.Drawing.Color.Transparent;
            this.btnContacts.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnContacts.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnContacts.CheckedForeColor = System.Drawing.Color.White;
            this.btnContacts.CheckedImage = null;
            this.btnContacts.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnContacts.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnContacts.FocusedColor = System.Drawing.Color.Empty;
            this.btnContacts.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacts.ForeColor = System.Drawing.Color.White;
            this.btnContacts.Image = global::CarnetAdresseApp.Properties.Resources.icons8_contact_details_64;
            this.btnContacts.ImageOffsetX = 10;
            this.btnContacts.ImageSize = new System.Drawing.Size(20, 20);
            this.btnContacts.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnContacts.Location = new System.Drawing.Point(0, 124);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnContacts.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnContacts.OnHoverForeColor = System.Drawing.Color.White;
            this.btnContacts.OnHoverImage = null;
            this.btnContacts.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(89)))), ((int)(((byte)(189)))));
            this.btnContacts.OnPressedColor = System.Drawing.Color.Black;
            this.btnContacts.Size = new System.Drawing.Size(273, 73);
            this.btnContacts.TabIndex = 1;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnContacts.TextOffsetX = 65;
            // 
            // txtRecherche
            // 
            this.txtRecherche.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.txtRecherche.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.txtRecherche.BorderSize = 1;
            this.txtRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecherche.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.txtRecherche.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.txtRecherche.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtRecherche.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRecherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(18)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtRecherche.Location = new System.Drawing.Point(361, 27);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.PasswordChar = '\0';
            this.txtRecherche.SelectedText = "";
            this.txtRecherche.Size = new System.Drawing.Size(166, 36);
            this.txtRecherche.TabIndex = 2;
            // 
            // dgContacts
            // 
            this.dgContacts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgContacts.BackgroundColor = System.Drawing.Color.White;
            this.dgContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgContacts.ColumnHeadersHeight = 32;
            this.dgContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContact,
            this.prenom,
            this.nom,
            this.sexe,
            this.ville,
            this.csp,
            this.cbbNumeroTel,
            this.modifier,
            this.Supprimer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgContacts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgContacts.EnableHeadersVisualStyles = false;
            this.dgContacts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgContacts.Location = new System.Drawing.Point(361, 167);
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.RowHeadersVisible = false;
            this.dgContacts.RowHeadersWidth = 62;
            this.dgContacts.RowTemplate.Height = 28;
            this.dgContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContacts.Size = new System.Drawing.Size(872, 370);
            this.dgContacts.TabIndex = 4;
            this.dgContacts.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgContacts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgContacts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgContacts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgContacts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgContacts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgContacts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgContacts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgContacts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgContacts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgContacts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgContacts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgContacts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgContacts.ThemeStyle.HeaderStyle.Height = 32;
            this.dgContacts.ThemeStyle.ReadOnly = false;
            this.dgContacts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgContacts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgContacts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgContacts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgContacts.ThemeStyle.RowsStyle.Height = 28;
            this.dgContacts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgContacts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContacts_CellContentClick);
            // 
            // idContact
            // 
            this.idContact.DataPropertyName = "idContact";
            this.idContact.HeaderText = "ID";
            this.idContact.MinimumWidth = 8;
            this.idContact.Name = "idContact";
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "prenom";
            this.prenom.HeaderText = "Prénom";
            this.prenom.MinimumWidth = 8;
            this.prenom.Name = "prenom";
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 8;
            this.nom.Name = "nom";
            // 
            // sexe
            // 
            this.sexe.DataPropertyName = "sexe";
            this.sexe.HeaderText = "Sexe";
            this.sexe.MinimumWidth = 8;
            this.sexe.Name = "sexe";
            // 
            // ville
            // 
            this.ville.DataPropertyName = "ville";
            this.ville.HeaderText = "Ville";
            this.ville.MinimumWidth = 8;
            this.ville.Name = "ville";
            // 
            // csp
            // 
            this.csp.DataPropertyName = "csp";
            this.csp.HeaderText = "CSP";
            this.csp.MinimumWidth = 8;
            this.csp.Name = "csp";
            // 
            // cbbNumeroTel
            // 
            this.cbbNumeroTel.DataPropertyName = "numero";
            this.cbbNumeroTel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbNumeroTel.HeaderText = "Numéro";
            this.cbbNumeroTel.MinimumWidth = 8;
            this.cbbNumeroTel.Name = "cbbNumeroTel";
            this.cbbNumeroTel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbbNumeroTel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // modifier
            // 
            this.modifier.HeaderText = "Modifier";
            this.modifier.MinimumWidth = 8;
            this.modifier.Name = "modifier";
            this.modifier.Text = "Modifier";
            this.modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.MinimumWidth = 8;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // btnSearch
            // 
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.Image = global::CarnetAdresseApp.Properties.Resources.icons8_search_50__1_;
            this.btnSearch.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSearch.Location = new System.Drawing.Point(530, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.Size = new System.Drawing.Size(64, 64);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimer.AnimationHoverSpeed = 0.07F;
            this.btnImprimer.AnimationSpeed = 0.03F;
            this.btnImprimer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnImprimer.BorderColor = System.Drawing.Color.Black;
            this.btnImprimer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImprimer.FocusedColor = System.Drawing.Color.Empty;
            this.btnImprimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.Image = null;
            this.btnImprimer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImprimer.Location = new System.Drawing.Point(906, 27);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnImprimer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImprimer.OnHoverImage = null;
            this.btnImprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimer.Size = new System.Drawing.Size(160, 42);
            this.btnImprimer.TabIndex = 5;
            this.btnImprimer.Text = "imprrimer";
            this.btnImprimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(1109, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(124, 42);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Quitter";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1269, 666);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.dgContacts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "frmContact";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carnet d\'adresse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContact_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnContacts;
        private Guna.UI.WinForms.GunaAdvenceButton btnAjouter;
        private Guna.UI.WinForms.GunaTextBox txtRecherche;
        private Guna.UI.WinForms.GunaImageButton btnSearch;
        private Guna.UI.WinForms.GunaDataGridView dgContacts;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn csp;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbbNumeroTel;
        private System.Windows.Forms.DataGridViewButtonColumn modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private Guna.UI.WinForms.GunaButton btnImprimer;
        private Guna.UI.WinForms.GunaButton btnExit;
    }
}

