using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerExcelFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Temp\\ArchivoExcel.xls; Extended Properties='Excel 8.0;HDR=NO;IMEX=1;'";
            string connString = "Provider= Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:\\Temp\\ArchivoExcel.xlsx" + ";Extended Properties='Excel 8.0;HDR=Yes'";

        }
    }
}
