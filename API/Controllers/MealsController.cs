using Application.Meals;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MealsController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetWeekMealList()
        {
            return HandleResult(await Mediator.Send(new WeekMealList.Query()));
        }
    }
}
