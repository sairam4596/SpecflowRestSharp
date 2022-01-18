using Newtonsoft.Json;
using RestSharp;
using SpecflowRestSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace SpecflowRestSharp.Steps
{
    [Binding]
    public sealed class EmployeeControllerSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private string BaseURL = "https://be-java.azurewebsites.net";

        public EmployeeControllerSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"enter the endpoint url is (.*)")]
        public void GivenEnterTheEndpointUrlIs_(string endpoint)
        {
            RestCommon.InitialiseClient(BaseURL,endpoint);
        }

        [Given(@"i create (.*) request")]
        public void GivenICreate_Request(Method methodName)
        {
            RestCommon.CreateRequest(methodName);
        }

        [Given(@"I add the request body using the below params")]
        public void GivenIAddTheRequestBodyUsingTheBelowParams(Table table)
        {
            var requestBody = table.CreateInstance<EmployeeRequest>();
            string reqJsonBody = JsonConvert.SerializeObject(requestBody);

            RestCommon.AddRequestBody(reqJsonBody);
        }

        [When(@"i send the request")]
        public void WhenISendTheRequest()
        {
            RestCommon.Execute();
        }

        [Then(@"i validate the response status code (.*)")]
        public void ThenIValidateTheResponseStatusCode_(string statusDescription)
        {
            RestCommon.ValidateResponseCode(statusDescription);
        }

        [Given(@"i passed url parameter as (.*)")]
        public void GivenIPassedUrlParameterAs(int n)
        {
            RestCommon.AddUrlParameter(n);
        }


    }
}
