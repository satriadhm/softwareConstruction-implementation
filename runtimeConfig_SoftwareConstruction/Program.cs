using tpmodul8_1302213015;

public class Program
{
    private static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();
        Console.Write("Berapa suhu badan anda saat ini? Dalam " + config.config.satuan_suhu+": ");
        double suhu = double.Parse(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?: ");
        int hariDemam = int.Parse(Console.ReadLine());

        if (config.IsInputValid(suhu, hariDemam))
        {
            Console.WriteLine(config.config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.config.pesan_ditolak);


        }
    }
}