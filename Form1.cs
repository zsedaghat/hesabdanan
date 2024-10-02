//using DocumentFormat.OpenXml.Spreadsheet;
using ExcelDataReader;
using Hesabdanan.Model;
using Microsoft.AspNetCore.Http;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Hesabdanan
{
    public partial class Form1 : Form

    {
        public List<BankList> bankList = new List<BankList>();
        public List<SellerList> sellerList = new List<SellerList>();


        public Form1()
        {
            InitializeComponent();
        }

        private void UploadBank_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                IExcelDataReader excelReader = null;
                DataTable dataTable = null;
                var stream = dialog.OpenFile();
                excelReader = ExcelReaderFactory.CreateReader(stream);
                var rowCount = excelReader.RowCount;
                for (int i = 1; i <= rowCount; i++)
                {
                    try
                    {
                        while (excelReader.Read()) //Each row of the file
                        {
                            bankList.Add(new BankList
                            {
                                InvoiceNumber = excelReader.GetValue(0).ToString(),
                                Date = excelReader.GetValue(1).ToString(),
                                price = excelReader.GetValue(2).ToString(),
                                RemainAmount = excelReader.GetValue(2).ToString(),
                            });

                        }
                    }
                    catch (Exception eg)
                    {
                        var hh = i.ToString();
                        throw;
                    }


                }

            }

        }

        private void UploadSeller_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                IExcelDataReader excelReader = null;
                DataTable dataTable = null;
                var stream = dialog.OpenFile();
                excelReader = ExcelReaderFactory.CreateReader(stream);
                var rowCount = excelReader.RowCount;
                for (int i = 1; i <= rowCount; i++)
                {
                    while (excelReader.Read()) //Each row of the file
                    {
                        sellerList.Add(new SellerList
                        {
                            PId = excelReader.GetValue(0)?.ToString(),
                            Date = excelReader.GetValue(1)?.ToString(),
                            ProductId = excelReader.GetValue(2)?.ToString(),
                            ProductName = excelReader.GetValue(3)?.ToString(),
                            Count = excelReader.GetValue(4)?.ToString(),
                            UnitPrice = excelReader.GetValue(5)?.ToString(),
                            NewCount = excelReader.GetValue(4)?.ToString(),
                        });
                    }
                }
            }
        }

        private void calculation_Click(object sender, EventArgs e)
        {
            bankList.RemoveAt(0);
            sellerList.RemoveAt(0);
            var resultList = new List<Result>();

            //var unitPriceList = sellerList.Select(w => long.Parse(w.UnitPrice));
            foreach (var item in bankList)
            {
                var unitPriceList = sellerList.Where(w => long.Parse(w.NewCount) > 0).Select(w => long.Parse(w.UnitPrice));
                var isCountinue = unitPriceList.Where(x => x <= long.Parse(item.RemainAmount)).Any();

                if (isCountinue)
                {
                    for (int i = 0; i < sellerList.Count; i++)
                    {
                        try
                        {
                            if (long.Parse(sellerList[i].NewCount) > 0)
                            {
                                if (isCountinue)
                                {
                                    try
                                    {
                                        var bCount = (long.Parse(item.RemainAmount) / long.Parse(sellerList[i].UnitPrice));
                                        if (bCount < 1)
                                        {

                                            continue;
                                        }
                                        var totalPrice = long.Parse(sellerList[i].Count) * long.Parse(sellerList[i].UnitPrice);
                                        if (bCount <= long.Parse(sellerList[i].NewCount))
                                        {
                                            resultList.Add(new Result
                                            {
                                                InvoiceNumber = item.InvoiceNumber,
                                                PoductId = sellerList[i].ProductId,
                                                ProductName = sellerList[i].ProductName,
                                                SellCount = bCount,
                                                SellUnitPrice = sellerList[i].UnitPrice,
                                                SellAmount = long.Parse(sellerList[i].UnitPrice) * bCount,
                                            });
                                            item.RemainAmount = ((long.Parse(item.RemainAmount)) - long.Parse(sellerList[i].UnitPrice) * bCount).ToString();
                                            sellerList[i].NewCount = (long.Parse(sellerList[i].NewCount) - bCount).ToString();
                                        }
                                        else /*(bCount > long.Parse(sellerList[i].NewCount))*/
                                        {
                                            resultList.Add(new Result
                                            {
                                                InvoiceNumber = item.InvoiceNumber,
                                                PoductId = sellerList[i].ProductId,
                                                ProductName = sellerList[i].ProductName,
                                                SellAmount = (long.Parse(sellerList[i].UnitPrice)) * (long.Parse(sellerList[i].NewCount)),
                                                SellCount = long.Parse(sellerList[i].NewCount),
                                                SellUnitPrice = sellerList[i].UnitPrice,
                                            });
                                            item.RemainAmount = ((long.Parse(item.RemainAmount)) - long.Parse(sellerList[i].UnitPrice) * long.Parse(sellerList[i].NewCount)).ToString();
                                            sellerList[i].NewCount = (long.Parse(sellerList[i].NewCount) - long.Parse(sellerList[i].NewCount)).ToString();
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        var hh = "jdj";
                                        throw new Exception(sellerList[i].PId);
                                    }
                                }
                            }
                        }
                        catch (Exception EX)
                        {
                            var hh = "jdj";
                            throw new Exception(sellerList[i].PId);
                        }
                    }

                }
            }

            WriteResultToExcel(resultList,sellerList);
            MessageBox.Show("D با نام Result  ذخیره شد در درایو ");
        }

        public void WriteResultToExcel(List<Result> result,List<SellerList> sellerLists)
        {
            Workbook workbook = new Workbook();

            // Remove default worksheets
            workbook.Worksheets.Clear();

            // Add a worksheet and name it
            Worksheet worksheet = workbook.Worksheets.Add("Result");
            Worksheet worksheet1 = workbook.Worksheets.Add("New Seller");
            // Convert the list to DataTable
            DataTable resultDataTable = ConvertResultToDataTable(result);
            DataTable newSellerDataTable = ConvertNewSellerToDataTable(sellerList);


            // Write datatable to the worksheet
            worksheet.InsertDataTable(resultDataTable, true, 1, 1, true);
            worksheet1.InsertDataTable(newSellerDataTable,true, 1, 1, true);

            // Set column width
            worksheet.AllocatedRange.ColumnWidth = 12;
            worksheet1.AllocatedRange.ColumnWidth = 12;

            // Align content to left
            worksheet.AllocatedRange.HorizontalAlignment = HorizontalAlignType.Left;
            worksheet1.AllocatedRange.HorizontalAlignment = HorizontalAlignType.Left;


            // Save to an Excel file
            workbook.SaveToFile(@"D:\Result.xls", ExcelVersion.Version2016);
          
            // Dispose resources
            workbook.Dispose();


        }

        static DataTable ConvertResultToDataTable(List<Result> results)
        {
            DataTable dataTable = new DataTable();

            // Add columns
            dataTable.Columns.Add("InvoiceNumber", typeof(string));
            dataTable.Columns.Add("PoductId", typeof(string));
            dataTable.Columns.Add("SellCount", typeof(int));
            dataTable.Columns.Add("SellAmount", typeof(string));
            dataTable.Columns.Add("SellUnitPrice", typeof(decimal));
            dataTable.Columns.Add("ProductName", typeof(string));


            // Add rows
            foreach (var result in results)
            {
                DataRow row = dataTable.NewRow();
                row["InvoiceNumber"] = result.InvoiceNumber;
                row["PoductId"] = result.PoductId;
                row["SellCount"] = result.SellCount;
                row["SellAmount"] = result.SellAmount;
                row["SellUnitPrice"] = result.SellUnitPrice;
                row["ProductName"] = result.ProductName;

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        static DataTable ConvertNewSellerToDataTable(List<SellerList> sellerLists)
        {
            DataTable dataTable = new DataTable();

            // Add columns
            dataTable.Columns.Add("PId", typeof(string));
            dataTable.Columns.Add("Date", typeof(string));
            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("Count", typeof(string));
            dataTable.Columns.Add("UnitPrice", typeof(string));
            dataTable.Columns.Add("NewCount", typeof(string));



            // Add rows
            foreach (var seller in sellerLists)
            {
                DataRow row = dataTable.NewRow();
                row["PId"] = seller.PId;
                row["Date"] = seller.Date;
                row["ProductId"] = seller.ProductId;
                row["ProductName"] = seller.ProductName;
                row["Count"] = seller.Count;
                row["UnitPrice"] = seller.UnitPrice;
                row["NewCount"] = seller.NewCount;


                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }

   
}
