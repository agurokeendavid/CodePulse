# CodePulse

A full-stack blogging platform built with ASP.NET Core and Angular.

## 📋 Project Overview

CodePulse is a modern web application that allows users to create and manage blog posts with categories. The application features a RESTful API backend built with .NET 10.0 and a responsive frontend built with Angular 20.

## 🏗️ Architecture

### Backend (API)
- **Framework**: ASP.NET Core 10.0
- **Database**: SQL Server with Entity Framework Core
- **Architecture**: Repository Pattern
- **API Documentation**: Swagger/OpenAPI

### Frontend (UI)
- **Framework**: Angular 20.2
- **Styling**: Bootstrap 5.3.7
- **State Management**: RxJS

## 🚀 Features

- Category Management (CRUD operations)
- Blog Post Management
- RESTful API with Swagger documentation
- Responsive UI design
- Entity Framework Core migrations
- Repository pattern for data access

## 📁 Project Structure

```
CodePulse/
├── API/
│   └── CodePulse.API/
│       ├── CodePulse.API/
│       │   ├── Controllers/      # API Controllers
│       │   ├── Data/             # Database Context
│       │   ├── Migrations/       # EF Core Migrations
│       │   ├── Models/           # Domain Models & DTOs
│       │   │   ├── Domain/       # Domain Entities
│       │   │   └── DTO/          # Data Transfer Objects
│       │   ├── Repositories/     # Data Access Layer
│       │   │   ├── Implementation/
│       │   │   └── Interface/
│       │   └── Program.cs        # Application Entry Point
│       └── CodePulse.API.slnx    # Solution File
└── UI/
    └── CodePulse/
        ├── src/
        │   └── app/              # Angular Components
        ├── angular.json          # Angular Configuration
        └── package.json          # Node Dependencies
```

## 🛠️ Prerequisites

### Backend
- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB, Express, or Full)
- Visual Studio 2022 or Visual Studio Code

### Frontend
- [Node.js](https://nodejs.org/) (v18 or later)
- [Angular CLI](https://angular.io/cli) (v20 or later)

## 📦 Installation & Setup

### 1. Clone the Repository
```bash
git clone <repository-url>
cd CodePulse
```

### 2. Backend Setup

#### Configure Database Connection
1. Navigate to `API/CodePulse.API/CodePulse.API/`
2. Update `appsettings.json` with your SQL Server connection string:
```json
{
  "ConnectionStrings": {
    "CodePulseConnectionString": "Server=localhost;Database=CodePulseDb;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

#### Run Migrations
```bash
cd API/CodePulse.API/CodePulse.API
dotnet ef database update
```

#### Start the API
```bash
dotnet run
```

The API will be available at:
- HTTPS: `https://localhost:7xxx`
- HTTP: `http://localhost:5xxx`
- Swagger UI: `https://localhost:7xxx/swagger`

### 3. Frontend Setup

#### Install Dependencies
```bash
cd UI/CodePulse
npm install
```

#### Start the Development Server
```bash
npm start
# or
ng serve
```

The application will be available at `http://localhost:4200`

## 🔧 Configuration

### API Configuration
- **appsettings.json**: Production configuration
- **appsettings.Development.json**: Development-specific settings
- **launchSettings.json**: Launch profiles and ports

### Frontend Configuration
- **angular.json**: Angular workspace configuration
- **environment files**: Environment-specific settings (if applicable)

## 📝 API Endpoints

### Categories
- `GET /api/categories` - Get all categories
- `GET /api/categories/{id}` - Get category by ID
- `POST /api/categories` - Create new category
- `PUT /api/categories/{id}` - Update category
- `DELETE /api/categories/{id}` - Delete category

*For complete API documentation, visit the Swagger UI when running the application.*

## 🗄️ Database Schema

### Category
- Id (Guid)
- Name (string)
- UrlHandle (string)

### BlogPost
- Id (Guid)
- Title (string)
- ShortDescription (string)
- Content (string)
- FeaturedImageUrl (string)
- UrlHandle (string)
- PublishedDate (DateTime)
- Author (string)
- IsVisible (bool)
- Categories (Collection)

## 🧪 Running Tests

### Backend Tests
```bash
cd API/CodePulse.API/CodePulse.API
dotnet test
```

### Frontend Tests
```bash
cd UI/CodePulse
npm test
```

## 🏗️ Building for Production

### Backend
```bash
cd API/CodePulse.API/CodePulse.API
dotnet publish -c Release -o ./publish
```

### Frontend
```bash
cd UI/CodePulse
npm run build
```

Build artifacts will be stored in the `dist/` directory.

## 🛠️ Technologies Used

### Backend
- ASP.NET Core 10.0
- Entity Framework Core 10.0
- SQL Server
- Swagger/OpenAPI
- C# 13

### Frontend
- Angular 20.2
- TypeScript 5.9
- Bootstrap 5.3.7
- RxJS 7.8

## 📚 Development Guidelines

### Backend
- Follow Repository Pattern for data access
- Use DTOs for API responses
- Implement proper error handling
- Use dependency injection
- Follow RESTful API conventions

### Frontend
- Use Angular standalone components
- Follow Angular style guide
- Implement proper type safety with TypeScript
- Use RxJS for async operations

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 👥 Authors

- Your Name - Initial work

## 🙏 Acknowledgments

- Built with ASP.NET Core and Angular
- Bootstrap for styling
- Entity Framework Core for data access

## 📞 Support

For issues and questions, please open an issue in the GitHub repository.

---

**Happy Coding! 🚀**

