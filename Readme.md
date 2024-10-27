# Classroom Coding Challenge

This is an example solution based on the following coding challenge:

### Challenge ###

In this repository you will find a folder Data with work.csv and work.json. Both contain the same data, you only need to use one (whatever you find convenient). This file contains the work results of the children in one class over a month.
Create a report or screen or whatever that gives a teacher an overview of how his class worked today and what. It is now Tuesday 2015-03-24 11:30:00 UTC. The answers from after that time are therefore not yet shown.
Create a pull request in which you have included a readme that explains what you need to do to be able to view the result.

Background information
All times are in UTC
There is an attribute Progress. This gives the change in the assessment of the student's skill on a learning objective. There are psychometric models behind this that take into account the difficulty of the assignment, whether the assignment has already been done by this student, etc. There are several situations in which the Progress is 0. For example, if we do not yet have a good calibration of the difficulty of the assignment. Or if the student has not yet completed enough assignments in a learning objective to make a good estimate of the skill.
Since this dataset only shows changes and not absolute values, you cannot see from this dataset what the skill of each student is. This does not have to be reflected in the results.

### Overview ###

The solution exposes an API allowing the teacher to retrieve progress information for a given classroom and date.

This solution is scaffolded based on the AWS Lambda ASP.NET Core Web API template, found on the Amazon.Lambda.Templates namespace.
The initial dataset is found in the Data folder, work.json.
The dataset is imported into an EF core InMemory database.

### Public API ###

The API is available publicly at the following URL:
https://n7d2hzb5th.execute-api.us-east-1.amazonaws.com/Prod/api/classroom/10/2015-03-19%2010%3A30%3A00
The date can be changed, it is currently set to "Tuesday 2015-03-24 11:30:00 UTC" as specified in the challenge

### Running Locally ###

1. In your terminal window, browse to src\CodingChallenge.Classroom.Api directory.
2. Execute "dotnet run"
3. You can then open a browser and point to http://localhost:5000/api/classroom/10/2015-03-19%2010%3A30%3A00

### AWS CloudFormation Deployment ###
The cloudformation template can be found at src\CodingChallenge.Classroom.Api\template.yaml
By installing AWS toolkit for either Visual Studio or Rider, you can right click this file and deploy with your setup credentials.