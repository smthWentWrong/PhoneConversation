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
    public partial class Operators : Form
    {
        public Operators()
        {
            InitializeComponent();
        }

        private void Operators_Load(object sender, EventArgs e)
        {
            lbOperators.DataSource = Operator.Items;
            lbOperatorsTariffs.DataSource = ((Operator)lbOperators.SelectedItem).Tariffs;
        }

        private void btnAddOp_Click(object sender, EventArgs e)
        {
            new OperatorEdit(null).ShowDialog();
            RefreshOperators();
        }
        private void RefreshOperators()
        {
            lbOperators.DataSource = null;
            lbOperators.DataSource = Operator.Items;
        }

        private void btnDelOp_Click(object sender, EventArgs e)
        {
            Operator.Items.Remove((Operator)lbOperators.SelectedItem);
            RefreshOperators();
        }

        private void btnChangeOp_Click(object sender, EventArgs e)
        {
            new OperatorEdit((Operator)lbOperators.SelectedItem).ShowDialog();
            RefreshOperators();
        }
        /// <summary>
        /// for
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbOperators_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTariffs();
        }
        private void RefreshTariffs()
        {
            lbOperatorsTariffs.DataSource = null;
            if(((Operator)lbOperators.SelectedItem) != null)
                lbOperatorsTariffs.DataSource = ((Operator)lbOperators.SelectedItem).Tariffs;
        }

        private void btnAddTar_Click(object sender, EventArgs e)
        {
            new TariffEdit(null,(Operator)lbOperators.SelectedItem).ShowDialog();
            RefreshTariffs();
        }

        private void btnDelTar_Click(object sender, EventArgs e)
        {
            ((Operator)lbOperators.SelectedItem).DeleteTariff((Tariff)lbOperatorsTariffs.SelectedItem);
            RefreshTariffs();
        }

        private void btnChangeTar_Click(object sender, EventArgs e)
        {
            new TariffEdit((Tariff)lbOperatorsTariffs.SelectedItem, (Operator)lbOperators.SelectedItem).ShowDialog();
            RefreshTariffs();
        }
    }
}

