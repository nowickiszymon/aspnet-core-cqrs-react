using System;
using System.Threading;
using System.Threading.Tasks;
using SourceFullStoreDb;
using MediatR;

namespace API.MemberM
{
    public class Delete
    {
        public class Command : IRequest
        {
            public int Id { get; set; }   
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var member = await _context.Members.FindAsync(request.Id);
                if (member == null)
                {
                    throw new Exception("Could not find member");
                }
                _context.Remove(member);
                var success = await _context.SaveChangesAsync() > 0;
                if (success)
                {
                    return Unit.Value;
                }
                throw new Exception("some problem");
            }
        }
    }
}