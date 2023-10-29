using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using TraversalCore.CQRS.Commands.DestinationCommands;

namespace TraversalCore.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;
        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination
            {
                city = command.city,
                price = command.price,
                dayNight = command.dayNight,
                capacity = command.capacity,
                status = true
            });
            _context.SaveChanges();
        }
    }
}
