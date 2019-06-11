using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Name : Form
    {
        public string name;
        public Name()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(tbName.Text == "")
            {
                errorProvider.SetError(tbName, "Please enter your name!");
            }
            else
            {
                errorProvider.SetError(tbName, null);
                name = tbName.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
