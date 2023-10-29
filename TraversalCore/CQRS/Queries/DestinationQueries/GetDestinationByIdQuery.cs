namespace TraversalCore.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIdQuery
    {
        public GetDestinationByIdQuery(int id) 
        {
            this.Id = id;
        }
        public int Id { get; set; }
    }
}
