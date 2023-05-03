internal class Program
{
    private static void Main(string[] args)
    {

        Penjumlahan jumlah = new Penjumlahan();
        jumlah.JumlahTigaAngka(13.0, 02.0, 21.0);

        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(12);
        data.AddNewData(34);
        data.AddNewData(56);

        data.printAllData();
    }
}

class Penjumlahan
{
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        //NIM berakhiran 3, 4 atau 5: tipe data input double

        dynamic angkaPertama = angka1;
        dynamic angkaKedua = angka2;
        dynamic angkaKetiga = angka3;
        Console.Write("Jumlah tiga angka adalah: ");
        Console.WriteLine(angkaPertama + angkaKedua + angkaKetiga);

    }

}
public class SimpleDataBase<T>
{
    List<T> storedData;
    List<DateTime> inputDates;
    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void AddNewData(T newData)
    {
        storedData.Add(newData);
        inputDates.Add(DateTime.UtcNow);

    }
    public void printAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + ((int)i + 1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }

}