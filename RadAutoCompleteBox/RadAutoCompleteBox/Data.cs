using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadAutoCompleteBox
{
    public class Data
    {
        private ObservableCollection<Song> songs = new ObservableCollection<Song>();

        public void CreateSongsData()
        {
            songs.Add(new Song() { Title = "Chiec la mua dong", Author = "Nguyen Dinh Vu" });
            songs.Add(new Song() { Title = "Khong phai dang vua dau", Author = "Son Tung MTP" });
            songs.Add(new Song() { Title = "Khuon mat dang thuong", Author = "Son Tung MTP" });
            songs.Add(new Song() { Title = "Xuan nay con khong ve", Author = "Quang Le" });
            songs.Add(new Song() { Title = "Xuan nay con ve", Author = "Le Quang" });
            songs.Add(new Song() { Title = "Song que", Author = "Thai chau" });
        }

        public ObservableCollection<Song> GetSongs()
        {
            songs.Clear();
            CreateSongsData();
            return songs;
        }
    }
}
