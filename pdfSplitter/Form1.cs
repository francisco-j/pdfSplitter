using System;
using System.IO;
using iTextSharp;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace pdfSplitter
{
    public partial class Form1 : Form
    {

#region constructor

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDestino.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Path.Combine(sourceFolder, "TestOutput.pdf")
        }

        #endregion

#region metodos

        //asdasd

        #endregion

#region eventos

        private void btnBuscarOrigen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblOrigen.Text = openFileDialog.FileName;
            }
        }

        private void btnBuscarDestino_Click(object sender, EventArgs e)
        {
            
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                lblDestino.Text = folderBrowserDialog.SelectedPath;
            }
                
        }

        private void btnAgregarR_Click(object sender, EventArgs e)
        {
            Rango rango = new Rango( (int)upDnInicioRango.Value, (int)upDnFinRango.Value );
            lstbxRango.Items.Add(rango);
        }

        #endregion

        //***********************************************************************************

        public void removePagesFromPdf(String sourceFile, String destinationFile, Rango[] pagesToKeep)
        {
            //Used to pull individual pages from our source
            PdfReader reader = new PdfReader(sourceFile);

            //Create our destination file
            FileStream fStream = new FileStream(destinationFile, FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, fStream);

            //Open the desitination for writing
            doc.Open();

            //Loop through each page that we want to keep
            foreach (int page in pagesToKeep)
            {
                //Add a new blank page to destination document
                doc.NewPage();
                //Extract the given page from our reader and add it directly to the destination PDF
                writer.DirectContent.AddTemplate(writer.GetImportedPage(reader, page), 0, 0);
            }
            //Close our document
            doc.Close();

        }
        
    }
}