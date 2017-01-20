using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matrix.Web.Models.Client
{
    public class VersionsResponse
    {
        public List<string> Versions
        {
            get
            {
                return new List<string>
                    {
                        "r0.2.0"
                    };
            }
        }
    }
}