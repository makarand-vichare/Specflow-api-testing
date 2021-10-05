using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Filters
{
    public class AttachFakeUser : IAsyncActionFilter
    {
        private readonly string _userName;
         
        public AttachFakeUser(string userName)
        {
            _userName = userName;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            context.HttpContext.User = new System.Security.Claims.ClaimsPrincipal(
                new ClaimsIdentity(
                                    new List<Claim>
                                            {
                                                new Claim(ClaimTypes.Name, _userName)
                                            }
                                )
                );

            await next();
        }
    }
}
