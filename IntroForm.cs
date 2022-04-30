using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IGN
{
    public partial class IntroForm : Form
    {
        Thread th;
        public IntroForm()
        {
            InitializeComponent();
            
               
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            /*
            DataBaseForm f2 = new DataBaseForm(); 
            f2.ShowDialog(); 
           */
        }

        private void opennewform(object obj)
        {
            Application.Run(new DataBaseForm());

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
