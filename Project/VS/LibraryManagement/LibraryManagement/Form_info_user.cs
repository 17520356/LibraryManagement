using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Form_info_user : Form
    {
        public Form_info_user()
        {
            InitializeComponent();
        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
