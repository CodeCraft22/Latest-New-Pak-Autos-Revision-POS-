using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.PdfViewer.Forms;
using System.IO;


namespace Csharp_Project
{
    public partial class Form1 : Form
    {
        public Form1(string fileName, int flagIdentifier)
        {
            InitializeComponent();

            if (flagIdentifier == 2)
            {

                string pdfDoc = @"D:\Invoice Returns\" + fileName + ".PDF";

                if (File.Exists(pdfDoc))
                {
                    pdfviewerss.src = pdfDoc;

                }
            }
            else
            {
                string pdfDoc = @"D:\Invoice Generate\" + fileName + ".PDF";

                if (File.Exists(pdfDoc))
                {
                    pdfviewerss.src = pdfDoc;

                }

            }


        }
    }
}
