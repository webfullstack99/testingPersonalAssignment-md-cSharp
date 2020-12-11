using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_triangle.Classes
{
    class CalculateMoney
    {
        public List<int> yearList = new List<int>();
        public List<double> sotienDongList = new List<double>();
        public List<double> mucThueSuatList = new List<double>();

        public List<MoneyInput> doanhThuList;
        public List<MoneyInput> chiPhiDuocTruList;
        public List<MoneyInput> cacKhoanThuNhapKhacList;
        public List<MoneyInput> thuNhapDuocMienThueList;
        public List<MoneyInput> cacKhoanLoList;

        public CalculateMoney() { }

        public CalculateMoney(List<MoneyInput> doanhThuList, List<MoneyInput> chiPhiDuocTruList, List<MoneyInput> cacKhoanThuNhapKhacList,
            List<MoneyInput> thuNhapDuocMienThueList, List<MoneyInput> cacKhoanLoList)
        {
            setLists(doanhThuList, chiPhiDuocTruList, cacKhoanThuNhapKhacList, thuNhapDuocMienThueList, cacKhoanLoList);
        }

        public void setLists(List<MoneyInput> doanhThuList, List<MoneyInput> chiPhiDuocTruList, List<MoneyInput> cacKhoanThuNhapKhacList,
        List<MoneyInput> thuNhapDuocMienThueList, List<MoneyInput> cacKhoanLoList)
        {
            // reset year list
            yearList.Clear();

            // set lists
            this.doanhThuList = doanhThuList;
            addYearByList(doanhThuList);

            this.chiPhiDuocTruList = chiPhiDuocTruList;
            addYearByList(chiPhiDuocTruList);

            this.cacKhoanThuNhapKhacList = cacKhoanThuNhapKhacList;
            addYearByList(cacKhoanThuNhapKhacList);

            this.thuNhapDuocMienThueList = thuNhapDuocMienThueList;
            addYearByList(thuNhapDuocMienThueList);

            this.cacKhoanLoList = cacKhoanLoList;
            addYearByList(cacKhoanLoList);
        }

        public void addYearByList(List<MoneyInput> moneyList)
        {
            foreach (MoneyInput element in moneyList)
            {
                int index = yearList.FindIndex(a => a == element.getYear());
                if (index < 0)
                {
                    yearList.Add(element.getYear());
                }
            }
        }

        public void calculate()
        {
            mucThueSuatList.Clear();
            sotienDongList.Clear();

            setMucThueSuat();
            calcSoTienDong();
        }

        private void calcSoTienDong()
        {

            for (int i = 0; i < yearList.Count; i++)
            {
                try
                {
                    if (checkDataEnough(yearList.ElementAt(i)))
                    {

                        //double doanhThu = Convert.ToDouble(standardizeValue(tbA.Text.ToString()));
                        double doanhThu = getTotalMoneyOfListByYear(doanhThuList, yearList.ElementAt(i));
                        double chiPhiDuocTru = getTotalMoneyOfListByYear(chiPhiDuocTruList, yearList.ElementAt(i));
                        double thuNhapKhac = getTotalMoneyOfListByYear(cacKhoanThuNhapKhacList, yearList.ElementAt(i));
                        double thuNhapDuocMienThue = getTotalMoneyOfListByYear(thuNhapDuocMienThueList, yearList.ElementAt(i));
                        double cacKhoanLo = getTotalMoneyOfListByYear(cacKhoanLoList, yearList.ElementAt(i));
                        double thueSuat = getMucThueSuat(yearList.ElementAt(i));


                        double thuNhapChiuThue = doanhThu - chiPhiDuocTru + thuNhapKhac;
                        double thuNhapTinhThue = thuNhapChiuThue - (thuNhapDuocMienThue + cacKhoanLo);
                        double thuePhaiNop = thuNhapTinhThue * thueSuat;
                        double soTienPhaiDong = Math.Round(thuePhaiNop);
                        sotienDongList.Add(soTienPhaiDong);
                    }
                    else
                    {
                        sotienDongList.Add(0);
                    }
                }
                catch (Exception ex)
                {
                    String errMessage = "Loi du lieu";
                    MessageBox.Show(errMessage);
                }
            }
        }

        private bool checkDataEnough(int year)
        {
            int doanhThu = getListByYear(doanhThuList, year).Count;
            int chiPhi = getListByYear(chiPhiDuocTruList, year).Count;
            int mienThue = getListByYear(thuNhapDuocMienThueList, year).Count;
            int khac = getListByYear(cacKhoanThuNhapKhacList, year).Count;
            int lo = getListByYear(cacKhoanLoList, year).Count;
            return (
                doanhThu > 0 &&
                chiPhi > 0 &&
                mienThue > 0 &&
                khac > 0 &&
                lo > 0
            );
        }

        private Double getTotalMoneyOfListByYear(List<MoneyInput> inputList, int year)
        {
            double totalMoney = 0;
            List<MoneyInput> list = getListByYear(inputList, year);
            for (int i = 0; i < list.Count; i++)
            {
                totalMoney += list.ElementAt(i).getMoney();
            }
            return totalMoney;
        }

        private List<MoneyInput> getListByYear(List<MoneyInput> inputList, int year)
        {
            List<MoneyInput> list = new List<MoneyInput>();
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList.ElementAt(i).getYear() == year) list.Add(inputList.ElementAt(i));
            }
            return list;
        }

        public void setMucThueSuat()
        {
            for (int i = 0; i < yearList.Count; i++)
            {
                mucThueSuatList.Add(getMucThueSuat(yearList.ElementAt(i)));
            }
        }

        public bool isListSizeValid()
        {
            int size = yearList.Count;
            return (
                chiPhiDuocTruList.Count >= size &&
                cacKhoanThuNhapKhacList.Count >= size &&
                thuNhapDuocMienThueList.Count >= size &&
                cacKhoanLoList.Count >= size
            );
        }

        public double getMucThueSuat(int year)
        {
            double value;
            switch (year)
            {
                case 2019:
                    value = 0.2F;
                    break;
                default:
                    value = 0.2F;
                    break;
            }
            return Math.Round(value, 2);
        }

        public List<MoneyOutput> getMoneyOutputList()
        {
            List<MoneyOutput> resultList = new List<MoneyOutput>();
            for (int i = 0; i < yearList.Count; i++)
            {
                MoneyOutput moneyOutput = new MoneyOutput(yearList.ElementAt(i), mucThueSuatList.ElementAt(i), sotienDongList.ElementAt(i));
                resultList.Add(moneyOutput);
            }
            resultList.Sort(delegate (MoneyOutput x, MoneyOutput y) {
                return (y.getNam() - x.getNam());
            });

            return resultList;

        }
    }
}


