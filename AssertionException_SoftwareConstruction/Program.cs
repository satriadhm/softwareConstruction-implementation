using System.Runtime.Serialization;
using tpmodule6_1302213015;


internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - Glorious Satria Dhamang Aji");
        try
        {
            for (int i = 0; i < 100000; i++)
            {
                video.IncreasePlayCount(100000001);
                Console.WriteLine();
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
        video.PrintVideoDetails();

    }
}