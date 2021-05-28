using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Song[] songs = new Song[3];
            songs[0] = new Song("カリカリ", "梅", 250);
            songs[1] = new Song("IPA", "応用", 800);
            songs[2] = new Song("バドワイザー", "ビールサーバー", 120);

            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) {

            for (int i = 0; i < songs.Length; ++i) {
                Console.WriteLine("曲名:{0}    アーティスト名:{1}    再生時間:{2}:{3:00}" ,songs[i].Title,songs[i].ArtistName,(songs[i].Length / 60),(songs[i].Length % 60));
            }
        }
    }
}
