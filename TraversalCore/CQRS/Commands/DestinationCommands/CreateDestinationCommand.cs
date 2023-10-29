using EntityLayer.Concrete;

namespace TraversalCore.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public string? city { get; set; }
        public string? dayNight { get; set; }
        public double price { get; set; }
        public int capacity { get; set; }
        public bool status { get; set; }
    }
}
