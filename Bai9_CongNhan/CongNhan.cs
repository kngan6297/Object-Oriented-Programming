using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_CongNhan
{
    public class CongNhan
    {
        private int maCN;
        private string mHo;
        private string mTen;
        private int mSoSP;
        //constructor
        public CongNhan()
        {

        }
        public CongNhan(int maCN, string mHo, string mTen, int mSoSP)
        {
            this.maCN = maCN;
            this.mHo = mHo;
            this.mTen = mTen;
            this.mSoSP = mSoSP;
        }
        //getter
        public int getMaCN()
        {
            return maCN;
        }
        public string getHo()
        {
            return mHo;
        }
        public string getTen()
        {
            return mTen;
        }
        public int getSoSP()
        {
            return mSoSP;
        }
        //setter
        public void setMaCN()
        {
            this.maCN = maCN;
        }
        public void setHo()
        {
            this.mHo = mHo;
        }
        public void setTen()
        {
            this.mTen = mTen;
        }
        public void setSoSP()
        {
            this.mSoSP = mSoSP;
        }
        public double tinhLuong()
        {
            double luong;
            if (mSoSP >= 1 && mSoSP <= 199)
            {
                luong = mSoSP * 0.5;
            }
            else if (mSoSP >= 200 && mSoSP <= 399)
            {
                luong = mSoSP * 0.55;
            }
            else if (mSoSP >= 400 && mSoSP <= 599)
            {
                luong = mSoSP * 0.6;
            }
            else
            {
                luong = mSoSP * 0.65;
            }
            return luong;
        }
        public string toString()
        {
            return String.Format("{0, -5} | {1, -10} | {2, -5} | {3, -5} | {4, -10}", maCN, mHo, mTen, mSoSP, tinhLuong());
        }
    }
}
