using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Song {
        // 曲のタイトル
        public string Title  {set; get;}
        // アーティスト名
        public string ArtistName { set; get; }
        // 曲の長さ
        public int Length { set; get; }

        public Song(string title,string name,int len) {
            Title = title;
            ArtistName = name;
            Length = len;
        }

    }
}
