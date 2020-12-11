using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T7_2180617_TranHoangAnh.Classes;

namespace check_triangle.Classes
{
    class MoneyInput
    {
        public DateTime ngay;
        public String khoan;
        public Double money;


        public MoneyInput(String ngayStr, String khoanStr, String moneyStr)
        {
            convertValue(ngayStr, khoanStr, moneyStr);
        }
        public MoneyInput(DateTime ngay, String khoan, Double money)
        {

        }

        public void convertValue(String ngay, String khoan, String money)
        {
            DateTime dateTime = Helper.getTime(ngay);
            this.ngay = dateTime;
            this.khoan = (khoan != null) ? khoan : "khac";
            try
            {
                this.money = Double.Parse(money);
            }catch(Exception e)
            {
            }
        }

        public String getInfo()
        {
            return $"{ngay.Year}; {khoan}; {money}";
        }

        public int getYear()
        {
            return ngay.Year;
        }

        public double getMoney()
        {
            return money;
        }

        public DateTime getNgay()
        {
            return ngay;
        }
    }
}
