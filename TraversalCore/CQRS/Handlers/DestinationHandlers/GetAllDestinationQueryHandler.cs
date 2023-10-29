using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using TraversalCore.CQRS.Queries.DestinationQueries;
using TraversalCore.CQRS.Results.DestinationResults;

namespace TraversalCore.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;
        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                Id = x.destinationId,
                capacity = x.capacity,
                city = x.city,
                dayNight = x.dayNight,
                price = x.price
            }).AsNoTracking().ToList();
            
            return values;
        }
    }
}
