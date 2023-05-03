using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_01
{
    public class DataMahasiswa_1302213015
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public  string gender { get; set; }
        public int age { get; set; }
        public  Address address { get; set; }

        public List<Courses> courses { get; set; } = new List<Courses>();

    }

    public class Address 
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class Courses 
    {
        public string code { get; set; }
        public string name { get; set; }

    }

}