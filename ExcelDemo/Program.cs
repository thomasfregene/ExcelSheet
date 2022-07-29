using OfficeOpenXml;
using System;
using System.IO;

namespace ExcelDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            var file = new FileInfo(@"C:\Demo\ExcelYoutubeDemo.xlsx");
        }
    }
}
