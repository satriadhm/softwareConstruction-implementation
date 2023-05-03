using System.Text.Json;
using System.Collections.Generic;
using tpmodule7_kelompok_01;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302210127 data = new DataMahasiswa_1302210127();

        //Read JSON
        String jsonString = File.ReadAllText("..\\..\\..\\tp7_1_1302210127.json");
        
        //Deserialize
        DataMahasiswa_1302210127 mhs = JsonSerializer.Deserialize<DataMahasiswa_1302210127>(jsonString);
        Console.WriteLine("Nama: "+mhs.nama.depan +" " + mhs.nama.belakang + " dengan nim  " + mhs.nim+ " dari fakultas " + mhs.fakultas);

        String jsonString2 = File.ReadAllText("..\\..\\..\\tp7_2_1302210127.json");
        //Deserialize 2
        KuliahMahasiswa_1302210127 kuliah = JsonSerializer.Deserialize<KuliahMahasiswa_1302210127>(jsonString2);
        if (kuliah.matkul != null)
        {
            int i = 1;
            foreach (MataKuliah_1302210127 matkul in kuliah.matkul)
            {
                Console.WriteLine("MK " + (i) + " " + matkul.kode + " - " + matkul.nama);
                i++;
            }
        }

        DataMahasiswa_1302213026 datamsh = new DataMahasiswa_1302213026();

        String jsonStringMhs = File.ReadAllText("..\\..\\..\\tp7_1_1302213026.json");

        DataMahasiswa_1302213026 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa_1302213026>(jsonStringMhs);
        Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim  " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);

        KuliahMahasiswa_1302213026 kuliahh = new KuliahMahasiswa_1302213026();
        kuliahh.ReadJSON();



    }
  
}