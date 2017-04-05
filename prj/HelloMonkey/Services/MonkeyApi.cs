using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelloMonkey.Models;
using Microsoft.WindowsAzure.MobileServices;
using System.Linq;

namespace HelloMonkey.Services
{
    public class MonkeyApi
    {
        MobileServiceClient mobileServiceClient =
                new MobileServiceClient(@"http://hellomonkeys.azurewebsites.net");

        public async Task<List<Monkey>> GiveMeTheMonkeysAsync(Developer developer)
        {
            var monkeys = await mobileServiceClient
                .InvokeApiAsync<Developer, List<Monkey>>("monkeys", developer);

            return monkeys.OrderBy(m => m.Name).ToList();
        }
    }
}
