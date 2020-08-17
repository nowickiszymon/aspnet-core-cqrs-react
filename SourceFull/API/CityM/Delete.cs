using System;
using System.Threading;
using System.Threading.Tasks;
using SourceFullStoreDb;
using MediatR;

namespace API.CityM
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
                var city = await _context.Cities.FindAsync(request.Id);
                if (city == null)
                {
                    throw new Exception("Could not find City");
                }
                _context.Remove(city);
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