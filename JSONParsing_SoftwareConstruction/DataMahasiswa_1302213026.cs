using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodule7_kelompok_01
{
    internal class DataMahasiswa_1302213026
    {
        public String nim { get; set; }
        public String fakultas { get; set; }
        
        public NamaLengkap nama { get; set; }

        public DataMahasiswa_1302213026() { }
        public DataMahasiswa_1302213026(string nim, string fakultas, NamaLengkap nama)
        {
            this.nim = nim;
            this.fakultas= fakultas;
            this.nama = nama;
        }

        public class NamaLengkap
        {
            public String depan { get; set; }
            public String belakang { get; set; }

            public NamaLengkap() { }
            public NamaLengkap(String depan, String belakang)
            {
                this.depan = depan;
                this.belakang = belakang;
            }
        }
    }
}
