using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Undantag
{
    public class InvalidRssUrl : Exception
    {
        public InvalidRssUrl(string message) : base(message) { }
    }
}
