using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SourceFullStoreDb;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace API.CityM
{
    public class List
    {
        public class Query : IRequest<List<City>> {}

        public class Handler : IRequestHandler<Query, List<City>>
        {
            public DataContext Context { get; }
            public Handler(DataContext context)
            {
                Context = context;
            }
            public async Task<List<City>> Handle(Query request, CancellationToken cancellationToken)
            {
                var cities = await Context.Cities.ToListAsync();
                return cities; 
            }
        }
    }
}