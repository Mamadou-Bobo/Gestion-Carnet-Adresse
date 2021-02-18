using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarnetAdresseApp.Report;

namespace CarnetAdresseApp
{
    public partial class frmReportCarnetAdresse : Form
    {
        ServiceCarnetAdresse.Service1Client service = new ServiceCarnetAdresse.Service1Client();

        public frmReportCarnetAdresse()
        {
            InitializeComponent();
        }

        private void frmReportCarnetAdresse_Load(object sender, EventArgs e)
        {
            rptCarnetAdresse objRpt = new rptCarnetAdresse();
            objRpt.SetDataSource(GetTableListContact());
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }

        public DataTable GetTableListContact()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Prenom", typeof(string));
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Csp", typeof(string));
            table.Columns.Add("Sexe", typeof(string));
            table.Columns.Add("Ville", typeof(string));
            table.Columns.Add("NumeroTel", typeof(string));

            var contacts = service.getListNumber();

            foreach (var item in contacts)
            {
                try
                {
                    string prenom = item.idContact > 0 ? service.getContact(item.idContact).prenom : string.Empty;
                    string nom = item.idContact > 0 ? service.getContact(item.idContact).nom : string.Empty;
                    string csp = item.idContact > 0 ? service.getContact(item.idContact).csp : string.Empty;
                    string sexe = item.idContact > 0 ? service.getContact(item.idContact).sexe : string.Empty;
                    string ville = item.idContact > 0 ? service.getContact(item.idContact).ville : string.Empty;

                    table.Rows.Add(prenom,
                                    nom,
                                    csp,
                                    sexe,
                                    ville,
                                    item.numeroTel);

                } catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return table;
        }
    }
}
