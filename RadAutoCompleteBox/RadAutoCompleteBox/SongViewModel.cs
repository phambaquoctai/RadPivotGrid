using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadAutoCompleteBox
{
    public class SongViewModel
    {
        Data source = new Data();
        private ObservableCollection<Song> songsList = new ObservableCollection<Song>();

        public ObservableCollection<Song> SongsList
        {
            get { return songsList; }
        }

        public SongViewModel()
        {
            foreach(var song in source.GetSongs())
            {
                songsList.Add(song);
            }
        }
    }
}
