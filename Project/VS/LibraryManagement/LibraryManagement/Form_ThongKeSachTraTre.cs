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
    public partial class Form_ThongKeSachTraTre : Form
    {
        public Form_ThongKeSachTraTre()
        {
            InitializeComponent();
        }

        private void Form_ThongKeSachTraTre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LibraryManagementDataSet.DOC_GIA' table. You can move, or remove it, as needed.
            this.DOC_GIATableAdapter.Fill(this.LibraryManagementDataSet.DOC_GIA);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ThongKeSachTraTre_Load(null,null);
        }
    }
}
