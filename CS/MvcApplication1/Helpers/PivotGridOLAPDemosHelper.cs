using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Helpers
{
    public class PivotGridOLAPDemosHelper
    {
        public static string OLAPConnectionString { get { return "Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;Initial Catalog=Adventure Works DW Standard Edition;Cube Name=Adventure Works;"; } }
    }
}