using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public class Param :IParam
    {
        private const int MaxPageSize = 50;
        public int PageIndex { get; set; } = 0;
  

        private int _pageSize = 15;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = _pageSize > MaxPageSize ? MaxPageSize : value; }
        }
        public string? Sort { get; set; }
        public int PageCount { get ; set ; }
        public string? Order { get ; set ; }
    }
}
