using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodule7_kelompok_01
{
    public class DataMahasiswa_1302210127
    {
        public string nim { get; set; }
        public namaLengkap nama { get; set; }
        
        public string fakultas { get; set; }
        public DataMahasiswa_1302210127()
        {
            
        }

        public DataMahasiswa_1302210127(namaLengkap name, string nim, string fakultas) {
            this.nama = name;
            this.nim = nim;
            this.fakultas = fakultas;
        }

        public class namaLengkap 
        {
            public string depan { get; set; }
            public string belakang { get; set; }
                       
            public namaLengkap(string depan, string belakang) 
            {
                this.depan = depan;
                this.belakang = belakang;
            }
            public namaLengkap()
            {

            }
        }
    }
}
