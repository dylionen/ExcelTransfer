using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTransfer.Classes
{
    class ExcelReader
    {
        private bool isConnected;
        private ExcelPackage package;
        private ExcelWorksheet excelWorksheet;

        public ExcelReader()
        {
            isConnected = false;
        }

        private void setIsConnected(bool connected)
        {
            isConnected = connected;
        }

        public bool getIsConnected()
        {
            return isConnected;
        }

        public void setWorkSheetFile(String localization)
        {
            try
            {
                package = new ExcelPackage(new FileInfo(localization));
            }
            catch (Exception e)
            {
                setIsConnected(false);
                return;
            }
            setIsConnected(true);
        }

        public List<String> getAllWorksheetNames()
        {
            List<String> list= new List<String>();

            foreach (var sheet in package.Workbook.Worksheets)
            {
                list.Add(sheet.Name);
            }
            return list;
        }


    }
}
