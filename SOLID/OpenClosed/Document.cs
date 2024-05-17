using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    /*
     * PDF, Word, Excel
     */

    //public enum DocumentType
    //{
    //    PDF,
    //    Word,
    //    Excel,
    //    PPT
    //}

    public interface DocumentType
    {
        public void Save();
     
    }

    public class PDFDocument : DocumentType
    {
        public void Save()
        {
            Console.WriteLine("PDF sunucusuna kaydedildi");
        }
    }

    public class WordDocument : DocumentType
    {
        public void Save()
        {
            Console.WriteLine("Word sunucusuna kaydedildi");
        }
    }

    public class ExcelDocument : DocumentType
    {
        public void Save()
        {
            Console.WriteLine("Excel sunucusuna kaydedildi");
        }
    }

    public class PPTDocument : DocumentType
    {
        public void Save()
        {
            Console.WriteLine("Powerpoint sunucusuna kaydedildi");

        }
    }

    public class Document
    {
        public string Title { get; set; }
        public DocumentType Type { get; set; }
    }
    public class DocumentStorageManager
    {

        public void ArchiveToServer(Document document)
        {

            //switch (document.Type)
            //{
            //    case DocumentType.PDF:
            //        Console.WriteLine("PDF sunucusuna kaydedildi");
            //        break;
            //    case DocumentType.Word:
            //        Console.WriteLine("Word sunucusuna kaydedildi");

            //        break;
            //    case DocumentType.Excel:
            //        Console.WriteLine("Excel sunucusuna kaydedildi");

            //        break;
            //    case DocumentType.PPT:
            //        Console.WriteLine("PPT sunucusuna kaydedildi");
            //        break;
            //    default:
            //        break;
            //}

            //Öyle bir yapı belirle ki ArchiveToServer fonksiyonu hiç değişmesin:

            document.Type.Save();
           


        }
    }
}
