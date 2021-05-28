using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
     class Song {
        // 曲のタイトル
        public string Title = null;
        // アーティスト名
        public string ArtistName = null ;
        // 曲の長さ
        public int Length = 0;

        public Song(string title,string name,int len) {
            Title = title;
            ArtistName = name;
            Length = len;
        }

    }
}
