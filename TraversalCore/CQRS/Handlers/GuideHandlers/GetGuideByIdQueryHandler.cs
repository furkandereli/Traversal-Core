﻿using DataAccessLayer.Concrete;
using MediatR;
using TraversalCore.CQRS.Queries.GuideQueries;
using TraversalCore.CQRS.Results.GuideResults;

namespace TraversalCore.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;
        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, 
            CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                guideId = request.Id,
                description = values.description,
                name = values.name
            };
        }
    }
}
