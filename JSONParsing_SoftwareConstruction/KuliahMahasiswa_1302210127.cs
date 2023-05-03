using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodule7_kelompok_01
{
    public class KuliahMahasiswa_1302210127
    {
        public List<MataKuliah_1302210127> matkul { get; set; }

        public KuliahMahasiswa_1302210127(List<MataKuliah_1302210127> matkul)
        {
            this.matkul = matkul;
        }
        public KuliahMahasiswa_1302210127()
        {
        }
    }
    public class MataKuliah_1302210127
    {
        public string kode { get; set; }
        public string nama { get; set; }

        public MataKuliah_1302210127(string kodeX, string namaX)
        {
            kode = kodeX;
            nama = namaX;
        }
        public MataKuliah_1302210127() { }
    }
}
