using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelTransfer.Classes;

namespace ExcelTransfer
{
    public partial class Form1 : Form
    {
        DBConnector dBConnector;
        String filePath;
        ExcelReader excelReader;

        public Form1()
        {
            dBConnector = new DBConnector();
            excelReader = new ExcelReader();
            InitializeComponent();
            radioConnectSQLChanger();
            radioConnectExcelChanger();
        }

        void radioConnectSQLChanger()
        {
            if (dBConnector.getIsConnected())
            {
                fConnection.Checked = true;
                fConnection.BackColor = Color.Green;
            }
            else
            {
                fConnection.Checked = false;
                fConnection.BackColor = Color.Red;
            }
           
        }

  




        private void fGetStyleSheet_Click(object sender, EventArgs e)
        {

            getXLSXFileFromDialog(out filePath);
            excelReader.setWorkSheetFile(filePath);
            fStyleSheetLoc.Text = filePath;
            radioConnectExcelChanger();
            if (excelReader.getIsConnected())
            {
                setComboSheetsNames();
            }

   
        }

        void setComboSheetsNames()
        {
            foreach(String name in excelReader.getAllWorksheetNames())
            {
                fSheetNames.Items.Add(name);
            }
            fSheetNames.SelectedIndex = 0;
        }
        void radioConnectExcelChanger()
        {
            if (excelReader.getIsConnected())
            {
                fExcelConnector.Checked = true;
                fExcelConnector.BackColor = Color.Green;
            }
            else
            {
                fExcelConnector.Checked = false;
                fExcelConnector.BackColor = Color.Red;
            }

        }


        private void getXLSXFileFromDialog(out String filePath)
        {
            filePath = "";
            var fileContent = string.Empty;
            openFileDialog1.Filter = "stylesheet files (*.xlsx)|*.xlsx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();

                }


            }
        }

        private void fStyleSheetLoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void fConnection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void komunikaty_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dBConnector.isTableExists(fSheetNames.Text).ToString());
        }
    }
}
