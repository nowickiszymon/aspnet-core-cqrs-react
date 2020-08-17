using System;
using System.Threading;
using System.Threading.Tasks;
using SourceFullStoreDb;
using MediatR;
using static API.MemberM.Edit;

namespace API.MemberM
{
    public class Edit
    {
        public class Command : IRequest
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Surname { get; set; }
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
                member.Name = request.Name ?? member.Name;
                member.Surname = request.Surname ?? member.Surname;
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