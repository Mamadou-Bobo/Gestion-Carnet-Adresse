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
    public partial class frmAjoutNumero : Form
    {
        frmContact obj = (frmContact)Application.OpenForms["frmContact"];

        ServiceCarnetAdresse.Service1Client service = new ServiceCarnetAdresse.Service1Client();

        public frmAjoutNumero()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAjoutNumero_Load(object sender, EventArgs e)
        {
            cbbContact.DataSource = service.getListContact();
            cbbContact.ValueMember = "idContact";
            cbbContact.DisplayMember = "Prenom";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            ServiceCarnetAdresse.numtel num = new ServiceCarnetAdresse.numtel();
            num.numeroTel = txtNumero.Text;
            num.idContact = int.Parse(cbbContact.SelectedValue.ToString());

            service.addNumber(num);

            this.Hide();

            obj.loadData();
        }
    }
}
