using System;
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