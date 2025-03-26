using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            Contract.Requires(title != null);
            Contract.Requires(title.Length <= 200);
            this.title = title;
            this.id = new Random().Next(10000, 99999);
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            Contract.Requires(count <= 25000000);
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error : {0} ", ex.Message);
            }
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
