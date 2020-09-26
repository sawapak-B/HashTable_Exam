using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Exam_003
{
    public partial class Form1 : Form
    {
        Hashtable  hashtable;

        public Form1()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtInDex.Text != "" & txtValues.Text != "")
            {
                hashtable.Add(txtInDex.Text, txtValues.Text);
                txtValues.Text = "";
                txtInDex.Text = "";

            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (txtInDex.Text != "")
            {
                hashtable.Remove(txtInDex.Text);
                txtValues.Text = "";
                txtInDex.Text = "";
            }
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            ICollection iCollect = hashtable.Keys;

            foreach (string index in iCollect)
            {
                MessageBox.Show(hashtable[index].ToString());
            }
        }
    }
}
