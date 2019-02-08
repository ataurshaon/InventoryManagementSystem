using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventorySystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.ShowDialog();
        }

        private void addUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.ShowDialog();
        }

        private void addProductNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.ShowDialog();
        }

        private void delaerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.ShowDialog();
        }

        private void purchaseProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8();
            a.ShowDialog();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            a.ShowDialog();
        }
    }
}
