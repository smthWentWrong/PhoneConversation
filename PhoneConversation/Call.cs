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
    public partial class CallForm : Form
    {
        Client _client;
        public CallForm(Client client)
        {
            InitializeComponent();
            _client = client;
            lbContacts.DataSource = _client.contacts;
        }

        private void btnCancel_Click(object sender,EventArgs e)
        { 
            Close();
        }

        private void btnStartCall_Click(object sender, EventArgs e)
        {
            if (_client != (Client)lbContacts.SelectedItem)
            {
                Call call = new Call(_client, (Client)lbContacts.SelectedItem);
                new Calling(call).ShowDialog();
            }
            else MessageBox.Show("Error!");
        }
    }
}
