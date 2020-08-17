using System;
using System.Threading;
using System.Threading.Tasks;
using SourceFullStoreDb;
using Domain;
using MediatR;
using static API.MemberM.Create;

namespace API.MemberM
{
    public class Create
    {
        public class Command : IRequest
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }
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
            var member = new Member
            {
                Id = request.Id,
                Name = request.Name,
                Surname = request.Surname
            };
            _context.Members.Add(member);
            var success = await _context.SaveChangesAsync() > 0;
            if (success){
                return Unit.Value;
            }
            else
            {
                throw new Exception("some error");
            }

        }
    }
}