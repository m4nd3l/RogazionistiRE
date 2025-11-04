using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogazionistiRE.Util
{
    class MyString {

        private string baseString;

        public MyString(string baseString) {
            this.baseString = baseString;
        }

        public string convertToString() {
            return baseString;
        }
    }
}
