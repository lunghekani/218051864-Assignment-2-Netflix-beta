using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;


namespace _218051864_Assignment_2_Netflix_beta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsMovieOperations objMovie = new clsMovieOperations();
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                comboBox1.Items.Clear();

            clsMovieOperations obj = new clsMovieOperations();

            obj.PopulateContentLists();
            var lst = objMovie.PopulateContentLists();
            foreach (var item in lst)
            {
                comboBox1.Items.Add(item);
                
            }
        }
    }
}
