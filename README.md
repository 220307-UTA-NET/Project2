# Pet Sitters Website

## Project Design and Outline

-ASP.NET Core REST service
  - owns the business logic of the application
  - doesn't trust the client to not be maliciously modified by a user
  - follow standard HTTP uniform interface (hypermedia not required)
  - define the REST resources/URLs/HTTP interface in documentation
  - good use of ASP.NET Core abstractions (e.g. dependency injection)
  - good architecture, separation of concerns
  - deployed to Azure App Service
  - use Entity Framework Core for data access, not ADO.NET
  - DB should be on the cloud and normalized
  - define the database design in documentation or a SQL script
  - all DB/network access should be async
  - server-side validation
  - logging of exceptions and other events
  - (recommended: support filtering and pagination on collection resources that could get large)
  - (optional: implement an API Description Language, e.g. with Swashbuckle / Swagger, and put effort into its correctness)
  - (optional: implement a custom filter, health check, or middleware, e.g. exception-handling middleware)

- Angular single-page application

  - good use of Angular abstractions (component, service injection, data binding, & HttpClient)
  - client-side validation
  - error handling on requests to APIs
  - deployed to Azure App Service, hosted separately from the REST service
  - supports deep links

- GitHub Actions
  - CI/CD pipelines
    - Unit tests
    - SonarCloud
      - Code coverage at least 30% for API and for Angular app
      - Reliability/Security/Maintainability at A
  - secure authentication and authorization are not required; but Okta and Auth0 are services you could use for it
  - (optional: calls a third-party API, or integrates with some other service)

- Scrum processes
  - Project board to track user stories across team. (no requirements on how detailed)
  -  Standup at least two or three times a week
- any other tech you want within reason
- the data model (how many tables, what kind of complex relationship like N to N) must be at least as complicated as project 1.
- the user interaction model (what are the user stories, what inputs/interactions can the user make) must be at least as complicated as project 1.
- a project proposal
  - MVP minimum viable product
  - some stretch goals, extra features



## Project Description

The concept behind our project was to create an application that connected pet sitters and pet owners. Our service would allow pet sitters to search through the jobs that pet owners would create. We used Angular services to create our web application, which communicated to a remote SQLServer database hosted by Azure with the use of Web API. We used Http methods to implement the CRUD functionalities necessary to persist data in our web application, allowing for communication with our database to post and request different forms of data, including photos to give users the ability to share  their pet photos with pet sitters. We also were able to ensure the quality of our program with unit tests written in Jasmine and tested with the Karma test runner.



## Technologies Used
- Angular - version 13.0.0
- Entity Framework - version 6.2.0
- SQL Server Database - version 12.0.2000.8
- .NET version 6.0




## Contributors
Christian, Tahereh, Kelly, Zhixin, and Bruk
