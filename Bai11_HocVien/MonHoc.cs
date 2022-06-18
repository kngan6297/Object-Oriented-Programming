using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11_HocVien
{
    public class MonHoc
    {
        private string tenMonHoc;
        private double diem;
        public MonHoc(string tenMonHoc, double diem)
        {
            this.tenMonHoc = tenMonHoc;
            this.diem = diem;
        }

        //getter
        public string getTenMonHoc()
        {
            return tenMonHoc;
        }
        public double getDiem()
        {
            return diem;
        }
        //setter
        public void setTenMonHoc(string tenMonHoc)
        {
            this.tenMonHoc = tenMonHoc;
        }
        public void setDiem(double diem)
        {
            this.diem = diem;
        }
    }
}