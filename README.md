# DapperExample

**DapperExample** is a modular, layered architecture project built with **ASP.NET Core** and **Dapper**. It demonstrates how to implement **CRUD (Create, Read, Update, Delete)** operations using lightweight and efficient database interactions with Dapper.

---

## Project Structure

The project is organized into the following layers to ensure separation of concerns and maintainability:

1. **DapperExample.Presentation**  
   - The presentation layer that handles incoming HTTP requests and outgoing responses.
   - Provides RESTful API endpoints through controllers.
   - Includes Swagger/OpenAPI for API documentation and testing.

2. **DapperExample.Application**  
   - Contains application logic and business rules.
   - Manages interactions between the **Presentation** and **Infrastructure** layers.
   - Provides service classes for business operations.

3. **DapperExample.Domain**  
   - Defines core business logic, domain entities, and value objects.
   - Represents the core of the application, completely independent of external dependencies.

4. **DapperExample.Infrastructure**  
   - Handles data access and persistence.
   - Implements repositories using Dapper for executing SQL queries.
   - Manages database connections and query execution.

---

## Technologies Used

- **.NET Core 8**  
- **Dapper** (for lightweight and efficient database interaction)  
- **SQL Server** (as the database)  
- **Swagger/OpenAPI** (for API documentation)

---

## Features

- **CRUD Operations**: Implements Create, Read, Update, and Delete functionality for domain entities.
- **Dapper Integration**: Utilizes Dapper for fast and lightweight SQL query execution.
- **Layered Architecture**: Ensures modularity, separation of concerns, and scalability.
- **API Documentation**: Comprehensive Swagger integration for easy API exploration and testing.
