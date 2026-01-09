# Clean Architecture Basic

## Overview
CleanArchitecutre.Basic is a basic implementation of the Clean Architecture principles in a .NET application. It consists of an API and a client application, structured to ensure maintainability, scalability, and testability.

---

## Features
- Follows Clean Architecture principles
- Modular structure with clear separation of concerns
- RESTful API implementation
- Client application using MVVM pattern
- Dependency injection for service management

---

## Technologies Used
- .NET Core
- Entity Framework Core
- ASP.NET Core Web API
- WPF with MVVM Pattern for Client

---

## Project Structure
```
CleanArchitecture.Basic
│── CleanArchitecture.Basic.sln                # Solution file
│
├── CleanArchitecture.Basic.Api                # API project
│   ├── Application                            # Application layer
│   │   ├── Interfaces                         # Abstractions
│   │   ├── Services                           # Business logic
│   ├── Domain                                 # Domain entities
│   ├── Infrastructure                         # Data persistence
│   ├── Presentation                           # API Controllers
│
├── CleanArchitecture.Basic.Client             # Client application
│   ├── Domain                                 # Business models
│   ├── Infrastructure                         # Services & Interfaces
│   ├── Presentation                           # Views and ViewModels
```

---

## API Endpoints
| Method | Endpoint       | Description       |
|--------|----------------|-------------------|
| GET    | /products      | Get all products  |
| GET    | /products/{id} | Get product by ID |
| POST   | /products      | Add a product     |

---

## Installation
### Prerequisites
- .NET SDK 6.0 or later
- SQL Server (if using database authentication)

### Steps
1. Clone the repository:
   ```sh
   git clone <repository-url>
   cd CleanArchitecture.Basic
   ```
2. Install dependencies:
   ```sh
   dotnet restore
   ```
3. Modify `appsettings.json` to set the correct connection string for SQL Server:
   ```sh
   "DefaultConnection": "Server=(localdb)\\YourInstance;Database=YourDatabase;Trusted_Connection=True;"
   ```

## Usage
1. Run the API project:
   ```sh
   dotnet run --project CleanArchitecture.Basic.Api
   ```
2. Run the client application in Visual Studio.

---

<div align="center">

**Happy Coding!**

</div>
