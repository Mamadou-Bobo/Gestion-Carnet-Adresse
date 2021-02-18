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
    public partial class frmAjoutContact : Form
    {

        frmContact obj = (frmContact)Application.OpenForms["frmContact"];

        ServiceCarnetAdresse.Service1Client service = new ServiceCarnetAdresse.Service1Client();

        public frmAjoutContact()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            if (frmContact.selectedIndex)
            {
                ServiceCarnetAdresse.contact contact = service.getContact(frmContact.getId);
                contact.prenom = txtPrenom.Text;
                contact.nom = txtNom.Text;
                contact.csp = txtCsp.Text;
                contact.sexe = cbbSexe.Text;
                contact.ville = txtVille.Text;

                service.editContact(contact);
            } else
            {
                ServiceCarnetAdresse.contact contact = new ServiceCarnetAdresse.contact();
                contact.prenom = txtPrenom.Text;
                contact.nom = txtNom.Text;
                contact.csp = txtCsp.Text;
                contact.sexe = cbbSexe.Text;
                contact.ville = txtVille.Text;

                service.addContact(contact);
            }                      

            obj.loadData();

            this.Hide();
        }

        private void frmSaisie_Load(object sender, EventArgs e)
        {
            if (frmContact.selectedIndex)
            {
                btnEnregistrer.Text = "Modifier";
            }
        }
    }
}
