using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SourceFullStoreDb;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace API.MemberM
{
    public class List
    {
        public class Query : IRequest<List<Member>> {}

        public class Handler : IRequestHandler<Query, List<Member>>
        {
            public DataContext Context { get; }
            public Handler(DataContext context)
            {
                Context = context;
            }
            public async Task<List<Member>> Handle(Query request, CancellationToken cancellationToken)
            {
                var members = await Context.Members.ToListAsync();
                return members; 
            }
        }
    }
}