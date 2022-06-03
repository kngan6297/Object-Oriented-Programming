using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_ToaDoHinhTron
{
    public class HinhTron
    {
        private ToaDo tam;
        private double banKinh;
        private double PI = 3.14f;
        //constructor
        public HinhTron()
        {

        }
        public HinhTron(ToaDo tam, double banKinh)
        {
            this.tam = tam;
            this.banKinh = banKinh;
        }
        //getter
        public ToaDo getTam()
        {
            return tam;
        }
        public double getBanKinh()
        {
            return banKinh;
        }
        //setter
        public void setTam(ToaDo tam)
        {
            this.tam = tam;
        }
        public void setBanKinh(double banKinh)
        {
            this.banKinh = banKinh;
        }
        public double tinhDienTich()
        {
            return PI * banKinh * banKinh;
        }
        public double tinhChuVi()
        {
            return 2 * PI * banKinh;
        }
        public string toString()
        {
            return String.Format("Hình tròn có tâm {0} với bán kính {1} có diện tích và chu vi lần lượt là {2:0.000} và {3:0.000}", tam.toString(), banKinh, tinhDienTich(), tinhChuVi());
        }
    }
}
