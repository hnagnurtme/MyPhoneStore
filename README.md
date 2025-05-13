# PhoneHub - Mobile Phone Store Management System

## Overview
PhoneHub is a comprehensive management system for mobile phone stores. It allows businesses to manage their inventory, process bookings and orders, and maintain customer relationships. Built with C# and .NET, this application provides a user-friendly interface for both administrators and customers.

## Features
- **User Management**: Different access levels for administrators and customers
- **Product Management**: Add, update, and manage phone inventory
- **Booking System**: Process and track customer orders and pre-orders
- **Authentication**: Secure login and signup functionality
- **Database Initialization**: Automatic database setup with sample data

## System Requirements
- .NET 6.0 or higher
- SQL Server (or compatible database system)

## Project Structure
```
PhoneHub/
├── BLL/                  # Business Logic Layer
│   ├── DTOs/             # Data Transfer Objects
│   └── Services/         # Business Services
├── DAL/                  # Data Access Layer
│   ├── Repositories/     # Data Repositories
│   └── UnitOfWorks/      # Unit of Work Pattern Implementation
├── Migrations/           # Database Migration Files
├── Models/               # Entity Models
├── Properties/           # Project Properties
├── Resources/            # Resource Files
└── VIEW/                 # User Interface Components
```

## Getting Started

### Installation
1. Clone the repository
2. Open the solution in Visual Studio
3. Restore NuGet packages
4. Update the connection string in `ApplicationDbContext.cs` to point to your database
5. Run the application

### Initial Login
The database is initialized with the following accounts:

- **Administrator**
  - Email: admin@phonehub.com
  - Password: admin123

- **Demo Customer**
  - Email: customer@phonehub.com
  - Password: customer123

## Demo Data
The system is preloaded with sample data including:
- 5 smartphone products from major brands (Apple, Samsung, Google, OnePlus, Xiaomi)
- 2 sample bookings

## Development
This project follows a layered architecture approach:
- Models define the data structure
- DAL handles data access operations
- BLL implements business logic
- VIEW contains UI components

