namespace TraversalCore.CQRS.Results.GuideResults
{
    public class GetAllGuideQueryResult
    {
        public int guideId { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public string? image { get; set; }
    }
}
