using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class ReportGenerator
    {
        private string excelFilePath;

        public ReportGenerator(string excelFilePath)
        {
            checkValidationFor(excelFilePath);

            this.excelFilePath = excelFilePath;
        }

        private void checkValidationFor(string excelFilePath)
        {
            //checkIsEmpty(excelFilePath);

            ArgumentNullException.ThrowIfNullOrEmpty(excelFilePath, paramName:nameof(excelFilePath));


            fileisExist(excelFilePath);
            validateFormat(excelFilePath);
        }

        private void validateFormat(string excelFilePath)
        {
            var randomNumber = new Random().Next(0, 2);
            var isValidFormat = Convert.ToBoolean(randomNumber);

            if (!isValidFormat)
            {
                throw new InvalidOperationException("Excel dosyası doğru formatta değil");
            }
          
        }

        private static void fileisExist(string excelFilePath)
        {
            if (!File.Exists(excelFilePath))
            {
                throw new FileNotFoundException("Belirtilen dosya bulunamadı");
            }


        }

        //private static void checkIsEmpty(string excelFilePath)
        //{
        //    if (string.IsNullOrEmpty(excelFilePath))
        //    {
        //        throw new ArgumentNullException(nameof(excelFilePath));
        //    }
        //}
    }
}
