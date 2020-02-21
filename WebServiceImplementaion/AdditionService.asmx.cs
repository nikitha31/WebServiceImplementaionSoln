using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceImplementaion
{
    /// <summary>
    /// Summary description for AdditionService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AdditionService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(int num1,int num2)
        {
            return num1+num2;
        }
    }
}
