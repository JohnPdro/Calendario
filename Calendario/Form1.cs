using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionarData_Click(object sender, EventArgs e)
        {
            txtDataInicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            txtDataFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            txtDataAtual.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDataInicial.Clear();
            txtDataFinal.Clear();
            txtDataAtual.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
