using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppData.Ultilities
{
    public class Validation
    {
        public bool CheckString(string s)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$"); 
            return regexItem.IsMatch(s);
        }
        public bool CheckEmail(string email)
        {
            if (new EmailAddressAttribute().IsValid(email)) return true;
            return false;
        }


    }
}
