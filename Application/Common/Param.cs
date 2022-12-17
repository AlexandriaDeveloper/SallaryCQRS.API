using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public abstract class Param //:IParam
    {
        private const int MaxPageSize = 50;
        public int pageNumber { get; set; } = 1;
  

        private int _pageSize = 15;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        public string? Sort { get; set; }
        public int PageCount { get ; set ; }
        public string? Order { get ; set ; }
    }
}
