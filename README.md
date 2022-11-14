# APITestsCatAPI

This repository contains an API C# Selenium test framework.
This framework is built with C#, RestSharp and Nunit. The request and response class objects are seperated into their own classes.

## Tools

Visual Studio, C#, RestSharp, Nunit mainly.

## Assumptions

Created tests with for each of the favourites apis with some assertions on each. 

## Writing Test Cases

Tests are written in the CatAPI_Tests.cs file in the APITestsCatAPI project. The api functions are contained within the Services project in the CATAPIs folder. Here the responses are retrieved from respective apis. The APITestsCatAPI has reference to the Services project to be able to access to these.

## Executing tests
  
Test can be executed from either the test class by right clicking on the base test function and clicking run. The tests can also be run from the command line using the following command - dotnet test --logger:nunit from csproj location. The command will produce an xml file. Would need to check run settings equivalent in VS.
I have placed comments above the save, delete and get specific favourite test functions. These require ids to be passed in order to run successfully. I have put some Ids in the comments so they can be run.
  
## Class Objects

Class objects have been created for most api responses or requests where applicable. This allows to deserialize the api response and perform assertions easier. Similar for the request body, removes chance of error from json strings.


