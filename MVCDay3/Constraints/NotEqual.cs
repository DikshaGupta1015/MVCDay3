using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MVCDay3.Constraints
{
    public class NotEqual : IRouteConstraint
    {
        string _checkValues;

        public NotEqual(string checkValues)
        {
            _checkValues = checkValues;
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            bool result;

            result = string.Compare(values[parameterName].ToString(), _checkValues) != 0;

            return result;
        }
    }
}