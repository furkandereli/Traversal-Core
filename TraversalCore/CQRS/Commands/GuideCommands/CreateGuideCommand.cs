using MediatR;

namespace TraversalCore.CQRS.Commands.GuideCommands
{
    public class CreateGuideCommand:IRequest
    {
        public string? name { get; set; }
        public string? description { get; set; }
        public string? image { get; set; }
        public bool status { get; set; }
    }
}
