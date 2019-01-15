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
    public partial class Calling : Form
    {
        Call _call;
        public Calling(Call call)
        {
            InitializeComponent();
            _call = call;
        }

        private void Calling_Shown(object sender, EventArgs e)
        {
            label1.Text = _call.Caller.ToString() + "\n calling ... \n" + _call.Callee.ToString();
            Block bl = _call.DoBlock();
            if (bl != null)
            {
                MessageBox.Show(bl.ToString());
                Close();
            }

        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            _call.EndCall();
            Close();
        }
    }
}
