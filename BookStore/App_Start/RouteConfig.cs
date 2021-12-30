using BookStore.RoutesConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Mvc.Routing;

namespace BookStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var constraintsResolver = new DefaultInlineConstraintResolver();

            constraintsResolver.ConstraintMap.Add("values", typeof(ValuesConstraint));
            /* */

            routes.MapMvcAttributeRoutes(constraintsResolver);     // Linha Alterada

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(name: "newRoute",
                    url: "api/rota/estacao/{estacao:values(primavera|verao|outono|inverno)}",
                    defaults: new { controller = "Teste", action = "MinhaAction4" },
                    constraints: new { name = new ValuesConstraint("primavera|verao|outono|inverno") }
            );
        }
    }
}
