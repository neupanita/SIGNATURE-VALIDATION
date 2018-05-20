using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace SignatureValidationApplication
{

    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();
        }

        private void btBrowseResult_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.csv";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Display the file name and location
                tbresult.Text = openFileDialog.FileName;
            }
        }
        private void btUpload_Click(object sender, EventArgs e)
        {
            try
            {
                dgCSVData.DataSource = GetDataTableFromCSVFile(tbresult.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Import CSV File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static DataTable GetDataTableFromCSVFile(string csvfilePath)
        {
            DataTable csvData = new DataTable();
            DataTable dataTable = new DataTable();
            StreamReader streamReader = new StreamReader(csvfilePath);
            string[] totalData = new string[File.ReadAllLines(csvfilePath).Length];
            totalData = streamReader.ReadLine().Split(',');
            foreach (string column in totalData)
            {
                DataColumn datecolumn = new DataColumn(column);
                datecolumn.AllowDBNull = true;
                csvData.Columns.Add(datecolumn);
            }
            while (!streamReader.EndOfStream)
            {
                totalData = streamReader.ReadLine().Split(',');
                csvData.Rows.Add(totalData);
            }
            return csvData;
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            dgCSVData.DataSource = null;
            dgRepository.DataSource = null;
        }

        private void btnRepository_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.csv";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Display the file name and location
                tbRepository.Text = openFileDialog.FileName;
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            DataTable dtResult = GetDataTableFromCSVFile(tbresult.Text);
            DataTable dtRepository = GetDataTableFromCSVFile(tbRepository.Text);
            DataTable finalResult = new DataTable();
            finalResult.Columns.Add("FileFolderName");
            finalResult.Columns.Add("SignatureType");
            finalResult.Columns.Add("Signature");
            finalResult.Columns.Add("Result");
            //Leading / Trailing quotation marks should be accounted for in all values 
            const string quote = "\"";
            //	Files and Folder names are case sensitive
            Dictionary<string, string> data = new Dictionary<string, string>();
            for (int i = 0; i < dtResult.Rows.Count; i++)
            {
                string res = getResults(dtRepository, dtResult.Rows[i]["FileFolderName"].ToString(), dtResult.Rows[i]["SignatureType"].ToString(), dtResult.Rows[i]["Signature"].ToString());
                //Leading / Trailing whitespaces should be removed from all values 
                string filefolder = dtResult.Rows[i]["FileFolderName"].ToString().Trim();                
                //Hash values should not contain any white spaces
                string sig = dtResult.Rows[i]["Signature"].ToString().Trim();
                //	Hash values should always be compared in UPPER case
                string signature = sig.Trim().ToUpper();
                string signaturetype = dtResult.Rows[i]["SignatureType"].ToString().Trim();
                finalResult.Rows.Add(quote + filefolder + quote, quote + signaturetype + quote, quote + signature + quote, quote + res + quote);
            }
            dgRepository.DataSource = finalResult;
        }
        
        private string getResults(DataTable dtRepository, string rowResultFile, string signatureType, string signature)
        {
            for (int j = 0; j < dtRepository.Rows.Count; j++)
            {
                if (rowResultFile.Contains(dtRepository.Rows[j]["imageName"].ToString()))
                {
                    switch (signatureType.ToString())
                    {
                        case "SHA1":
                            {
                                return getResult(signatureType, signature, dtRepository.Rows[j]["sigtype1"].ToString(), dtRepository.Rows[j]["sig1"].ToString());
                            }
                        case "MD5":
                            {
                                return getResult(signatureType, signature, dtRepository.Rows[j]["sigtype2"].ToString(), dtRepository.Rows[j]["sig2"].ToString());
                            }
                        case "CRC16":
                            {
                                return getResult(signatureType, signature, dtRepository.Rows[j]["sigtype3"].ToString(), dtRepository.Rows[j]["sig3"].ToString());
                            }
                        case "CRC32":
                            {
                                return getResult(signatureType, signature, dtRepository.Rows[j]["sigtype4"].ToString(), dtRepository.Rows[j]["sig4"].ToString());
                            }
                        case "HMACSHA1":
                            {
                                return getResult(signatureType, signature, dtRepository.Rows[j]["sigtype5"].ToString(), dtRepository.Rows[j]["sig5"].ToString());
                            }
                         default:
                            return "Not Match";
                    }
                }
            }
            return "No File";
        }

        private void txtExport_Click(object sender, EventArgs e)
        {
            //Build the CSV file data as a Comma separated string.
            string csv = string.Empty;
            //Add the Header row for CSV file.
            foreach (DataGridViewColumn column in dgRepository.Columns)
            {
                csv += column.HeaderText + ',';
            }
            //Add new line.
            csv += "\r\n";
            //Adding the Rows
            foreach (DataGridViewRow row in dgRepository.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //Add the Data rows.
                    csv += cell.Value.ToString().Replace(",", ";") + ',';
                }
                //Add new line.
                csv += "\r\n";
            }
            //Exporting to CSV.
            string folderPath = "D:\\";
            File.WriteAllText(folderPath + "DataGridViewExport.csv", csv);
            label3.Text = "File 'DataGridViewExport' Exported Successfully in D Drive ";
        }

        private string getResult(string signatureTypeRes, string signatureRes, string signatureType, string signature)
        {
            if (signatureTypeRes.ToString() == signatureType)
            {
                if (signatureRes.ToString() == signature)
                {
                    return "Match";
                }
                else
                {
                    return "Not Match";

                }
            }
            else
            {
                return "Not Match";
            }
        }
    }
}
             