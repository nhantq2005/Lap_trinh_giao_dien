using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_01
{
    internal class PhanSo
    {
        int tuso, mauso;
        Random rnd = new Random();
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(int ts, int ms)
        {
            tuso = ts;
            mauso = (ms == 0 ? 1 : ms);
        }

        public int Tuso
        {
            get { return tuso; }
            set { tuso = value; }
        }
        public int Mauso
        {
            get { return mauso; }
            set { mauso = (value == 0 ? 1 : value); }
        }

        private void Toigian()
        {
            int us = DungChung.UCLN(tuso, mauso);
            if (us > 0)
            {
                tuso /= us;
                mauso /= us;
            }
        }

        public string KiemTra(PhanSo p)
        {
            if (p.tuso == this.tuso && p.mauso == this.mauso)
            {
                return "Chính xác";
            }
            return "Sai rồi!";
        }

        //public void SinhPS()
        //{
        //    this.tuso = rnd.Next(0,10);
        //    this.mauso = rnd.Next(1, 10);
        //}

        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * p.mauso + p.tuso * mauso;
            kq.mauso = mauso * p.mauso;
            kq.Toigian();
            return kq;
        }
        public PhanSo Tru(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * p.mauso - p.tuso * mauso;
            kq.mauso = mauso * p.mauso;
            kq.Toigian();
            return kq;
        }
        public PhanSo Nhan(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * p.tuso;
            kq.mauso = mauso * p.mauso;
            kq.Toigian();
            return kq;
        }
        public PhanSo Chia(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * p.mauso;
            kq.mauso = mauso * p.tuso;
            kq.Toigian();
            return kq;
        }
    }
}
