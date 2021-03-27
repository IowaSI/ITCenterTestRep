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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static Task<User> GetUserInfo(string user_name)
        {
            log.Info("API: GetUserInfo");

            var productInformation = new ProductHeaderValue(user_name);
            var credentials = new Credentials("5893ff5f8e432b98ebff5f7869dabd32b4bddac3"); // po 24h (?) przestaje działać więc trzeba zmienić token
            var client = new GitHubClient(productInformation) { Credentials = credentials };
            var user = client.User.Get(user_name);
            
            return user;
        }

        public static Repository GetAppInfo()
        {
            log.Info("API: GetAppInfo");

            var productInformation = new ProductHeaderValue("IowaSI");
            var credentials = new Credentials("5893ff5f8e432b98ebff5f7869dabd32b4bddac3"); // po 24h (?) przestaje działać więc trzeba zmienić token
            var client = new GitHubClient(productInformation) { Credentials = credentials };
            
            var user = client.Repository.Get("IowaSI", "ITCenterTestRep").Result;

            return user;
        }
    }
}
