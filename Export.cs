using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace WindowsFormsApplication1
{
    class Export
    {
        public void ExportSouboru()
        {
            string  jmeno = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string cesta = @"C:\Users\Vávra\Documents\Visual Studio 2015\Projects\WindowsFormsApplication1\WindowsFormsApplication1\"+jmeno+".txt";

            if(!File.Exists(cesta))
            {
                File.Create(cesta).Dispose();
                using (TextWriter tw = new StreamWriter(cesta))
                {
                    tw.WriteLine("Zkušební text");
                    tw.Close();
                }
            }
        }

        public void ExportDoPDF()
        {
            string jmeno = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            Document doc = new Document(iTextSharp.text.PageSize.A4);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(jmeno+".pdf", FileMode.Create));
            doc.Open();

            PdfPTable tabulka = new PdfPTable(2);
            tabulka.AddCell("");
            tabulka.AddCell("Zalohova faktura\nCislo: xxx");
            tabulka.AddCell("Nazev spolecnosti \nSidlo spolecnost \nOstatni informace");
            tabulka.AddCell("Nazev nasi spolecnosti \nSidlo spolecnost \nOstatni informace");
            tabulka.AddCell("Zpusob uhrady: \nPenezni ustav: \nCislo uctu: \n\nVariabilni symbol: \nKonstatni symbol: \nSpecificky symbol: ");
            tabulka.AddCell("Datum vystaveni: \nDatum splatnosti: ");
            doc.Add(tabulka);

            PdfPTable zbozi = new PdfPTable(7);
            zbozi.AddCell("Nazev polozky");
            zbozi.AddCell("Mnozstvi");
            zbozi.AddCell("Jednotka");
            zbozi.AddCell("Cena polozky bez DPH");
            zbozi.AddCell("DPH %");
            zbozi.AddCell("Cena polozky s DPH");
            zbozi.AddCell("Celkem s DPH");
            doc.Add(zbozi);

            PdfPTable paticka = new PdfPTable(2);
            paticka.AddCell("Poznamka: \nDekujeme za spolupraci.");
            paticka.AddCell("SUma bez DPH: xxx\nDPH 21%: xxx\nDPH Celkem: xxx\nCELKEM: xxx");
            doc.Add(paticka);

            doc.Close();
        }
    }
}
