﻿namespace CleanArchitecture.Basic.Api.Domain.Entities
{
    public class Product
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}
