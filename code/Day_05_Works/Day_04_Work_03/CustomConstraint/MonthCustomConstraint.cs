using System.Text.RegularExpressions;

namespace Day_05_Work_03.CustomConstraint
{
    public class MonthCustomConstraint : IRouteConstraint
    {
        public bool Match(
            HttpContext? httpContext,
            IRouter? route,
            string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            if (!values.ContainsKey(routeKey)) return false;

            Regex regex = new Regex($"^(apr|jul|oct|jan)$)");
            if (regex.IsMatch(routeKey)) return true;

            return false;
        }
    }
}
