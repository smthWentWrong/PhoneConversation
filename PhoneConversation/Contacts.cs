using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneConversation
{
    
    public partial class Contacts : Form
    {
        static Client _client;

        public Contacts(Client cl)
        {
            _client = cl;
            InitializeComponent();
        }
        private void Contacts_Load(object sender, EventArgs e)
        {
            
            lbContacts.DataSource = _client.contacts;
            lNumbOfAddClients.Text = "Numb of add contacts: " + Convert.ToString(Client.GetNumbOfAddClients());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new ContactEdit(_client,null).ShowDialog();
            lNumbOfAddClients.Text = "Numb of add clients: " + Convert.ToString(Client.GetNumbOfAddClients());
            RefreshContacts();
        }

        private void RefreshContacts()
        {
            lbContacts.DataSource = null;
            lbContacts.DataSource = _client.contacts;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            _client.contacts.Remove((Client)lbContacts.SelectedItem);
            RefreshContacts();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            new ContactEdit(_client,(Client)lbContacts.SelectedItem).ShowDialog();
            RefreshContacts();
        }

        private void Contacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
