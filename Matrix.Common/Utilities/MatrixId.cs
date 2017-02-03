using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Common.Utilities
{
    public class MatrixId
    {
        public string Username { get; set; }
        public string HomeServer { get; set; }

        public MatrixId(string usernameOrId, string homeServer)
        {
            if(usernameOrId.StartsWith("@"))
            {
                var colonIndex = usernameOrId.IndexOf(":");
                
                this.Username = new string(usernameOrId.Skip(1).TakeWhile(c => c != ':').ToArray());
                this.HomeServer = new string(usernameOrId.SkipWhile(c => c != ':').Skip(1).ToArray());
            }
            else
            {
                this.Username = usernameOrId;
                this.HomeServer = HomeServer;
            }
        }
    }
}
