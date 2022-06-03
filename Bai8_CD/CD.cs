using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_CD
{
    public class CD
    {
        private int maCD;
        private string tuaCD;
        private int soBaiHat;
        private double giaThanh;
        //constructor
        public CD()
        {

        }
        public CD(int maCD, string tuaCD, int soBaiHat, double giaThanh)
        {
            this.maCD = maCD;
            this.tuaCD = tuaCD;
            this.soBaiHat = soBaiHat;
            this.giaThanh = giaThanh;
        }
        //getter
        public int getMaCD()
        {
            return maCD;
        }
        public string getTuaCD()
        {
            return tuaCD;
        }
        public int getSoBaiHat()
        {
            return soBaiHat;
        }
        public double getGiaThanh()
        {
            return giaThanh;
        }
        //setter
        public void setMaCD()
        {
            this.maCD = maCD;
        }
        public void setTuaCD()
        {
            this.tuaCD = tuaCD;
        }
        public void setSoBaiHat()
        {
            this.soBaiHat = soBaiHat;
        }
        public void setGiaThanh()
        {
            this.giaThanh = giaThanh;
        }
        public string toString()
        {
            return String.Format("{0,5} | {1,20} | {2,5} | {3,20:#,##0.00}", maCD, tuaCD, soBaiHat, giaThanh);
        }
    }
}
