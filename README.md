# ClubRunner

Task 1: Windows Console Application
Write a Windows console application with the following functionality:
Function that accepts a single parameter of type Person (defined below) and returns how many of Person 
descendants are named "Steve". For example, if provided person has 3 children, one of whom is named Steve and 10 
grandchildren, 2 of whom are named Steve, then function should return 3.
Requirements are:
 Architecture of the application should support extensions to be used in the following (no code for the extensions 
required):
o Blazor application
o REST API
o Web (ASP.net MVC Core)
o Mobile (Xamarin Forms)
 Implement best practices for code style and solution organization
 Bonus Task: Implement localization prototype
The data structure is as follows:
class Person
{
 public string FirstName {get;set;}
 public Person[] Children {get;set;}
}
