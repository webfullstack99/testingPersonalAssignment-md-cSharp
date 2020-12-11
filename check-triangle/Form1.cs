using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using check_triangle.Classes;
using T7_2180617_TranHoangAnh.Classes;

namespace check_triangle
{
    public partial class Form1 : Form
    {

        // LISTS
        private List<MoneyInput> doanhThuList;
        private List<MoneyInput> chiPhiDuocTruList;
        private List<MoneyInput> cacKhoanThuNhapKhacList;
        private List<MoneyInput> thuNhapDuocMienThueList;
        private List<MoneyInput> cacKhoanLoList;

        // 
        private CalculateMoney calculateMoney;
        private bool isReportBtnClicked;

        public Form1()
        {
            InitializeComponent();
            onInit();
        }

        private String getFilePath()
        {

            String result = "";
            try
            {
                result = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database\\testing_db.csv");
                result = result.Replace("bin\\Debug", "");
            }
            catch (DirectoryNotFoundException dirEx)
            {
                Console.WriteLine("Directory not found: " + dirEx.Message);
            }
            return result;

        }

        private void onInit()
        {
            doanhThuList = new List<MoneyInput>();
            chiPhiDuocTruList = new List<MoneyInput>();
            cacKhoanThuNhapKhacList = new List<MoneyInput>();
            thuNhapDuocMienThueList = new List<MoneyInput>();
            cacKhoanLoList = new List<MoneyInput>();
            calculateMoney = new CalculateMoney();
            readFile();
        }

        // BTN RESULT CLICK
        private void btnResult_Click(object sender, EventArgs e)
        {
            onShowReport(true);
        }

        private void onShowReport(bool isShowMesage)
        {
            // SET LIST TO CALCULATE
            calculateMoney.setLists(doanhThuList, chiPhiDuocTruList, cacKhoanThuNhapKhacList, thuNhapDuocMienThueList, cacKhoanLoList);
            calculateMoney.calculate();
            List<MoneyOutput> moneyOutputList = calculateMoney.getMoneyOutputList();

            if (moneyOutputList.Count > 0)
            {
                printReportToReportTable(moneyOutputList);
                printReportToReportTextbox(moneyOutputList);
            }
            else if (isShowMesage)
            {
                MessageBox.Show("Vui long dien day du thong tin!");
            }
            isReportBtnClicked = true;
        }

        private void printReportToReportTextbox(List<MoneyOutput> moneylist)
        {
            // CLEAR RESULT LIST
            Txt_Report.Text = "";

            // PRINT
            if (moneylist.Count > 0)
            {
                for (int i = 0; i < moneylist.Count; i++)
                {
                    MoneyOutput moneyOutput = moneylist.ElementAt(i);
                    string nam = moneyOutput.getNam() + "";
                    //string mucThueSuat = (moneyOutput.getMucThueSuat() * 100) + "%";
                    string mucThueSuat = $"{moneyOutput.getMucThueSuat()}";
                    string soTienPhaiDong = $"{moneyOutput.getMoney()}";
                    Txt_Report.AppendText($"{nam}\t{mucThueSuat}\t{soTienPhaiDong}\r\n");

                }
            }
        }
        private void printReportToReportTable(List<MoneyOutput> moneylist)
        {
            // CLEAR RESULT LIST
            lvResult.Items.Clear();

            // PRINT 
            if (moneylist.Count > 0)
            {
                for (int i = 0; i < moneylist.Count; i++)
                {
                    MoneyOutput moneyOutput = moneylist.ElementAt(i);
                    string stt = (i + 1) + "";
                    string nam = moneyOutput.getNam() + "";
                    string mucThueSuat = (moneyOutput.getMucThueSuat() * 100) + "%";
                    string soTienPhaiDong = moneyOutput.getMoney() + " VND";

                    ListViewItem item = new ListViewItem(stt);
                    item.SubItems.Add(nam);
                    item.SubItems.Add(mucThueSuat);
                    item.SubItems.Add(soTienPhaiDong);
                    lvResult.Items.Add(item);
                }
            }
        }

        private void printListsSize()
        {
            Console.WriteLine("\ndoanh thu: " + doanhThuList.Count);
            Console.WriteLine("chi phi: " + chiPhiDuocTruList.Count);
            Console.WriteLine("thu nhap: " + cacKhoanThuNhapKhacList.Count);
            Console.WriteLine("mien thue: " + thuNhapDuocMienThueList.Count);
            Console.WriteLine("lo" + cacKhoanLoList.Count + "\n");
        }

        // RESET LIST
        private void resetLists()
        {
            doanhThuList.Clear();
            chiPhiDuocTruList.Clear();
            cacKhoanThuNhapKhacList.Clear();
            cacKhoanLoList.Clear();
            thuNhapDuocMienThueList.Clear();
        }

        // ON ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Dlg_Data form2 = new Dlg_Data())
            {
                ListView lv = Lst_AllData;

                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // GET DATA
                    ComboBox comboBoxMuc = form2.getComboBoxMuc();
                    List<MoneyInput> moneyList = getListByMuc(getMucArray()[form2.getMucIndex()]);
                    if (moneyList != null)
                    {
                        String mucStr = form2.getMuc();
                        String ngayStr = form2.getNgay();
                        String khoanStr = form2.getKhoan();
                        String moneyStr = form2.getMoney();
                        addToList(true, moneyList, mucStr, ngayStr, khoanStr, moneyStr);
                        calculateAndShowReportsIfPassCondition();
                    }
                }
            }
        }

        private void addToList(bool isWriteToFile, List<MoneyInput> list, String muc, String ngay, String khoan, String money)
        {
            // ADD TO LIST  
            MoneyInput moneyInput = new MoneyInput(ngay, khoan, money);
            list.Add(moneyInput);

            // PRINT OUT TABLE
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(muc);
            item.SubItems.Add(ngay);
            item.SubItems.Add(khoan);
            item.SubItems.Add(money);
            Lst_AllData.Items.Add(item);

            // append to file
            if (isWriteToFile) appendData(getDataLine(muc, ngay, khoan, money));
        }

        // ON REMOVE
        private void btnRemove_MouseClick(object sender, MouseEventArgs e)
        {
            if (Lst_AllData.CheckedItems.Count > 0)
            {
                clearReports();
                int count = Lst_AllData.CheckedItems.Count;
                while (Lst_AllData.CheckedItems.Count > 0)
                {
                    Lst_AllData.CheckedItems[0].Remove();

                }
                updateListsByListView();
                updateFileByListView();
                calculateAndShowReportsIfPassCondition();
            }
        }

        // UPDATE LIST
        private void updateListsByListView()
        {
            // reset 
            resetLists();

            // loop list row
            foreach (ListViewItem itemRow in Lst_AllData.Items)
            {

                // row item
                var item = itemRow.SubItems;

                // get list
                List<MoneyInput> moneyList = getListByMuc(item[1].Text);
                moneyList.Add(new MoneyInput(item[2].Text, item[3].Text, item[4].Text));
            }
        }

        private List<MoneyInput> getListByMuc(String muc)
        {
            List<MoneyInput> list;
            switch (muc)
            {
                case "Doanh Thu":
                    list = doanhThuList;
                    break;
                case "Chi phí được trừ":
                    list = chiPhiDuocTruList;
                    break;
                case "Thu nhập khác":
                    list = cacKhoanThuNhapKhacList;
                    break;
                case "Thu nhập được miễn thuế":
                    list = thuNhapDuocMienThueList;
                    break;
                case "Khoản lỗ":
                    list = cacKhoanLoList;
                    break;
                default:
                    list = doanhThuList;
                    break;
            }
            return list;
        }

        private String[] getMucArray()
        {
            String[] array = { "Doanh Thu", "Chi phí được trừ", "Thu nhập khác", "Thu nhập được miễn thuế", "Khoản lỗ" };
            return array;
        }

        private void lvThuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // CREATE FAKE DATA
        private void btnFake_MouseClick(object sender, MouseEventArgs e)
        {
            addFake();
            updateFileByListView();
            calculateAndShowReportsIfPassCondition();
        }

        private void addFake()
        {
            addToList(true, doanhThuList, "Doanh thu", "12/12/2012", "luong", "30000");
            addToList(true, chiPhiDuocTruList, "Chi phí được trừ", "12/12/2012", "sinh hoat", "4000");
            addToList(true, thuNhapDuocMienThueList, "Thu nhập được miễn thuế", "12/12/2012", "ban hang", "5000");
            addToList(true, cacKhoanThuNhapKhacList, "Thu nhập khác", "12/12/2012", "co phieu", "9000");
            addToList(true, cacKhoanLoList, "Khoản lỗ", "12/12/2012", "boi thuong", "10000");
            addToList(true, cacKhoanLoList, "Chi phí được trừ", "12/12/2019", "tai nan", "15000");
            addToList(true, cacKhoanLoList, "Doanh thu", "12/12/2010", "Day hoc", "40000");
        }

        // SOLVE FILE
        private void writeData(List<String> contentList)
        {
            File.WriteAllText(getFilePath(), String.Empty);
            using (var file = new System.IO.StreamWriter(getFilePath(), true))
            {
                foreach (String line in contentList)
                {
                    file.WriteLine(string.Format("{0}", line));
                }
                file.Close();
            }
        }

        private String getDataLine(String muc, String ngay, String khoan, String money)
        {
            return $"{muc}\t{ngay}\t{khoan}\t{money}";
        }

        private void appendData(String content)
        {
            // This text is added only once to the file.
            if (!File.Exists(getFilePath()))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(getFilePath())) { }
            }
            using (StreamWriter sw = File.AppendText(getFilePath()))
            {
                sw.WriteLine(content);
                sw.Close();
            }
        }

        private void readFile()
        {

            try
            {

                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(getFilePath());
                foreach (string line in lines)
                {
                    try
                    {
                        String[] lineSplitArr = Helper.splitFileLine(line);
                        addToList(false, getListByMuc(lineSplitArr[0]), lineSplitArr[0], lineSplitArr[1], lineSplitArr[2], lineSplitArr[3]);
                    }
                    catch (Exception e)
                    {
                    }
                }
            }
            catch (Exception e)
            {
            }
        }

        private void updateFileByListView()
        {
            List<String> contentList = new List<string>();
            // row
            foreach (ListViewItem itemRow in Lst_AllData.Items)
            {
                String dataLine = "";
                // column
                for (int i = 1; i < itemRow.SubItems.Count; i++)
                {
                    var item = itemRow.SubItems[i];
                    dataLine += $"{item.Text}\t";
                }
                dataLine = dataLine.Trim();
                contentList.Add(dataLine);
            }

            writeData(contentList);
        }

        // IMPORT FILE
        private void btnMerge_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files|*"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {
                    String line = reader.ReadLine();
                    while (line != null)
                    {
                        String[] lineSplitArr = Helper.splitFileLine(line);
                        addToList(true, getListByMuc(lineSplitArr[0]), lineSplitArr[0], lineSplitArr[1], lineSplitArr[2], lineSplitArr[3]);
                        line = reader.ReadLine();
                    }
                    reader.Close();
                    //string line = reader.ReadLine();
                    // reader will be having all data
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // SUPPORTED
        private void clearReports()
        {
            lvResult.Items.Clear();
            Txt_Report.Text = "";
        }

        private void calculateAndShowReportsIfPassCondition()
        {
            if (isReportBtnClicked) onShowReport(false);
        }

        private void Btn_RemoveAll_Click(object sender, EventArgs e)
        {
            Lst_AllData.Items.Clear();
            updateListsByListView();
            updateFileByListView();
            calculateAndShowReportsIfPassCondition();
        }
    }
}
