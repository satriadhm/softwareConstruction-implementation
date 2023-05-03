using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodule6_1302213015
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)        {
            Random rnd = new Random();
            Contract.Requires(title.Length <= 100 );
            Debug.Assert(title != null);
            this.title = title;
            this.playCount = 0;
            this.id = rnd.Next(100000);
           
        }
        public void IncreasePlayCount(int count) 
        {
            Contract.Requires(count <= 100000000);
            Debug.Assert(count <= 10000000 && count > 0, "Terlalu banyak Play count, tidak valid");
            checked 
            {
                this.playCount += (count);
            }
            
           
            
        }

        public void PrintVideoDetails() 
        {
            Console.WriteLine("Video memiliki judul: " + title);
            Console.WriteLine("Video memiliki ID: " + id);
            Console.WriteLine("Video diputar sebanyak: " + playCount);
        }

    }
}
