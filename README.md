
<p align="center">
  <img src="https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExcTF1b3g1MG1zZHZ1dXE2cTN3dDJ1MWMwbzNhMWRrdTBkNmJxdmh3ZSZlcD12MV9naWZzX3NlYXJjaCZjdD1n/McDhivnfg70Os/giphy.gif" width="300" alt="Let's go!">
</p>

<h1 align="center">🚀 Customer CRUD API - Full Stack .NET 8 Project 🚀</h1>

---

## ✨ About the Project

**Customer CRUD API** is a clean and modern RESTful API built with **.NET 8** and **PostgreSQL** that supports full CRUD operations and real-time customer management.

The project was created as part of a technical assignment to demonstrate backend development skills, architecture quality, error handling, and scalability.

---

## 🛠️ Features

- ➕ Create New Customers
- 🔍 Search Customers by Name
- 📋 Get All Customers
- 🎯 Get Customer by ID
- ✏️ Update Customer Data
- ❌ Delete Customer
- 🔥 Global Error Handling (middleware)
- 🎯 Model Validation
- 📦 API returns structured responses with data wrappers
- 📃 Full Swagger/OpenAPI documentation (auto-generated)

---

## ⚙️ Built With

- **.NET 8 Web API**
- **Entity Framework Core (EF Core)**
- **PostgreSQL Database**
- **Swagger (Swashbuckle)** for API documentation
- **Docker** (optional for future deployment)

---

## 🚀 Getting Started

To run the project locally:

1. Clone the repository:
   ```bash
   git clone https://github.com/AnatolyBystrov/customer-crud-api.git
   cd customer-crud-api/CustomerApi
   ```

2. Install dependencies:
   ```bash
   dotnet restore
   ```

3. Apply migrations and update database:
   ```bash
   dotnet ef database update
   ```

4. Run the project:
   ```bash
   dotnet run
   ```

5. Open your browser:
   ```url
   http://localhost:5009/swagger
   ```

---

## 📬 API Endpoints

| Method | Endpoint | Description |
|:------:|:--------:|:-----------:|
| GET    | `/api/Customers`       | Get all customers |
| GET    | `/api/Customers/{id}`  | Get customer by ID |
| GET    | `/api/Customers/search?name=...` | Search customers by name |
| POST   | `/api/Customers`       | Create new customer |
| PUT    | `/api/Customers/{id}`  | Update customer |
| DELETE | `/api/Customers/{id}`  | Delete customer |

---

## 🖥️ Screenshots

| Customer List | Create Customer |
|:-------------:|:---------------:|
| ![Get Customers](https://via.placeholder.com/400x200?text=Customers+List) | ![Create Customer](https://via.placeholder.com/400x200?text=Create+Customer) |

*(Screenshots will be updated after deployment)*

---

## 🎯 Future Improvements

- Add **unit tests** and **integration tests**
- Dockerize the application
- Deploy to **AWS** or **Render**
- Add authentication and authorization
- Extend search filters (city, phone, etc.)

---

<p align="center">
  Made with ❤️ by Anatoly Bystrov
</p>
