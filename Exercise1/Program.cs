using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var songs = new Song[] {
             new Song("カリカリ", "梅", 250),
             new Song("IPA", "応用", 800),
             new Song("バドワイザー", "ビールサーバー", 120)
        };
            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine("曲名:{0}   アーティスト名:{1}    再生時間:{2}:{3:00}" ,song.Title,song.ArtistName,(song.Length / 60),(song.Length % 60));
            }
        }
    }
}
