using System;
using System.Threading;
using System.Threading.Tasks;
using SourceFullStoreDb;
using Domain;
using MediatR;
using static API.CityM.Create;

namespace API.CityM
{
    public class Create
    {
        public class Command : IRequest
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Size { get; set; }
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
            var city = new City
            {
                Id = request.Id,
                Name = request.Name,
                Size = request.Size
            };
            _context.Cities.Add(city);
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