using modul7_kelompok_01;

using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

internal class Program
{
    public static void Main(string[] args)
    {
        ReadJSON();
    }

    public static void ReadJSON()
    {
        String address = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        String jsonString = File.ReadAllText(address + "\\jurnal7_1_1302213026.json");
        DataMahasiswa1302213026 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302213026>(jsonString);
        Console.WriteLine("First name: "+ mahasiswa.firstName);
        Console.WriteLine("Last name: "+ mahasiswa.lastName);
        Console.WriteLine("Gender: " + mahasiswa.gender);
        Console.WriteLine("Age: " + mahasiswa.age);
        Console.WriteLine("StreetAddress: " + mahasiswa.address.streetAddress);
        Console.WriteLine("City: " + mahasiswa.address.city);
        Console.WriteLine("State: " + mahasiswa.address.state);
        int i = 1;
        foreach (var courses in mahasiswa.courses)
        {
            Console.WriteLine("Courses name: " + courses.name );
            Console.WriteLine("Courses code: " + courses.code);
            i++;
        }

    }
}