using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTipApi
{
    public class GitTipClient
    {
        public string ApiKey { get; set; }

        public GitTipClient()
        {
            
        }
        
        public GitTipClient(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
}
