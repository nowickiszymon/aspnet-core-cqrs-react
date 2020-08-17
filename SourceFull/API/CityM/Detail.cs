using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SourceFullStoreDb;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace API.CityM
{
    public class Detail
    {
        public class Query : IRequest<City> 
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, City>
        {
            public DataContext Context { get; }
            public Handler(DataContext context)
            {
                Context = context;
            }
            public async Task<City> Handle(Query request, CancellationToken cancellationToken)
            {
                var city = await Context.Cities.FindAsync(request.Id);
                return city; 
            }
        }
    }
}