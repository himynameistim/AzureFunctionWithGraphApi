# Azure Function With GraphApi

This is a demo implementation of how to create a Graph QL API using Azure Functions with Hot Chocolate.

When I started learning how to implement HotChocolate I found that most examples relied on HotChocolate directly querying Entity Framework. However given that it is bad practice for an API to be based on a database structure, real world scenarios are more likely to use some form of data access layer and therefore the logic for loading related items would be needed.

While Hot Chocolate state that they support Azure Functions, most examples (in fact all the documentation) is based around creating an ASP.NET Core application. While this demo does work, at time of writing it should be noted that not all Hot chocolates functionality is written for Azure Functions, most notable anything to do with Authentication.

## Features of the Demo
- Functioning Graph QL API
- .NET 6 based Azure Functions
- Queries can load related items
- Not reliant on Entity Framework, uses a custom data access layer

## Structure of the data

The data in the demo contains schools, classes and students. A school can contain multiple classes and each class can have multiple students.
