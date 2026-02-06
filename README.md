# Silver Screen - Cinema Management System

<div align="center">

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-purple)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-6.5.1-blue)
![DevExpress](https://img.shields.io/badge/DevExpress-WinForms-orange)
![License](https://img.shields.io/badge/License-MIT-green)

**Professional cinema management system - Windows Forms application**

[Features](#-features) • [Installation](#-installation) • [Usage](#-usage) • [Architecture](#-architecture) • [Contributing](#-contributing)

</div>

---

## 📋 Table of Contents

- [Overview](#-overview)
- [Features](#-features)
- [Technologies](#-technologies)
- [System Requirements](#-system-requirements)
- [Installation](#-installation)
- [Usage](#-usage)
- [Architecture](#-architecture)
- [Database Structure](#-database-structure)
- [Screenshots](#-screenshots)
- [Development](#-development)
- [Contributing](#-contributing)
- [License](#-license)
- [Contact](#-contact)

---

## 🎬 Overview

**Silver Screen** is a comprehensive management system developed for cinema businesses. It combines all cinema operations such as movie management, customer tracking, reservation system, payment processing, and financial reporting in a single platform.

### Core Objectives

- ✅ Movie and showtime management
- ✅ Customer information tracking
- ✅ Reservation and ticket sales
- ✅ Payment processing and cash register management
- ✅ Financial reporting and analysis
- ✅ User authorization system

---

## ✨ Features

### 🎥 Movie Management
- Add, edit, and delete movies
- Movie genre and duration information
- Filter movies currently showing
- View and search movie list

### 👥 Customer Management
- Customer registration and updates
- Contact information tracking
- View customer history
- Customer search and filtering

### 🎫 Reservation System
- Create showtime-based reservations
- Seat selection and status tracking
- View reservation list
- Cancel reservations

### 💳 Payment and Financial Operations
- Process reservation payments
- Cash register transaction records
- Daily revenue reports
- Movie-based revenue analysis
- End-of-day closing operations

### 📊 Reporting and Analytics
- Daily revenue reports
- Movie performance statistics
- Occupancy rate analysis
- View transaction history

### 🔐 User Management
- Role-based authorization (Admin, Cashier)
- Secure login system
- User session management

---

## 🛠 Technologies

### Backend
- **.NET Framework 4.7.2** - Main framework
- **Entity Framework 6.5.1** - ORM and database access
- **Code First Migrations** - Database versioning

### Frontend
- **Windows Forms** - Desktop application interface
- **DevExpress WinForms** - Advanced UI components
- **MDI (Multiple Document Interface)** - Multiple form management

### Database
- **SQL Server Express** - Relational database
- **Entity Framework Code First** - Database modeling

### Architectural Patterns
- **Layered Architecture** - Multi-layer architecture
- **Repository Pattern** - Data access abstraction
- **Service Pattern** - Business logic abstraction
- **Dependency Injection** - Dependency management

---

## 💻 System Requirements

### Minimum Requirements
- **Operating System:** Windows 7 SP1 or higher
- **.NET Framework:** 4.7.2 or higher
- **SQL Server:** SQL Server Express 2012 or higher
- **RAM:** 2 GB (recommended: 4 GB)
- **Disk Space:** 500 MB free space

### Development Environment
- **Visual Studio:** 2019 or higher
- **SQL Server Management Studio:** For database management
- **DevExpress WinForms:** For UI components

---

## 🚀 Installation

### 1. Clone the Repository

```bash
git clone https://github.com/Kaaner4mir/silver-screen.git
cd silver-screen
```

### 2. Database Configuration

1. Ensure SQL Server Express is installed
2. Check the connection string in `SilverScreen/App.config`:

```xml
<connectionStrings>
  <add name="SilverScreenEFContext" 
       connectionString="Data Source=.\SQLEXPRESS;initial catalog=SilverScreen_V4_FINAL;integrated security=true" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

3. The database will be automatically created and seed data will be loaded.

### 3. Install NuGet Packages

In Visual Studio:
1. Right-click on the Solution
2. Select **"Restore NuGet Packages"**

Or from Package Manager Console:
```powershell
Update-Package -reinstall
```

### 4. Build the Project

```bash
# In Visual Studio
Build > Build Solution (Ctrl+Shift+B)

# or from command line
msbuild SilverScreen.sln /t:Build /p:Configuration=Release
```

### 5. Run the Application

1. Set `SilverScreen` project as startup project
2. Press **F5** or **Debug > Start Debugging**

### Default User Credentials

Users automatically created on first run:

| Username | Password | Role |
|----------|----------|------|
| `admin` | `123` | Admin |
| `cashier1` | `123` | Cashier |

⚠️ **Security Warning:** Always change passwords in production environment!

---

## 📖 Usage

### Logging In

1. When you start the application, the login screen opens
2. Enter your username and password
3. Click the **Login** button

### Movie Management

#### Adding a Movie
1. Select **Movies > Add Movie** from the main menu
2. Fill in the movie information:
   - Movie name
   - Genre (Action, Sci-Fi, etc.)
   - Duration (minutes)
   - Release date
3. Click the **Save** button

#### Movie List
- You can view all movies from **Movies > List Movies** menu
- Search and filtering features are available
- Only movies currently showing are displayed

### Creating a Reservation

1. Select **Reservations > Make a Reservation** menu
2. Select a showtime (Movie, Hall, Time)
3. Select a customer or add a new customer
4. Select an available seat
5. Click the **Save** button

### Processing Payment

1. Select **Reservations > Take Payment** menu
2. Select the reservation to be paid
3. Click the **Take Payment** button
4. Payment is successfully recorded

### Reporting

1. Select **Reports > Financial Module** menu
2. Daily revenue, movie statistics, and transaction summary are displayed
3. Click **Refresh** button to load current data

### Closing the Day

1. At the end of the day, click the **Close Day** button
2. Accept the confirmation message
3. Daily summary is saved

---

## 🏗 Architecture

### Layered Architecture Structure

```
SilverScreen/
├── SilverScreen.UI/              # Presentation Layer
│   ├── Forms/                    # Windows Forms
│   │   ├── MovieForms/          # Movie management forms
│   │   ├── CustomerForms/       # Customer management forms
│   │   ├── ReservationsForms/   # Reservation forms
│   │   └── FinancialForms/      # Financial forms
│   └── Program.cs               # Application entry point
│
├── SilverScreen.Business/        # Business Logic Layer
│   └── Services/                # Business logic services
│       ├── AuthService.cs       # Authentication
│       ├── MovieService.cs      # Movie operations
│       ├── CustomerService.cs   # Customer operations
│       ├── ReservationService.cs # Reservation operations
│       ├── PaymentService.cs    # Payment operations
│       ├── FinancialService.cs  # Financial operations
│       └── ReportingService.cs  # Reporting
│
├── SilverScreen.DataAccess/      # Data Access Layer
│   ├── SilverScreenContext.cs   # DbContext
│   ├── Mappings/                # Entity Framework mappings
│   ├── Migrations/              # Database migrations
│   └── DatabaseSeeder.cs        # Seed data
│
└── SilverScreen.Entities/        # Domain Layer
    ├── Models/                  # Entity models
    │   ├── Movie.cs
    │   ├── Customer.cs
    │   ├── Reservation.cs
    │   ├── Showtime.cs
    │   ├── Seat.cs
    │   ├── User.cs
    │   └── CashRegister.cs
    └── Dtos/                    # Data Transfer Objects
        └── FinancialSummary.cs
```

### Service Layer

Each service contains CRUD operations and business logic for the related entity:

- **AuthService**: User authentication and session management
- **MovieService**: Movie CRUD operations and showing status control
- **CustomerService**: Customer CRUD operations
- **ReservationService**: Reservation creation, cancellation, and seat management
- **PaymentService**: Payment processing and cash register records
- **FinancialService**: Daily summary and day closing
- **ReportingService**: Reporting and statistics

---

## 🗄 Database Structure

### Entity Relationships

```
Movies (1) ────< (N) Showtimes
  │                      │
  │                      │
  │                      ├───< (N) Reservations
  │                      │
  │                      │
Showtimes (1) ────< (N) Reservations >─── (1) Customers
  │
  │
Reservations (1) ──── (1) Seats

CashRegister (Independent - Financial transactions)
Users (Independent - User management)
```

### Tables

#### Movies
- `Id` (PK)
- `Name`
- `Type`
- `Duration`
- `ReleaseTime`

#### Customers
- `Id` (PK)
- `Name`
- `Surname`
- `PhoneNumber`
- `Email`

#### Showtimes
- `Id` (PK)
- `MovieId` (FK)
- `HallName`
- `StartTime`
- `Price`

#### Reservations
- `Id` (PK)
- `ShowtimeId` (FK)
- `CustomerId` (FK)
- `SeatId` (FK)
- `ReservationTime`
- `IsPaid`

#### Seats
- `Id` (PK)
- `HallName`
- `SequenceNumber`
- `SeatNumber`
- `Taken`

#### CashRegister
- `Id` (PK)
- `Amount`
- `Description`
- `TransactionDate`

#### Users
- `Id` (PK)
- `Username`
- `Password`
- `FullName`
- `Role`

---

## 🎨 Screenshots

### Main Dashboard
The main screen displays daily statistics, movie count, customer count, and total revenue information.

### Movie List
All movies currently showing are listed. Search and filtering features are available.

### Reservation Management
Reservation creation, payment processing, and reservation list viewing operations can be performed.

### Financial Reports
Daily revenue, movie-based statistics, and transaction summary are displayed.

---

## 🔧 Development

### Project Structure

The project consists of 4 main layers:

1. **Entities**: Domain models and DTOs
2. **DataAccess**: Database access and Entity Framework configuration
3. **Business**: Business logic services
4. **UI**: Windows Forms user interface

### Adding New Features

1. Add the entity model to `SilverScreen.Entities/Models` folder
2. Add the mapping to `SilverScreen.DataAccess/Mappings` folder
3. Add the service to `SilverScreen.Business/Services` folder
4. Add the form to `SilverScreen/Forms` folder
5. Add new DbSet to DbContext

### Creating Migrations

```bash
# From Package Manager Console
Add-Migration MigrationName -ProjectName SilverScreen.DataAccess
Update-Database -ProjectName SilverScreen.DataAccess
```

### Code Standards

- **C# Coding Conventions**: Microsoft C# code standards
- **Naming**: PascalCase (classes, methods), camelCase (variables)
- **Async/Await**: Use async/await for asynchronous operations
- **Exception Handling**: Try-catch blocks and global exception handler

---

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork this repository
2. Create a new branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

### Contribution Guidelines

- Follow code standards
- Write tests for new features
- Update documentation
- Write descriptive commit messages

---

## 📝 License

This project is licensed under the [MIT License](LICENSE).

---

## 📧 Contact

**Developer:** Kaaner4mir

- **GitHub:** [@Kaaner4mir](https://github.com/Kaaner4mir)
- **Repository:** [silver-screen](https://github.com/Kaaner4mir/silver-screen)

---

## 🙏 Acknowledgments

- [DevExpress](https://www.devexpress.com/) - For UI components
- [Entity Framework](https://entityframework.net/) - For ORM
- [Microsoft](https://www.microsoft.com/) - For .NET Framework

---

<div align="center">

**⭐ If you liked this project, don't forget to give it a star! ⭐**

Made with ❤️ by [Kaaner4mir](https://github.com/Kaaner4mir)

</div>
