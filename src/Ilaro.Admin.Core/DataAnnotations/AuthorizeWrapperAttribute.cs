using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Ilaro.Admin.Core.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorizeWrapperAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var authorize = Admin.Current.Authorize;
            if (authorize != null)
            {
                authorize.OnAuthorization(context);
            }
        }
    }
}