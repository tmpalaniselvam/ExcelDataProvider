using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Runtime.InteropServices;
using Calculator;

namespace Calculator.Tests
{

    /// <summary>
    ///  Class for testing Calculator class
    /// </summary>
    /// <remarks>
    /// This file is developed for demo purpose of ExcelDataProvider.
    /// </remarks>
    [TestFixture]
    public class TestOperations
    {
        private Calculator instance;
        [SetUp]
        public void Setup()
        {
            instance = new Calculator();
        }

        /// <summary>
        /// Test Subtraction operation
        /// </summary>
        [Test]
        [TestCaseSource("ExcelDataProvider")]
        public void TestSubtraction(Dictionary<string, string> data)
        {
            int Num1 = Convert.ToInt32(data["Number1"]);
            int Num2 = Convert.ToInt32(data["Number2"]);
            int ExpResult = Convert.ToInt32(data["Result"]);

            int ActualResult;

            ActualResult = instance.Subtract(Num1, Num2);
            Assert.AreEqual(ExpResult, ActualResult, "Calcualtor Substraction validation");
        }

        /// <summary>
        /// Excel Data Provider - Will read the Excel contents based on file & sheet No
        /// </summary>
        public static List<Dictionary<string, string>> ExcelDataProvider()
        {
            List<Dictionary<string, string>> data = new List<Dictionary<String, String>>();
            int iRow, iUsedRow;
            int iCol, iUsedCol;
            string sValue;
            string ExcelFilePath;
            int iSheetNo;

            // Test data
            ExcelFilePath = @"C:\Demo\ExcelDataProvider\Calculator.Tests\TestData\subtract.xlsx";
            iSheetNo = 1;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ExcelFilePath);
            Microsoft.Office.Interop.Excel.Worksheet xlSheet = xlWorkbook.Worksheets[iSheetNo];
            Microsoft.Office.Interop.Excel.Range xlUsedRange = xlSheet.UsedRange;

            iUsedCol = xlUsedRange.Columns.Count;
            iUsedRow = xlUsedRange.Rows.Count;


            for (iRow = 1; iRow <= iUsedRow; iRow++)
            {
                Dictionary<string, string> rowData = new Dictionary<string, string>();
                for (iCol = 1; iCol <= iUsedCol; iCol++)
                {
                    if (xlUsedRange.Cells[iRow, iCol] != null)
                    {
                        var Value = xlUsedRange.Cells[iRow, iCol].Value;
                        sValue = Convert.ToString(Value);
                        Console.WriteLine("value:" + sValue);

                    }
                    else
                    {
                        sValue = "";
                    }
                    rowData.Add(xlUsedRange.Cells[1, iCol].Value, sValue);

                }
                data.Add(rowData);
            }

            // Console.WriteLine("Excel data:" + data.ToString());

            // Release all COM objects
            Marshal.ReleaseComObject(xlUsedRange);
            Marshal.ReleaseComObject(xlSheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            return data;
        }
    }
}
