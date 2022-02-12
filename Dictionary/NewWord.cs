using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class NewWord
    {
        public string Word { get; set; }
        public string Mean { get; set; }

        public override string ToString()
        {
            return Word;
        }

    }
}
