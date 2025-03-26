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
    }
}
