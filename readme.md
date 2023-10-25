# TrelloX

TrelloX is an application built in .NET 7 following the Clean Architecture. This application is designed to efficiently manage tasks and projects.

## Project Structure

The project is organized into several layers, following the principles of Clean Architecture:

- **TrelloX.Application:** This layer contains application logic, including CQRS handlers and MediatR commands/queries.

- **TrelloX.Domain:** Here, entities, aggregates, and business rules of the application are defined.

- **TrelloX.Infrastructure:** This layer implements technical details and infrastructure, such as database access, external services, and other infrastructure components.

- **TrelloX.WebApi:** The presentation layer, providing an interface to interact with the application via a web API.

- **src:** This folder contains the source files of the project. You can add tests and other resources here.

## Requirements

Make sure you have .NET 7 installed to run the application.

## Installation

1. Clone the TrelloX repository on your local machine:

   ```bash
   $ https://github.com/iiimatos/TrelloX.git
   $ cd TrelloX

2. Run project, if you use visual studio code:
   ```bash
   $ dotnet run --project .\src\TrelloX.WebApi\

## Coming Soon!!!

1. Unit Testing.
