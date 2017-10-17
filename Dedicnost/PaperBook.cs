using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost
{
    class PaperBook : Book
    {
        private int weight;
        private int stock;// i = i

        public PaperBook(Author author, int pages, string name, int weight, int stock)
            : base(author, pages, name)
        {
            this.weight = weight;
            this.stock = stock;
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
            }
        }
    }
}
