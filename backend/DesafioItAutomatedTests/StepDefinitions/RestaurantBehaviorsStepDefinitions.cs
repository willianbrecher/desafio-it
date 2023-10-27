using DesafioIt.Domain.Models.Dishes;
using global::DesafioItAutomatedTests.StepDefinitions;
using Newtonsoft.Json;
using System.Net.Http;

namespace DesafioItAutomatedTests.StepDefinitions
{
    [Binding]
    public sealed class RestaurantBehaviorSteps : BaseSteps
    {
        public List<DishModel> LISTITENS = new List<DishModel>();
        public int COUNT;
        private HttpResponseMessage RESPONSE = new HttpResponseMessage();
        private const string ACCESS_API_LISTDISHES = "/api/dishes/pageable-list";
        PageableResult<DishModel> LISTOFITENS = new PageableResult<DishModel>();

        #region Scenario Viewing available dishes
        [Given("the user is on the homepage and the count of dishes list is (.*)")]
        public void GivenTheUserIsOnHomepage(int count)
        {
            COUNT = count;
        }

        [When("the page loads")]
        public async void WhenThePageLoadsWithListOfDishes()
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, string.Concat(new string[] { HOST_API_FOR_TESTS, ACCESS_API_LISTDISHES }));
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(LISTITENS));
            var reponse = await _httpClient.GetAsync(string.Concat(HOST_API_FOR_TESTS, ACCESS_API_LISTDISHES));
            if (RESPONSE.IsSuccessStatusCode)
            {
                var responseString = await reponse.Content.ReadAsStringAsync();
                var dishesList = JsonConvert.DeserializeObject<DishModel>(responseString);
                var result = new List<DishModel>();
                if (dishesList != null)
                {

                }
            }
        }

        [Then("the user should see a list of dishes with their names, descriptions, prices, and photos")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }
        #endregion

    }
}
