using Domain.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Domain.DTOS
{
    public  class Pagination<T> : List<T>, IPagination<T> where T : class
    {
        public int PageIndx { get; set ; }
        public int PageSize { get; set ; }
        public int PageCount { get; set  ; }
        public IReadOnlyList<T> Data { get ; set ; }

     
    }
}
