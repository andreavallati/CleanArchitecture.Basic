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

## Architecture

### Clean Architecture Layers

```
┌─────────────────────────────────────────────┐
│           Presentation Layer                │
│  (API Controllers / WPF Views & ViewModels) │
└─────────────────────────────────────────────┘
                    ↓
┌─────────────────────────────────────────────┐
│           Application Layer                 │
│   (Services, Interfaces, Validation)        │
└─────────────────────────────────────────────┘
                    ↓
┌─────────────────────────────────────────────┐
│          Infrastructure Layer               │
│  (Repositories, Data Access, Connectors)    │
└─────────────────────────────────────────────┘
                    ↓
┌─────────────────────────────────────────────┐
│             Domain Layer                    │
│        (Entities, Domain Logic)             │
└─────────────────────────────────────────────┘
```

### Dependency Flow

- **Presentation** depends on **Application**
- **Application** depends on **Domain**
- **Infrastructure** implements **Application** interfaces
- **Domain** has no dependencies (pure business logic)

---

## Technologies Used

### Backend (API)

| Technology | Purpose |
|------------|---------|
| **.NET 8** | Runtime framework |
| **ASP.NET Core** | Web API framework |
| **Entity Framework Core** | ORM for data access |
| **SQL Server** | Database |
| **Newtonsoft.Json** | JSON serialization |
| **Swagger/OpenAPI** | API documentation |

### Frontend (Client)

| Technology | Purpose |
|------------|---------|
| **WPF (.NET 8)** | Desktop UI framework |
| **MVVM Pattern** | UI architecture |
| **HttpClient** | HTTP communication |
| **Dependency Injection** | IoC container |

---

## Project Structure

### CleanArchitecture.Basic.Api (Web API)

```
CleanArchitecture.Basic.Api/
├── Domain/
│   └── Entities/
│       └── Product.cs              # Core business entity
├── Application/
│   ├── Interfaces/
│   │   ├── Services/
│   │   │   └── IProductService.cs  # Application service contract
│   │   └── Repositories/
│   │       └── IProductRepository.cs # Repository contract
│   └── Services/
│       └── ProductService.cs       # Business logic orchestration
├── Infrastructure/
│   ├── Data/
│   │   └── ProductDbContext.cs     # EF Core DbContext
│   └── Repositories/
│       └── ProductRepository.cs    # Data access implementation
├── Presentation/
│   └── Controllers/
│       └── ProductsController.cs   # HTTP API endpoints
└── Program.cs                       # DI configuration & app setup
```

### CleanArchitecture.Basic.Client (WPF Application)

```
CleanArchitecture.Basic.Client/
├── Domain/
│   └── Entities/
│       └── Product.cs              # Client-side entity model
├── Infrastructure/
│   ├── Interfaces/
│   │   └── IUIService.cs           # API client contract
│   └── Services/
│       └── UIService.cs            # HTTP client implementation
├── Presentation/
│   ├── Interfaces/
│   │   └── IMainViewModel.cs       # ViewModel contract
│   ├── ViewModels/
│   │   └── MainViewModel.cs        # MVVM ViewModel with commands
│   └── Views/
│       └── MainWindow.xaml(.cs)    # WPF View
├── Helpers/
│   └── Constants.cs                # Configuration constants
└── App.xaml.cs                     # DI configuration & app startup
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

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQL Server (LocalDB, Express, or full version)
- Visual Studio 2022 or later (recommended)

### Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/andreavallati/CleanArchitecture.Basic.git
   cd CleanArchitecture.Basic
   ```

2. **Configure Database Connection**
   
   Update `appsettings.json` in the API project with your SQL Server connection string:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=CleanArchitectureDb;Trusted_Connection=true;"
     }
   }
   ```

3. **Create Database**
   
   Open Package Manager Console in Visual Studio and run:
   ```powershell
   Add-Migration InitialCreate
   Update-Database
   ```

4. **Run the API**
   
   Set `CleanArchitecture.Basic.Api` as startup project and run (F5)
   - Swagger UI will be available at: `https://localhost:7036/swagger`

5. **Update Client Endpoint** (if needed)
   
   In `CleanArchitecture.Basic.Client/Helpers/Constants.cs`, verify the API URL matches your API port:
   ```csharp
   public const string WebServiceEndpoint = "https://localhost:7036";
   ```

6. **Run the Client**
   
   Set `CleanArchitecture.Basic.Client` as startup project and run (F5)

---

<div align="center">

**Happy Coding!**

</div>
