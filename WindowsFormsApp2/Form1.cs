using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //StringBuilder text = new StringBuilder();
            //using (PdfReader reader = new PdfReader("D:\\Book1.pdf"))
            //{
            //    for (int i = 1; i <= reader.NumberOfPages; i++)
            //    {
            //        text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
            //    }
            //}
            //string t = text.ToString();

            //text = new StringBuilder();
            //using (PdfReader reader = new PdfReader("D:\\Book2.pdf"))
            //{
            //    for (int i = 1; i <= reader.NumberOfPages; i++)
            //    {
            //        text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
            //    }
            //}
            //t = text.ToString();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder text = new StringBuilder();
                using (PdfReader reader = new PdfReader(openFileDialog1.FileName))
                {
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                    }
                }
                string t = text.ToString();
            }
        }
       
    }
}
