# CarBook Project Purpose

This project was developed as a reference implementation of Onion Architecture in an ASP.NET Core Web API application.
The main goal is to demonstrate how modern architectural approaches and design patterns can be applied in a real-world car rental system scenario.

The repository focuses on code quality, architectural structure, and best practices, rather than being a step-by-step tutorial.

## Scope of the Project

- Backend-focused implementation

- Real-world business scenario (Car Rental System)

- Scalable and maintainable API design

- Industry-oriented architectural decisions


## Key Concepts Demonstrated

- Onion Architecture with strict layer separation

- CQRS for handling read and write operations

- Mediator pattern for decoupled communication

- Repository pattern for data access abstraction

- DTO-based data transfer between layers


## Architecture Overview

The project follows Onion Architecture principles, where the core domain remains independent of external frameworks and infrastructure concerns.


## Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- MediatR
- FluentValidation
- JWT Authentication
- SignalR


## Setup

1. Clone the repository:
    ```bash
    git clone https://github.com/justcodess/CarBook.git
    ```

2. Open the project in Visual Studio.

3. Restore the necessary NuGet packages:
    ```bash
    dotnet restore
    ```

4. Update the database connection string in `appsettings.json` if necessary.

5. Run the project:
    ```bash
    dotnet run
    ```

6. The application will be available at http://localhost:7184 by default.
