﻿using AspNetCore.IQueryable.Extensions.Attributes;
using AspNetCore.IQueryable.Extensions.Filter;
using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using System;

namespace RestFulTests.Models
{
    public class UserSearch : IRestSort, IRestPagination
    {
        public string Username { get; set; }

        [Rest(Operator = WhereOperator.GreaterThan)]
        public DateTime? Birthday { get; set; }

        [Rest(Operator = WhereOperator.Contains, HasName = "Firstname")]
        public string Name { get; set; }

        [Rest(Operator = WhereOperator.Contains, HasName = "SocialNumber.Identification")]
        public string Ssn { get; set; }

        public int Offset { get; set; }
        public int Limit { get; set; } = 10;
        public string Sort { get; set; }
    }
}
