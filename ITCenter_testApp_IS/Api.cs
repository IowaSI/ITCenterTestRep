using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace ITCenter_testApp_IS
{
    public class Api
    {
       public static Task<User> GetUserInfo(string user_name)
       {
            var productInformation = new ProductHeaderValue(user_name);
            var credentials = new Credentials("b7614be81922f95cf38dadff85e5dcccc8e85ab6");
            var client = new GitHubClient(productInformation) { Credentials = credentials };
            var user = client.User.Get(user_name);
            
            return user;
       }

        public static Repository GetAppInfo()
        {
            var productInformation = new ProductHeaderValue("IowaSI");
            var credentials = new Credentials("b7614be81922f95cf38dadff85e5dcccc8e85ab6");
            var client = new GitHubClient(productInformation) { Credentials = credentials };

            var user = client.Repository.Get("IowaSI", "ITCenterTestRep").Result;

            return user;
        }
    }
}
