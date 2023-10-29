namespace TraversalCore.CQRS.Commands.DestinationCommands
{
    public class DeleteDestinationCommand
    {
        public int Id { get; set; }

        public DeleteDestinationCommand(int id)
        {
            Id = id;
        }
    }
}
