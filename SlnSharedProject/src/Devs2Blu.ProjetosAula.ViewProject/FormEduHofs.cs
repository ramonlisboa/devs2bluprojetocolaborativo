using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.ViewProject
{
    public partial class FormEduHofs : Form
    {
        public FormEduHofs()
        {
            InitializeComponent();
        }

        private void buttonLigaDesliga_Click(object sender, EventArgs e)
        {
            labelEduHofs.ForeColor = Color.Red;
            buttonLigaDesliga.Text = "I";
            Thread.Sleep(10000);
            labelEduHofs.ForeColor = Color.Green;
            buttonLigaDesliga.Text = "O";

        }
    }
}
