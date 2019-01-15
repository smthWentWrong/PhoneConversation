using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.Serialization;
namespace PhoneConversation
{
    public partial class Replenishments : Form
    {
        Client _client;
        public Replenishments(Client client)
        {
            InitializeComponent();
            _client = client;
            
            RefreshReplenishment();
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btOkReplenish_Click(object sender, EventArgs e)
        {
            new Replenishment(_client, (int)numericReplenishmentSum.Value);
            RefreshReplenishment();
        }
        private void RefreshReplenishment()
        {
            lbReplenishments.DataSource = null;
            lbReplenishments.DataSource = _client.GetReplenishments;
        }


        private void Replenishments_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
