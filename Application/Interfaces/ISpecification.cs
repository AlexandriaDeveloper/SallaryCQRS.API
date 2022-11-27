﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public  interface ISpecification <T>
    {
        int Take { get; }
        int Skip { get; }
        bool IsPagination { get; }
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, bool>>> Criteries { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
    }
}