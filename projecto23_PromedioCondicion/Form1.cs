using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecto23_PromedioCondicion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            int nota01, nota02, nota03;

            nota01 = int.Parse(txt_Nota01.Text);
            nota02 = int.Parse(txt_Nota02.Text);
            nota03 = int.Parse(txt_Nota03.Text);
            double promedio;
            promedio = (nota01 + nota02 + nota03) / 3.0;

            txt_Promedio.Text = promedio.ToString();


        }
    }
}
