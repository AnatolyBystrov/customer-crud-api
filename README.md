<!-- Star Wars Cover -->
<p align="center">
  <img src="https://media3.giphy.com/media/v1.Y2lkPTc5MGI3NjExZ3Y0NzB0NGU4ZGJ3dDc5MzV1Zm91MTBhamplcmcyem40bnVtdGtpYyZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/GnNtz3c1Ni8Ba/giphy.gif" width="600" alt="Master Yoda Epic">
</p>


# 🚀 Customer CRUD API

**Customer CRUD API** — a reliable web service for managing customer data built with ASP.NET Core 8, PostgreSQL, and Entity Framework Core.

Crafted with precision and the power of the Force. 🛸

---

<p align="center">
  <a href="https://customer-crud-api-q7ex.onrender.com/" target="_blank">
    <img src="https://img.shields.io/badge/Open-API-blueviolet?style=for-the-badge&logo=swagger" alt="Open API">
  </a>
</p>

---

## 🧩 Tech Stack

- **ASP.NET Core 8 Web API**
- **PostgreSQL** (deployed on Render)
- **Entity Framework Core 8**
- **Swagger UI / OpenAPI**
- **Docker (optional for deployment)**

---

## 📋 API Endpoints

| Method | URL | Description |
|:------|:----|:------------|
| `GET` | `/api/Customers` | Retrieve all customers |
| `GET` | `/api/Customers/{id}` | Retrieve a customer by ID |
| `POST` | `/api/Customers` | Create a new customer |
| `PUT` | `/api/Customers/{id}` | Update an existing customer |
| `DELETE` | `/api/Customers/{id}` | Delete a customer |

---

## 🛠️ How to Run Locally

```bash
# Clone the repository
git clone https://github.com/AnatolyBystrov/customer-crud-api.git

# Navigate into the project directory
cd customer-crud-api

# Restore dependencies
dotnet restore

# Run the application
dotnet run
