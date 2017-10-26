using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp;

namespace pdfSplitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarOrigen_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void btnBuscarDestino_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarR_Click(object sender, EventArgs e)
        {

        }
    }
}
