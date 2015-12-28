using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilityApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetIMDBLink_Click(object sender, EventArgs e)
        {
            try
            {
                IMDBHelper helper = new IMDBHelper();
                string link = helper.GetIMDBLinkByTitle(txtTitle.Text);
                txtResult.Text = link;
                // lblMessage.Text = link;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
