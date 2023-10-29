﻿using DataAccessLayer.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TraversalCore.CQRS.Queries.GuideQueries;
using TraversalCore.CQRS.Results.GuideResults;

namespace TraversalCore.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;
        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, 
            CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                guideId = x.guideId,
                description = x.description,
                image = x.image,
                name = x.name
            }).AsNoTracking().ToListAsync();
        }
    }
}
