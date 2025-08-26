# 🎮 VideoGameAPI

A simple ASP.NET Core Web API for managing a collection of video games using Entity Framework Core and SQL Server.

---

## 📌 Features

- ✅ Get all video games  
- ✅ Get video game by ID  
- ✅ Add a new video game  
- ✅ Update an existing video game  
- ✅ Delete a video game  
- ✅ Uses SQL Server as the database  
- ✅ Entity Framework Core with database seeding  

---

## 🧱 Technologies Used

- [.NET 9/ .NET 8](https://dotnet.microsoft.com/)
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (LocalDB or Express)
- Swagger (OpenAPI) for testing

---

## ⚙️ Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/VideoGameAPI.git
cd VideoGameAPI
```


## 2. Configure the Database

Update your appsettings.json:
```bash
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=Localhost\\SQLEXPRESS;Initial Catalog=myappDB_test;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```
## 3. Add and Apply Migrations
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 📬 API Endpoints

| Method | Endpoint              | Description             |
| ------ | --------------------- | ----------------------- |
| GET    | `/api/VideoGame`      | Get all video games     |
| GET    | `/api/VideoGame/{id}` | Get game by ID          |
| POST   | `/api/VideoGame`      | Add a new game          |
| PUT    | `/api/VideoGame/{id}` | Update an existing game |
| DELETE | `/api/VideoGame/{id}` | Delete a game           |
