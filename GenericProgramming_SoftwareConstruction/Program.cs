// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> data = new DataGeneric<string>("NIM praktikan"); // ganti dengan NIM praktikan
        data.PrintData();
    }
}


















class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data) 
    {
        this.data = data;
    }

    public void PrintData() 
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}
 class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Glorious Satria Dhamang Aji");
    }


}
class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}
