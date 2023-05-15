using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotrosnjaAppV3
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            Form1 form= new Form1();    
            form.ShowDialog();
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            FormAdd form= new FormAdd();    
            form.ShowDialog();  
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
