# StarWarsTroopers
Netcore technical test for SAGE R+D

## Scenario

This is David Rubio technical test about .NET Microservices in AWS Lambda Serverless technology, if i understood TestMiDev.md document.

First, after study and evaluate AWS Lambda Serverless approach, i decide is too complex for a newby to perform in 1 hour of job. 

So, understanding my shortcomings, i concentrate in develop a solution that can be easly deployed in serverless environment, and all design decissions move around it.

Then, i describe job done in following section, linking resources used to do every part.

## Plan

In order to do the best solution i can, i decide to develop 2 solutions: 
1 - A NetCore WebAPI solution to implement data service describe in requirements,
2 - A xUnit Testing application for WebAPI integration testings,

## WebAPI StarWarsTroopers
To implement this WebAPI following requeriments, we decide to use a mysql database that can be easly implemented in AWS serverless and use the capabilities of DbContext 
object to create structure if database not exists. 

The steps followed to create solution:
1. Create a WebAPI Solution,
2. Add MySql support to project,
3. Define Trooper and TrooperCon data model,
4. Define Trooper context with table population,
5. Create Trooper CRUD controller with EF scarfoolding,
6. Create custom TrooperCon controller access point,
7. Add Swagger for unit testings,
8. Configure project startup for testings,
9. Review class definitions and documentation,
10. Run project and perform unit tests,

I used following sources from internet:
1. WebAPI netcore: https://docs.microsoft.com/es-es/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio
2. EF Mysql: https://www.c-sharpcorner.com/article/tutorial-use-entity-framework-core-5-0-in-net-core-3-1-with-mysql-database-by2/
3. Swagger: https://docs.microsoft.com/es-es/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-5.0&tabs=visual-studio

And also read and prepare an AWS account that i finally don't use, following this instructions:
1. AWS Lambda: https://dev.to/sunilkumarmedium/build-a-serverless-dotnet-core-web-api-with-aws-lambda-and-api-gateway-22dd
2. AWS CI/CD: https://aws.amazon.com/es/blogs/devops/automated-ci-cd-pipeline-for-net-core-lambda-functions-using-aws-extensions-for-dotnet-cli/

## WebAPI Integration Testings
This project is used for WebAPI integration testing, necessary development for AWS Lambda API deployment in real world. 

But this is only a try, using following documentation:
https://fullstackmark.com/post/20/painless-integration-testing-with-aspnet-core-web-api

After spend 20 minutes, i can't correctly config NuGet dependencies from my local developer machine (see PNG from root)

## Source code and results
The source code is contained in private github project https://github.com/codi-ninja/StarWarsTroopers.git; send me an email to allow you to access.

The results are poor in my opinion, and finish a little bit frusted, but this is an interesting technology that i want to play.



