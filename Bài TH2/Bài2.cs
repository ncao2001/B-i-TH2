using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_TH2
{
    class PS
    {
        private int ts, ms;
        public PS()
        {
            ts = 0;
            ms = 1;
        }
        public PS(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        //Nhập
        public void Nhap()
        {
            Console.Write("Nhap tu so:");
            ts = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so:");
            ms = int.Parse(Console.ReadLine());
        }
        //Hiển thị
        public void Hien()
        {
            if (ms == 1) Console.WriteLine("{0}", ts);
            else Console.WriteLine("{0}/{1}", ts, ms);
        }
        //Tìm UCLN
        public int Uscln(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }
        //Rút gọn
        public PS Rutgon()
        {
            int uc = Uscln(this.ts, this.ms);
            this.ts = this.ts / uc;
            this.ms = this.ms / uc;
            return this;
        }
        //Tổng
        public PS Tong(PS t2)
        {
            ts = this.ts * t2.ms + this.ms * t2.ts;
            ms = this.ms * t2.ms;
            return Rutgon();
        }
        //Hiệu
        public PS Hieu(PS t2)
        {
            ts = this.ts * t2.ms - this.ms * t2.ts;
            ms = this.ms * t2.ms;
            return Rutgon();
        }
        //Tích
        public PS Tich(PS t2)
        {
            ts = this.ts * t2.ts;
            ms = this.ms * t2.ms;
            return Rutgon();
        }
        //Thương
        public PS Thuong(PS t2)
        {
            ts = this.ts * t2.ms;
            ms = this.ms * t2.ts;
            return Rutgon();
        }
        //Quy đồng
        public static PS operator +(PS t1, PS t2)
        {
            PS t = new PS();
            t.ts = t1.ts * t2.ms + t1.ms * t2.ts;
            t.ms = t1.ms * t2.ms;
            return t.Rutgon();
        }
        //SO sánh lớn hơn
        public static bool operator >(PS t1, PS t2)
        {
            return t1.ts * t2.ms > t2.ts * t1.ms;
        }
        //So sánh nhỏ hơn
        public static bool operator <(PS t1, PS t2)
        {
            return t1.ts * t2.ms < t2.ts * t1.ms;
        }
    }
    class APP
    {
        static void Main2(string[] args)
        {
            PS t1 = new PS();
            PS t2 = new PS();
            Console.WriteLine("Tong hai phan so");
            PS tong = t1.Tong(t2);
            tong.Hien();
            Console.WriteLine("Hieu hai phan so");
            PS hieu = t1.Hieu(t2);
            hieu.Hien();
            Console.WriteLine("Tich hai phan so");
            PS tich = t1.Tich(t2);
            tich.Hien();
            Console.WriteLine("Thuong hai phan so");
            PS thuong = t1.Thuong(t2);
            thuong.Hien();
            if (t1 > t2) Console.WriteLine("t1>t2");
            else Console.WriteLine("t1<=t2");
            Console.ReadKey();
        }
    }
}
