using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_duplicator_to_cloud.Models
{
    public interface IDate
    {
        public string FormattedDate { get; }
        string Get();
    }
}
