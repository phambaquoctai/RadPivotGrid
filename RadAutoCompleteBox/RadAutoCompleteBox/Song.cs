using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadAutoCompleteBox
{
   public class Song
    {
        private string title = String.Empty;
        private string author = String.Empty;

        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;

                }
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (author != value)
                {
                    author = value;

                }
            }
        }
    }
}
