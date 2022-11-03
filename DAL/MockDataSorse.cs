using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODULS;
namespace DAL
{
    public class MockDataSorce:IDataSorce
    {
        void init()
        {
            emails = new List<Email>();
            emails.Add(new Email()
            {
                Subject = "Good!",
                Sender = new contacts() { name = "yaffi", email = "ds@co.il", },
                Recive = new List<contacts>() { new contacts() { name = "fcdvc", email = "dvcd@vf" } }
            });
            emails.Add(new Email()
            {
                Subject = "Good!",
                Sender = new contacts() { name = "tzipi", email = "sc@", },
                Recive = new List<contacts>() { new contacts() { name = "yaffi", email = "dvcd@vf" } }
            });
            emails.Add(new Email()
            {
                Subject = "exelent////",
                Sender = new contacts() { name = "yaffi", email = "ds@co.il", },
                Recive = new List<contacts>() { new contacts() { name = "fcdvc", email = "dvcd@vf" } }
            });
        }

        public List<contacts> contacts { get; set; }

        public List<Email> emails { get; set; }

        public List<Email> GetAll()
        {
            if (emails == null)
                init();
            return emails;
        }

        public void NewEmail(Email email)
        {
            emails.Add(email);
        }

        public void NewContact(contacts contact)
        {
            contacts.Add(contact);
        }

        public void DeleteEmail(int IdEmail)
        {
            Email tempEmail=null;
            foreach (var item in emails)
            {
                if (item.IdEmail == IdEmail)
                    tempEmail = item;
            }
            emails.Remove(tempEmail);
        }

        public void DeleteContact(int IdContact)
        {
            contacts tempContact = null;
            foreach (var item in contacts)
            {
                if (item.IdContact == IdContact)
                    tempContact = item;
            }
            contacts.Remove(tempContact);
        }

       

    }
}
