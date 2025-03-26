using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod6_103022300065
{
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public int GetPlayCount()
        {
            return this.playCount;
        }
        public SayaTubeVideo(String title)
        {
            this.title = title;
            this.id = new Random().Next(10000, 99999);
            this.playCount = 0;
        }
        public void IncreasePlayCount()
        {
            this.playCount++;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video : " + this.id +" judul: "+this.title);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
        public string Gettitle()
        {
            return title;
        }
    }
}
