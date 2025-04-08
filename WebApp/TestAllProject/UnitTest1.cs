using Newtonsoft.Json;
using System.Net.Http.Json;

namespace TestAllProject
{
    [TestFixture]
    public class Tests
    {
        //private HttpClient _client;

        

        [SetUp]
        public  void Setup()
        {
           
        }

        [Test]
        public async Task Test1()
        {
            var _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44317/");
            var formBodyJson = JsonConvert.SerializeObject(new { UserName = "tungnx", Password = "Xtung@111" });
            var res = await _client.PostAsJsonAsync("Authen/login", formBodyJson);
            var a = 1;
            if (res.IsSuccessStatusCode)
            {
                Assert.Pass("Thanhf coong");

            }
            else
            {
                Assert.Fail("Thanhf coong");
            }
        }
    }
}