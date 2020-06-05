//Udisteanu Iulian-Elisei grupa 3123
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaWindowsForm
{
    public partial class FiltrareData : Form
    {
        public DateTime Dela { get; set; }
        public DateTime PanaLa { get; set; }
        public FiltrareData()
        {
            InitializeComponent();
        }

        private void dataDela_ValueChanged(object sender, EventArgs e)
        {
            Dela = dataDela.Value;
        }

        private void dataPanaLa_ValueChanged(object sender, EventArgs e)
        {
            PanaLa = dataPanaLa.Value;
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            Dela = dataDela.Value;
            PanaLa = dataPanaLa.Value;
        }
    }
}
