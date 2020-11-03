using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
  public static  class Extension
    {
        public static bool isEmail(this string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
