//// ----------------------------------------------------------------------------
//// Título:    Generar PDF desde HTML
////
//// Fecha:     22/06/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//                                                     using System.IO;
//using iTextSharp.text;
//using iTextSharp.text.html.simpleparser;
//using iTextSharp.text.pdf;

//string file = @"C:\Windows\Temp\Documento.pdf";

//string html = "<html><head></head><body>" +
//    "<img alt=\"Logo iText\" src=\"http://itextpdf.com/img/logo.gif\" height=\"50px\" width=\"50px\">" +
//    "<br>GeneraciÃ³n de PDF desde HTML con <b>iTextSharp</b>." +
//    "</body></html>";

//Document document = new Document(PageSize.A4, 80, 50, 30, 65);
//PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
//document.Open();

//foreach (IElement E in HTMLWorker.ParseToList(new StringReader(html), new StyleSheet()))
//    document.Add(E);

//document.Close();
