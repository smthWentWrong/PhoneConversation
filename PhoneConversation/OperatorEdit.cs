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
    public partial class OperatorEdit : Form
    {
        Operator _op;
        public OperatorEdit(Operator op)
        {
            InitializeComponent();

            foreach (var el in Operator.Items)
            {
                cbNumbId.Items.Add(el.NumbId);
            }
            _op = op;
            if (_op == null)
            {
                _op = new Operator(null);
            }
            else
            {
                tbOperator.Text = _op.Name;
                cbNumbId.Text = _op.NumbId;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _op.Name = tbOperator.Text;
            _op.NumbId = cbNumbId.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
