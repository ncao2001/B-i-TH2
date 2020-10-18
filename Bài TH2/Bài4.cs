using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_TH2
{
    class DaThuc
    {
        private int n;
        private int[] a;
        public DaThuc()
        {
            n = 0;
            a = null;
        }

        public DaThuc(int n)
        {
            this.n = n;
            a = new int[n];
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin cua da thuc");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Hien()
        {
            Console.WriteLine("Thong tin cac he so cua da thuc");
            for (int i = 0; i < n; i++)
                Console.Write("{0}, ", i);
        }

        public DaThuc Tong(DaThuc t2)
        {
            if (this.n == t2.n)
            {
                DaThuc d = new DaThuc(this.n);
                for (int i = 0; i < n; i++)
                    d.a[i] = this.a[i] + t2.a[i];
                return d;
            }
            else return null;
        }

        public DaThuc Hieu(DaThuc t2)
        {
            if (this.n == t2.n)
            {
                DaThuc d = new DaThuc(this.n);
                for (int i = 0; i < n; i++)
                    d.a[i] = this.a[i] - t2.a[i];
                return d;
            }
            else return null;
        }

        class App
        {
            static void Main4()
            {
                DaThuc d1 = new DaThuc();
                DaThuc d2 = new DaThuc();
                Console.WriteLine("Da thuc thu nhat"); d1.Hien();
                Console.WriteLine("Da thuc thu hai"); d2.Hien();
                DaThuc d3 = d1.Tong(d2);
                DaThuc d4 = d1.Hieu(d2);
                Console.WriteLine("Da thuc tong"); d3.Hien();
                Console.WriteLine("Da thuc hieu"); d4.Hien();
                Console.ReadLine();

            }
        }
    }
}