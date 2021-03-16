using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Song
    {
        public string title; //tells you more about the object that is being created
        public string artist;
        public int duration;
        public static int songCount = 0; //tells you about the class in general

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;

            songCount++;
        }
    }
}
