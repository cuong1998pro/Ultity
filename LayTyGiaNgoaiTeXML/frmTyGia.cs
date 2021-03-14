using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace LayTyGiaNgoaiTeXML
{
    public partial class frmTyGia : Form
    {
        public frmTyGia()
        {
            InitializeComponent();
        }

        private void frmTyGia_Load(object sender, EventArgs e)
        {
            DataTable result = new DataTable();
            result.Columns.Add("CurrencyCode");
            result.Columns.Add("CurrencyName");
            result.Columns.Add("Buy");
            result.Columns.Add("Transfer");
            result.Columns.Add("Sell");

            XmlDocument xml = new XmlDocument();
            xml.Load("https://portal.vietcombank.com.vn/Usercontrols/TVPortal.TyGia/pXML.aspx?b=68");
            XmlNodeList tyGiaXML = xml.SelectNodes("/ExrateList/Exrate");

            foreach (XmlNode item in tyGiaXML)
            {
                string currencyCode = item.Attributes["CurrencyCode"].InnerText;
                string currencyName = item.Attributes["CurrencyName"].InnerText;
                string buy = item.Attributes["Buy"].InnerText;
                string transfer = item.Attributes["Transfer"].InnerText;
                string sell = item.Attributes["Sell"].InnerText;
                result.Rows.Add(currencyCode, currencyName, buy, transfer, sell);
            }
            dgvTyGia.DataSource = result;
        }
    }
}