using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost
{
    class EBook : Book
    {
        private string uri;
        private double sizeMB;

        public EBook(Author author, int pages, string uri, double sizeMB, string name)
            : base(author, pages, name)
            
        {
            this.uri = uri;
            this.sizeMB = sizeMB;
            //Console.Write("Bus");
        }
        public override string ToString()
        {
            return "Class EBook. Author: "+base.Author+". Pages:"+ base.Pages + " URI: "+this.uri+". Size: "+this.sizeMB+"MB";
        }
        public string Uri
        {
            get
            {
                return this.uri;
            }
            set
            {
                this.uri = value;
            }
        }

        public double SizeMB
        {
            get
            {
                return this.sizeMB;
            }
            set
            {
                this.sizeMB = value;
            }
        }

    }
}
