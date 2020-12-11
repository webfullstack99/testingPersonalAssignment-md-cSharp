using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_triangle.Classes
{
    class MoneyOutput
    {

        private int nam;
        private double mucThueSuat;
        private double money;

        public MoneyOutput(int nam, double mucThueSuat, double money)
        {
            this.nam = nam;
            this.mucThueSuat = mucThueSuat;
            this.money = money;
        }

        public int getNam()
        {
            return nam;
        }

        public double getMucThueSuat()
        {
            return mucThueSuat;
        }

        public double getMoney()
        {
            return money;
        }
    }
}
