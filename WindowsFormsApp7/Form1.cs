using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Btn_oblicz_Click(object sender, EventArgs e)
        {
            var successL = double.TryParse(txt_liczba.Text, out double liczba1);
            
            var successP = double.TryParse(txt_potega.Text, out double liczba2);
           
            CheckParse(successL);
            CheckParse(successP);

           if(successL & successP)
            {
                double potega = Math.Pow(liczba1, liczba2);
                txt_wynik.Text = $"{potega}";
            }


        }
        private static void CheckParse(bool success)
        {
            if (!success)
            {
                MessageBox.Show("Błędne dane...");
            }
        }

    }
}
