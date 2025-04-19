# 🔐 Authentication & Role-Based Access System with ASP.NET Core

A simple ASP.NET Core Web API project implementing **JWT authentication** and **role-based authorization** using **ASP.NET Identity** and **Entity Framework Core**.

## ✨ Features

- User Registration and Login
- JWT Token Authentication
- Role-based Authorization (`Admin`, `User`, etc.)
- Secure Endpoints for different roles
- EF Core with SQL Server

## 🚀 Tech Stack

- ASP.NET Core 8 Web API
- Entity Framework Core
- ASP.NET Identity
- JWT Bearer Authentication
- SQL Server / SQLite (configurable)

📦 Endpoints

| Endpoint | Method | Access | Description |
|----------|--------|--------|-------------|
| `/api/Auth/register` | POST | Public | Register new user |
| `/api/Auth/login` | POST | Public | Login and receive JWT |
| `/api/Auth/assign-role` | POST | Admin | Assign role to a user |
| `/api/Test/any` | GET | Authenticated | Any logged-in user |
| `/api/Test/user` | GET | User | Only for users with `User` role |
| `/api/Test/admin` | GET | Admin | Only for users with `Admin` role |
