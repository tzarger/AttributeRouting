﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using AttributeRouting.AspNet;

namespace AttributeRouting.Mvc
{
    public class AttributeRoutingConfiguration : AspNetAttributeRoutingConfiguration<IController, UrlParameter>
    {
        public AttributeRoutingConfiguration()
            : base(() => new MvcRouteHandler())
        {           
        }
    }
}