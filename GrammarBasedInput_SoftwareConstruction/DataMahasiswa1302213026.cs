using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_01
{
    internal class DataMahasiswa1302213026
    {
        public String gender { get; set; }
        public int age { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public address address { get; set; }
        public List<courses> courses { get; set; }

        public DataMahasiswa1302213026() {}
        public DataMahasiswa1302213026( String gender, int age, String firstname, String lastname, address address, List<courses> courses) {
            this.gender = gender;
            this.age = age;
            this.firstName = firstname;
            this.lastName = lastname;
            this.address = address;
            this.courses = courses;
        }

    }
    public class address
    {
        public String streetAddress { get; set; }
        public String city { get; set; }
        public String state { get; set; }

        public address() { }
        public address(String streetAddress, String city, String state) {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
        }
    }
    public class courses
    {
        public String code { get; set; }
        public String name { get; set; }

        
    }

}
