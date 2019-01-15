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
    public partial class ContactEdit : Form
    {
        Client _client;
        Client _contact;
        public ContactEdit(Client client,Client contact)
        {
            InitializeComponent();
            cbOperators.DataSource = Operator.Items;
            _client = client;
            _contact = contact;
            if (contact == null)
            {
                _contact = new Client(null);
                
            }
            else
            {
                tbName.Text = _contact.FirstName;
                tbSurname.Text = _contact.LastName;
                cbOperators.SelectedItem = _contact.CurrentOperator; 
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if ( (tbName.Text != "" || tbSurname.Text != "") && cbOperators.Text != "")
            {
                _contact.FirstName = tbName.Text;
                _contact.LastName = tbSurname.Text;
                _contact.CurrentOperator = (Operator)cbOperators.SelectedItem;
                _client.SaveContact(_contact);
                Client.SetNumbOfAddClients();
                Close();
            }
            else
            {
                MessageBox.Show("Enter the full information!");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if ((tbName.Text == "" || tbSurname.Text == "") && cbOperators.SelectedItem != null)
            {
                _client.contacts.Remove(_contact);
                
            }
            Close();
        }
    }
}
