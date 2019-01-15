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
    public partial class Registration : Form
    {
        public static Client _client;
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Registration(object sender, EventArgs e)
        {
            
            if (lbOperatorsReg.SelectedItem != null &&
                textName.Text != "" &&
                textSurname.Text != "" &&
                tbBalance.Text != "" &&
                Convert.ToDouble(tbBalance.Text) > 0)
            {
                _client = new Client(textName.Text, textSurname.Text,Convert.ToDouble(tbBalance.Text));
                
                _client.CurrentOperator = (Operator)lbOperatorsReg.SelectedItem ;
                _client.CurrentOperator.AddClient(_client);
                _client.Tariff = (Tariff)lbTariffs.SelectedItem;
                ClientRepository.clients.Add(_client);
                this.Close();
            }
            else
            {
                if (lbOperatorsReg.SelectedItem == null)
                {
                    MessageBox.Show("Choice the operator!");
                }
                if (textName.Text == "") MessageBox.Show("Enter the name!");
                if (textSurname.Text == "") MessageBox.Show("Enter the surname!");
                if (tbBalance.Text == "") MessageBox.Show("Enter the primary balance!");
            }
        }
        
        private void Registration_Load(object sender, EventArgs e)
        {
            new Operator("Lifecell", "+38067");
            new Operator("MTS", "+38055");
            new Operator("Kyivstar", "+38097");
            Operator op1 = new Operator("Vodafone", "+38055");
            Operator op2 = new Operator("Intertelekom", "+38044");
            
            foreach(Operator op in Operator.Items)
            {
                op.Tariffs.AddRange(TariffRepository.tariffs);
            }
            Operator.Items[1].DeleteTariff(TariffRepository.tariffs[0]);
            Operator.Items[0].Tariffs.Add(new Tariff("Family", 4.5));
            lbOperatorsReg.DataSource = Operator.Items;
            lbTariffs.DataSource = ((Operator)lbOperatorsReg.SelectedItem).Tariffs;
        }

        private void lbOperatorsReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTariffs();
        }
        private void RefreshTariffs()
        {
            lbTariffs.DataSource = null;
            lbTariffs.DataSource = ((Operator)lbOperatorsReg.SelectedItem).Tariffs;
        }
    }
}
