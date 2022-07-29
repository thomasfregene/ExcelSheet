using OfficeOpenXml;
using System;
using System.IO;

namespace ExcelDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            var file = new FileInfo(@"C:\Demo\ExcelYoutubeDemo.xlsx");
        }
    }
}
