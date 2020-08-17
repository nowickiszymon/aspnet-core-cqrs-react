using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SourceFullStoreDb;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace API.MemberM
{
    public class Detail
    {
        public class Query : IRequest<Member> 
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Member>
        {
            public DataContext Context { get; }
            public Handler(DataContext context)
            {
                Context = context;
            }
            public async Task<Member> Handle(Query request, CancellationToken cancellationToken)
            {
                var member = await Context.Members.FindAsync(request.Id);
                return member; 
            }
        }
    }
}