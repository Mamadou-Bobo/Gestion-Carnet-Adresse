using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MetierCarnetAdresse.Model;

namespace MetierCarnetAdresse
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        gestion_contactsEntities db = new gestion_contactsEntities();

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        /// <summary>
        /// permet d'ajouter un contact
        /// </summary>
        /// <param name="c"></param>
        /// <returns>bool</returns>
        public bool addContact(contact c)
        {
            bool rep;

            try
            {
                db.contact.Add(c);
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {
                rep = false;
                logError(ex.ToString());
            }
            return rep;
        }

        /// <summary>
        /// retourne la liste de tous les contacts
        /// </summary>
        /// <returns>List<contact></returns>
        public List<contact> getListContact()
        {
            return db.contact.ToList();
        }

        /// <summary>
        /// permet de supprimer un contact
        /// </summary>
        /// <param name="id"></param>
        /// <returns>bool</returns>
        public bool deleteContact(int id)
        {
            bool rep;

            try
            {
                var contact = db.contact.Find(id);
                db.contact.Remove(contact);
                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {
                rep = false;
                logError(ex.ToString());
            }

            return rep;
        }

        /// <summary>
        /// retourne le contact correspondant à l'identifiant
        /// </summary>
        /// <param name="id"></param>
        /// <returns>contact</returns>
        public contact getContact(int id)
        {
            return db.contact.Find(id);
        }

        /// <summary>
        /// permet d'éditer un contact
        /// </summary>
        /// <param name="c"></param>
        /// <returns>bool</returns>
        public bool editContact(contact c)
        {
            bool rep;

            try
            {
                contact contactService = db.contact.Find(c.idContact);
                contactService.prenom = c.prenom;
                contactService.nom = c.nom;
                contactService.csp = c.csp;
                contactService.sexe = c.sexe;
                contactService.ville = c.ville;

                db.SaveChanges();
                rep = true;
            }
            catch (Exception ex)
            {
                rep = false;
                logError(ex.ToString());

            }

            return rep;
        }

        /// <summary>
        /// permet d'ajouter un numéro de téléphone
        /// </summary>
        /// <param name="num"></param>
        /// <returns>bool</returns>
        public bool addNumber(numtel num)
        {
            bool rep;

            try
            {
                db.numtel.Add(num);
                db.SaveChanges();
                rep = true;
            } catch(Exception ex)
            {
                rep = false;
                logError(ex.ToString());
            }

            return rep;
        }

        /// <summary>
        /// retourne la liste de tous les contacts
        /// </summary>
        /// <returns>List<numtel></returns>
        public List<numtel> getListNumber()
        {
            return db.numtel.ToList();
        }

        /// <summary>
        /// permet de rechercher un contact selon un le prenom ou le nom
        /// </summary>
        /// <param name="prenom"></param>
        /// <param name="nom"></param>
        /// <returns>List<n></returns>
        public List<contact> searchContact(string recherche)
        {
            var contacts = db.contact.ToList();

            if(!string.IsNullOrEmpty(recherche))
            {
                contacts = contacts.Where(c =>
                                      c.prenom.ToUpper()
                                      .Contains(recherche.ToUpper())).ToList();
            }

            return contacts;
        }

        public void logError(string error)
        {
            try
            {
                System.IO.FileStream wFile;
                byte[] byteData = null;
                byteData = Encoding.ASCII.GetBytes(error);
                wFile = new FileStream(".\\errorFile.txt", FileMode.Append);
                wFile.Write(byteData, 0, byteData.Length);
                wFile.Close();
            }
            catch (IOException ex)
            {
                showErrorMessage(ex.ToString());
            }
        }

        public string showErrorMessage(string error)
        {
            return error;
        }
    }
}
