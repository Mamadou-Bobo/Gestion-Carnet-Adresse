using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarnetAdresseApp
{
    public partial class frmContact : Form
    {
        public static bool selectedIndex { get; set; }
        public static int getId { get; set; }

        frmContact obj = (frmContact)Application.OpenForms["frmContact"];

        ServiceCarnetAdresse.Service1Client service = new ServiceCarnetAdresse.Service1Client();

        public frmContact()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            cbbNumeroTel.DataSource = service.getListNumber();
            cbbNumeroTel.ValueMember = "idContact";
            cbbNumeroTel.DisplayMember = "numeroTel";
            dgContacts.DataSource = service.getListContact();
        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgContacts.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (MessageBox.Show("Voulez vous supprimer ce contact ?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = int.Parse(dgContacts.CurrentRow.Cells[4].Value.ToString());
                    service.deleteContact(id);
                    loadData();
                }
            }

            if (dgContacts.Columns[e.ColumnIndex].Name == "modifier")
            {
                getId = int.Parse(dgContacts.CurrentRow.Cells[4].Value.ToString());

                selectedIndex = true;

                frmAjoutContact f = new frmAjoutContact();

                f.txtPrenom.Text = dgContacts.CurrentRow.Cells[6].Value.ToString();
                f.txtNom.Text = dgContacts.CurrentRow.Cells[5].Value.ToString();
                f.txtCsp.Text = dgContacts.CurrentRow.Cells[3].Value.ToString();
                f.cbbSexe.Text = dgContacts.CurrentRow.Cells[7].Value.ToString();
                f.txtVille.Text = dgContacts.CurrentRow.Cells[8].Value.ToString();

                f.Show();
            }
        }  

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            frmReportCarnetAdresse f = new frmReportCarnetAdresse();
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dgContacts.DataSource = service.searchContact(txtRecherche.Text);
        }

        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            frmAjoutContact f = new frmAjoutContact();
            f.Show();
            
        }

        private void btnAjouterNumero_Click(object sender, EventArgs e)
        {
            frmAjoutNumero f = new frmAjoutNumero();
            f.Show();
        }

        private void cbbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgContacts.Theme = (Guna.UI.WinForms.GunaDataGridViewPresetThemes)cbbColors.SelectedIndex;
        }
    }

}


