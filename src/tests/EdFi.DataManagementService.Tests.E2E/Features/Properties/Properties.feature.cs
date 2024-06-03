﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EdFi.DataManagementService.Tests.E2E.Features.Properties
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Validate Extra Properties are being removed")]
    public partial class ValidateExtraPropertiesAreBeingRemovedFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Properties.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, NUnit.Framework.TestContext.CurrentContext.WorkerId);
            global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Properties", "Validate Extra Properties are being removed", "    Tests that perform POST and PUT requests with extra properties,\r\n    paired w" +
                    "ith a GET request that proves the extra properties have been removed", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            await testRunner.OnFeatureEndAsync();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        public virtual async System.Threading.Tasks.Task FeatureBackgroundAsync()
        {
#line 5
        #line hidden
#line 6
             await testRunner.WhenAsync("a POST request is made to \"ed-fi/academicWeeks\" with", @"{
  ""weekIdentifier"": ""LastWeek"",
  ""schoolReference"": {
    ""schoolId"": 255901001,
    ""link"": {
      ""rel"": ""School"",
      ""href"": ""/ed-fi/schools/20ec19e5070245128a30fdcc6925bb09""
      }
  },
  ""beginDate"": ""2024-05-30"",
  ""endDate"": ""2024-05-30"",
  ""totalInstructionalDays"": 0,
  ""_etag"": ""5250168731208835753"",
  ""_lastModifiedDate"": ""2024-05-30T22:30:57.509Z""
}", ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 24
             await testRunner.ThenAsync("it should respond with 201", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 25
              await testRunner.AndAsync("the response headers includes", "{\r\n  \"location\": \"/ed-fi/academicWeeks/{id}\"\r\n}", ((global::Reqnroll.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate extra properties are being removed on POST")]
        [NUnit.Framework.CategoryAttribute("properties")]
        public async System.Threading.Tasks.Task ValidateExtraPropertiesAreBeingRemovedOnPOST()
        {
            string[] tagsOfScenario = new string[] {
                    "properties"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Validate extra properties are being removed on POST", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
        this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
        await this.FeatureBackgroundAsync();
#line hidden
#line 34
             await testRunner.WhenAsync("a GET request is made to \"ed-fi/academicWeeks/{id}\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 35
             await testRunner.ThenAsync("it should respond with 200", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 36
              await testRunner.AndAsync("the response body is", "{\r\n  \"weekIdentifier\": \"LastWeek\",\r\n  \"schoolReference\": {\r\n    \"schoolId\": 25590" +
                        "1001\r\n  },\r\n  \"beginDate\": \"2024-05-30\",\r\n  \"endDate\": \"2024-05-30\",\r\n  \"totalIn" +
                        "structionalDays\": 0\r\n}", ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate extra properties are being removed on PUT")]
        [NUnit.Framework.CategoryAttribute("properties")]
        public async System.Threading.Tasks.Task ValidateExtraPropertiesAreBeingRemovedOnPUT()
        {
            string[] tagsOfScenario = new string[] {
                    "properties"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Validate extra properties are being removed on PUT", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 50
        this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
        await this.FeatureBackgroundAsync();
#line hidden
#line 51
             await testRunner.WhenAsync("a PUT request is made to \"ed-fi/academicWeeks/{id}\" with", @"{
  ""id"": ""{id}"",
  ""weekIdentifier"": ""LastWeek"",
  ""schoolReference"": {
    ""schoolId"": 255901001,
    ""link"": {
      ""rel"": ""School"",
      ""href"": ""/ed-fi/schools/20ec19e5070245128a30fdcc6925bb09""
     }
  },
  ""beginDate"": ""2024-05-30"",
  ""endDate"": ""2024-06-30"",
  ""totalInstructionalDays"": 0,
  ""_etag"": ""5250168731208835753"",
  ""_lastModifiedDate"": ""2024-05-30T22:30:57.509Z""
}", ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 70
             await testRunner.ThenAsync("it should respond with 204", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 71
             await testRunner.WhenAsync("a GET request is made to \"ed-fi/academicWeeks/{id}\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 72
             await testRunner.ThenAsync("it should respond with 200", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 73
              await testRunner.AndAsync("the response body is", "{\r\n  \"id\": \"{id}\",\r\n  \"weekIdentifier\": \"LastWeek\",\r\n  \"schoolReference\": {\r\n    " +
                        "\"schoolId\": 255901001\r\n  },\r\n  \"beginDate\": \"2024-05-30\",\r\n  \"endDate\": \"2024-06" +
                        "-30\",\r\n  \"totalInstructionalDays\": 0\r\n}", ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion