using Application.Core;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Meals
{
    public class WeekMealList
    {
        public class Query : IRequest<Result<List<MealDto>>> { }

        public class Handler : IRequestHandler<Query, Result<List<MealDto>>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Result<List<MealDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var mealsWithItems = await _context.Meals
                    .Include(meal => meal.MealItems)
                    .ToListAsync();

                // Use AutoMapper to map the Meal entity to MealDto
                var mealDtoList = _mapper.Map<List<MealDto>>(mealsWithItems);

                return Result<List<MealDto>>.Success(mealDtoList);
            }
        }
    }
}
