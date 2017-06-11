using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFramework.Helpers
{
    public class ExcelHelper
    {
        private static DataTable ExcelToDataTable(string fileName)
        {
            //open file return as stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //CreateOpenXmlReader <= .xlsx
            //CreateBinaryReader <= .xls
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //set first row as column name
            excelReader.IsFirstRowAsColumnNames = true;
            //return as DataSet
            DataSet result = excelReader.AsDataSet();
            //get all the  tables
            DataTableCollection table = result.Tables;
            //store it in DataTable
            DataTable resultTable = table["Sheet1"];
            //result
            return resultTable;
        }
    }
}
