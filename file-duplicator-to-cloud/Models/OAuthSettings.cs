using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_duplicator_to_cloud.Models
{
    public class OAuthSettings
    {
        public string TwitterApiKey { get; set; }
        public string TwitterApiSecret { get; set; }
        public string BearerToken { get; set; }
    }
}
