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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxNaslov2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();
            form.ShowDialog();

            this.Close();   
        }

        private void pictureBoxCategories_Click(object sender, EventArgs e)
        {
            FormCategory form = new FormCategory(); 
            form.ShowDialog();

            Form1 form1 = new Form1();
            form1.Close();
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
      
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
