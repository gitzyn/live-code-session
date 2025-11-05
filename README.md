# 🎯 Task Tracker Lite — Candidate Coding Exercise

## Objective

Evaluate the candidate’s ability to:

- Design and implement a small but real-world API using **Clean Architecture** principles.
- Use **Entity Framework Core** effectively with **MSSQL** (and optionally **MongoDB** for a secondary data source).
- Build a small **Vue 2/3 / Nuxt** front-end to consume the API.
- Demonstrate engineering maturity: clean code, separation of concerns, async/await usage, testing awareness, and thoughtful architecture.

---

## 🧩 Project Overview — Task Tracker Lite

### Goal

Build a simplified **Task Tracker** application where users can:

- ✅ List all tasks
- ➕ Create a new task
- ✔️ Mark a task as complete

### Optional Stretch Goals

- Persist audit logs in **MongoDB**.
- Add **filtering** by completion status.
- Implement **SQL Server** persistence (instead of in-memory).
- Enhance the UI with a design system such as **Naive UI**, **Tailwind CSS**, or **Vuetify**.

---

## 🏗️ Architecture & Setup

### Backend — (.NET 8 API)

#### Requirements

Implement a simple RESTful API with 3 endpoints:

| Method | Endpoint                   | Description             |
| ------ | -------------------------- | ----------------------- |
| `GET`  | `/api/tasks`               | List all tasks          |
| `POST` | `/api/tasks`               | Create a new task       |
| `PUT`  | `/api/tasks/{id}/complete` | Mark a task as complete |

#### Data Model

```csharp
public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; }
}
```

#### Clean Architecture Layers

| Layer              | Responsibility                       |
| ------------------ | ------------------------------------ |
| **Domain**         | Core entities and interfaces         |
| **Application**    | Business logic and use cases         |
| **Infrastructure** | Data access (EF Core, persistence)   |
| **API**            | Controllers and endpoint definitions |

#### Swagger

Swagger: http://localhost:5000/swagger

---

### 🧱 Optional Backend Stretch Goals

1. **SQL Server Integration**

   - Use Docker or local SQL Server instance.
   - Example connection string:
     ```json
     "ConnectionStrings": {
       "SqlServer": "Server=localhost,1433;Database=TaskTrackerDb;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;"
     }
     ```

2. **MongoDB Integration (Audit Logging)**

   - Log completed tasks:
     ```
     Task 'Setup EF Core' marked complete at 2025-11-05T14:23Z
     ```
   - Example connection string:
     ```json
     "ConnectionStrings": {
       "MongoDb": "mongodb://root:example@localhost:27017"
     }
     ```

3. **Docker Compose Setup**
   - SQL Server (port `1433`)
   - MongoDB (port `27017`)
   - Mongo Express UI (port `8081`)

---

## 💻 Frontend — (Vue 2/3 or Nuxt)

#### Requirements

Build a simple **single-page application (SPA)** that allows users to:

- Display all tasks
- Add a new task
- Mark a task as complete

#### Technical Expectations

- Use **Axios** or **Fetch API** to communicate with backend endpoints.
- Implement the **Composition API** (`ref`, `onMounted`, etc.) if comfortable.
- Focus on component structure and reactivity.
- Keep the UI clean and consistent.

---

### 🎨 Bonus Points (Design System Integration)

Candidates can optionally enhance the interface by using:

- 🧱 **Naive UI** — elegant Vue 3 design system
- 🌈 **Tailwind CSS** — utility-first CSS framework
- 🧩 **Vuetify** or **Element Plus** — Material-style UI components

Demonstrating integration of a design system earns bonus points for front-end engineering maturity.

**Good luck and happy coding! 🚀**
