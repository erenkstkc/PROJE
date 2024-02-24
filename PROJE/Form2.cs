using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace PROJE
{
    public partial class Form2 : Form
    {

        
        public Form2()
        {
            InitializeComponent();
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "Ready-Fight-_Street-Fighter_-Ses-Efekti-_HD_.wav";
            ses.Play();
            
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }

    }
}
