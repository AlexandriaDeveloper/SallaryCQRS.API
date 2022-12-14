using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public  interface IPagination<T> where T : class
    {
        public int PageIndx { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }
        public IReadOnlyList<T> Data { get; set; }




    }
}
