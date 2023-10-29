namespace TraversalCore.CQRS.Results.GuideResults
{
    public class GetGuideByIdQueryResult
    {
        public int guideId { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
    }
}
