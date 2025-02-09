﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Ardalis.Specification.EntityFrameworkCore
{
#if !NETSTANDARD2_0
  public class AsSplitQueryEvaluator : IEvaluator
  {
    private AsSplitQueryEvaluator() { }
    public static AsSplitQueryEvaluator Instance { get; } = new AsSplitQueryEvaluator();

    public bool IsCriteriaEvaluator { get; } = true;

    public IQueryable<T> GetQuery<T>(IQueryable<T> query, ISpecification<T> specification) where T : class
    {
      if (specification.AsSplitQuery)
      {
        query = query.AsSplitQuery();
      }

      return query;
    }
  }
#endif
}
