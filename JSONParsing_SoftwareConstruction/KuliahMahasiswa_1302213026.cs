using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text.Json.Nodes;

namespace tpmodule7_kelompok_01
{
    internal class KuliahMahasiswa_1302213026
    {

        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("..\\..\\..\\tp7_2_1302213026.json");
            dynamic matkul = JsonConvert.DeserializeObject(jsonString);

            int i = 1;
            foreach (var course in matkul.courses)
            {
                Console.WriteLine($"MK " + (i) + " " + course.code + " - " + course.name);
                i++;
            }
        }
        public List<MatakuliahMahasiswa_1302213026> course { get; set; }

        public KuliahMahasiswa_1302213026() { }

        public KuliahMahasiswa_1302213026(List<MatakuliahMahasiswa_1302213026> course)
        {
            this.course = course;
        }


    }



    public class MatakuliahMahasiswa_1302213026
    {
        public String code { get; set; }
        public String name { get; set; }

        public MatakuliahMahasiswa_1302213026() { }
        public MatakuliahMahasiswa_1302213026(String code, String name)
        {
            this.code = code;
            this.name = name;
        }


    }
}
