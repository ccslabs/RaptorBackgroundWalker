using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaptorBackground.Forms
{
    public partial class frmHashString : Form
    {
        public frmHashString()
        {
            InitializeComponent();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            lblResult.Text = Classes.Hashing.HashString(tbStringToHash.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result";
            tbStringToHash.Text = "";
        }
    }
}
