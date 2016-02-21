using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhAppsSpike
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var client = new GitHubClient(new ProductHeaderValue("Spike"));
                var basicAuth = new Credentials("", "");
                client.Credentials = basicAuth;


                var authorizations = client.Authorization.GetAll().Result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
