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
    public partial class TariffEdit : Form
    {
        Tariff _tariff;
        Operator _op;
        public TariffEdit(Tariff tariff,Operator op)
        {
            InitializeComponent();
            _tariff = tariff;
            _op = op;
            if (_tariff == null)
            {
                _tariff = new Tariff(null);
            }
            else
            {
                tbTariff.Text = _tariff.Name;
                pricePerMinute.Text = Convert.ToString(_tariff.PricePerMinute);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(tbTariff.Text !="" && pricePerMinute.Value != 0)
            {
                _tariff.Name = tbTariff.Text;
                _tariff.PricePerMinute = (double)pricePerMinute.Value;
                if (_op.Tariffs.Contains(_tariff))
                {
                    Close();
                    return;
                }
                _op.AddTariff(_tariff);
                Close();
            }else
            {
                MessageBox.Show("Enter the full information!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(tbTariff.Name =="" || pricePerMinute.Value == 0)
            {
                Tariff.Items.Remove(_tariff);
            }
            Close();
        }
    }
}
