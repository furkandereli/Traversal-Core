using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using TraversalCore.CQRS.Commands.GuideCommands;

namespace TraversalCore.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;
        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }
        
        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                name = request.name,
                description = request.description,
                status = true
            });
            await _context.SaveChangesAsync();
            return Unit.Value;    
        }
    }
}
