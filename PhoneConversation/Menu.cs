using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PhoneConversation
{
    public partial class Menu : Form
    {
        static Client _client;
        public Menu()
        {
            InitializeComponent();
            
        }

        public Menu(Client client)
        {
            _client = client;
            InitializeComponent();
            
            if (_client != null)
            {
                lbClient.Text = "Client: " + _client.ToString();
                lbBalance.Text = "Balance: " + _client.Balance;
            }
            else
            {
                lbClient.Text = "";
                lbBalance.Text = "";
            }
           
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            new Contacts(_client).ShowDialog();
            if (_client != null)
            {
                lbClient.Text = "Client: " + _client.ToString();
                lbBalance.Text = "Balance: " + _client.Balance;
            }
            else
            {
                lbClient.Text = "";
                lbBalance.Text = "";
            }
            
        }

        private void btnOperators_Click(object sender, EventArgs e)
        {
            new Operators().ShowDialog();
        }

        //private void Menu_Load(object sender, EventArgs e)
        //{


        //    //new Operator("Lifecell", "+38067");
        //    //new Operator("MTS", "+38055");
        //    //new Operator("Kyivstar", "+38097");
        //    //Operator op1 = new Operator("Vodafone", "+38055");
        //    //Operator op2 = new Operator("Intertelekom", "+38044");

        //    Operator.Items[0].AddTariff(new Tariff("Rouming", 5));
        //    Client cl1 = new Client("Mark", "Elenberg");
        //    Operator.Items[0].AddClient(cl1);
        //    Client cl2 = new Client("Mama");
        //    Operator.Items[2].AddClient(cl2);
        //    Client cl3 = new Client("Jhonny", "Depp");
        //    Operator.Items[3].AddClient(cl3);
        //    _client.contacts.Add(cl1);
        //    _client.contacts.Add(cl2);
        //    _client.contacts.Add(cl3);
        //    lbCalls.DataSource = Call.Items;
        //    lbBlocks.DataSource =  _client.blocks;

        //}

        private void btnReplenishment_Click(object sender, EventArgs e)
        {
            new Replenishments(_client).ShowDialog();
            lbBalance.Text = "Balance: " + _client.Balance;
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            new CallForm(_client).ShowDialog();
            RefreshCalls();
            RefreshBlock();
            lbBalance.Text = "Balance: " + _client.Balance;
            
        }
        private void RefreshCalls()
        {
            lbCalls.DataSource = null;
            lbCalls.DataSource = Call.Items;
        }
        private void RefreshBlock()
        {
            lbBlocks.DataSource = null;
            lbBlocks.DataSource = _client.blocks;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Do you want to SEREALIZE classes in xml?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SerealizeXml serealizeXml = new SerealizeXml();
                serealizeXml.SaveClient(_client);
                serealizeXml.Save(_client, "Replenishment");

               // SerealizeXml.SaveClient(_client);
               // SerealizeXml.Save(_client, "Replenishment");
               // SerealizeXml.Save(_client, "Block");
               // SerealizeXml.Save(_client, "Call");
               // SerealizeXml.Save(_client, "Operator");
               // SerealizeXml.Save(_client, "Tariff");
               // ////
               // SerealizeJson.SaveClientJson(_client);

               // ///
               //// SerealizeTxt.SaveClientTxt(_client);
            }
            

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to DESEREALIZE classes in xml?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SerealizeXml serealizeXml = new SerealizeXml();
                serealizeXml.LoadClient(_client);
                serealizeXml.Load(_client, "Replenishment");
                //SerealizeXml.LoadClient(_client);
                //_client.contacts.Add(_client);
                //SerealizeXml.Load(_client, "Replenishment");
                //SerealizeXml.Load(_client, "Block");
                //SerealizeXml.Load(_client,"Call");
                //SerealizeXml.Load(_client, "Operator");
                //SerealizeXml.Load(_client,"Tariff");
                //////
                /////
                //SerealizeJson.LoadClientJson(_client);
                //_client.contacts.Add(_client);
                ////
                ///
                //SerealizeTxt.LoadClientTxt(_client);
                
            }
        }
        
    }
}
