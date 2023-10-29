﻿namespace TraversalCore.CQRS.Results.DestinationResults
{
    public class GetAllDestinationQueryResult
    {
        public int Id { get; set; }
        public string? city { get; set; }
        public string? dayNight { get; set; }
        public double price { get; set; }
        public int capacity { get; set; }
    }
}
