using modul6_1302213015;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Jurassic Park 1");

        SayaTubeVideo video2 = new SayaTubeVideo("Jurassic Park 2");

        SayaTubeVideo video3 = new SayaTubeVideo("Jurassic Park 3");

        SayaTubeVideo video4 = new SayaTubeVideo("Naruto");

        SayaTubeVideo video5 = new SayaTubeVideo("Naruto Shipudden");

        SayaTubeVideo video6 = new SayaTubeVideo("Tukang Bubur Naik Haji");

        SayaTubeVideo video7 = new SayaTubeVideo("Death Note");

        SayaTubeVideo video8 = new SayaTubeVideo("Harry Potter");

        SayaTubeVideo video9 = new SayaTubeVideo("God of The Ring 1");

        SayaTubeVideo video10 = new SayaTubeVideo("God of The Ring 2");
        ;

        SayaTubeUser user = new SayaTubeUser("Satria");
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);


        //for (int i = 0; i < 1129735; i++) 
       // {
       //     video1.IncreasePlayCount(1231414);
       // }

        user.PrintAllVideoPlayCount();

       
       
    }
}