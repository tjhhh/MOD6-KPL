using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod6_103022300065
{
    class SayaTuberUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos ;
        private String Username;

        public SayaTuberUser(String nama)
        {
            Contract.Requires(nama != null);
            Contract.Requires(nama.Length <= 200);
            this.Username = nama;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }
        public int getTotalVideos()
        {
            int count = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                count += video.GetPlayCount();
            }
            return count;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }
        public void PrintAllVIdoecount()
        {


            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                if (i > 7)
                {
                    break;
                }
                Console.WriteLine("vidoe" + i + 1 + "judul" + uploadedVideos[i].Gettitle() + "count" + uploadedVideos[i].GetPlayCount());
            }

        }
    }
}
