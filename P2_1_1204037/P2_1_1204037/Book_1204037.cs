using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204037
{
    class Book_1204037 : Product_1204037
    {
        protected string PageCount;
        public Book_1204037(string type, string title, string PageCount) : base (type, title)
        {
            this.pageCount = PageCount;
        }

        public string pageCount
        {
            get
            {
                return PageCount;
            }

            set
            {
                PageCount = value;
            }
        }
    }
}
