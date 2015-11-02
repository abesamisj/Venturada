using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Venturada.UI.ViewModels
{
    public class Cookies
    {
        public static HttpCookie CreateAuthenticationCookie(
            string userName,
            string formsCookieName)
        {
            // Create authentication cookie and store roles in it
            string formsCookieStr = string.Empty;

            // Create a Forms Authentication ticket with the details
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(userName, false, 30);

            // get the encrypted representation suitable for placing in a HTTP cookie
            formsCookieStr = FormsAuthentication.Encrypt(ticket);

            HttpCookie FormsCookie = new HttpCookie(formsCookieName, formsCookieStr);

            return FormsCookie;
        }
    }
}