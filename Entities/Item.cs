using System;

namespace Catalog.Entities
{
    public record Item
    {
        public Guid Id { get; init; }
        public String Name { get; init; }
        public Decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}   