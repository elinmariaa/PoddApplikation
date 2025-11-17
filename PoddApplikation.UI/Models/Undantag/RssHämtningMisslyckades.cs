using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Undantag
{
    public class RssHämtningMisslyckades : Exception
    {
        public RssHämtningMisslyckades(string message) : base(message) { }

    }
}
