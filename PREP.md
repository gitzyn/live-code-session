# 🧰 Candidate Prep Guide — “Task Tracker Lite” Interview

## 🎯 Overview

You’ll be working through a **small full-stack exercise** during a 45–60 minute live coding session.  
The goal isn’t to finish everything, but to demonstrate **how you approach problem-solving, design, and implementation** in a realistic engineering scenario.

---

## 🧩 What to Expect

You’ll be asked to:

- Build a small **.NET 8** API (using Clean Architecture principles).
- Use **Entity Framework Core** to persist simple data (in-memory or SQL).
- Create a small **Vue 2/3 or Nuxt** front-end to consume your API.
- Follow **clean code and separation of concerns** practices.

**Bonus:** If time allows, we may discuss or extend the design with additional data sources or UI enhancements.

---

## 🖥️ Environment Setup Checklist

Please make sure the following tools are installed **before the interview**:

### ✅ Backend

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- IDE of your choice:
  - Visual Studio 2022 **or**
  - JetBrains Rider **or**
  - Visual Studio Code with C# extension
- (Optional) **Docker Desktop**, if you want to demonstrate SQL or Mongo locally
- Postman or browser for API testing

### ✅ Frontend

- [Node.js 18+](https://nodejs.org/en/download/) and npm
- Familiarity with **Vue 2/3 (Composition API)** or **Nuxt 3**
- Preferred IDE (VS Code, WebStorm, etc.)

---

## 🧱 Technical Concepts to Brush Up On

| Area                      | Focus Topics                                                       |
| ------------------------- | ------------------------------------------------------------------ |
| **.NET / C#**             | Async/await, dependency injection, controllers, DTOs, interfaces   |
| **Entity Framework Core** | DbContext, DbSet, migrations, in-memory providers                  |
| **Clean Architecture**    | Layers (Domain, Application, Infrastructure, API), dependency flow |
| **Frontend (Vue 3)**      | Components, reactive refs, API calls, simple state management      |
| **REST APIs**             | HTTP verbs, request/response patterns                              |
| **Optional**              | Docker Compose basics, connecting to SQL/Mongo containers          |

---

## ⚡ Optional Enhancements (Stretch Discussion)

If time allows or you’re interested, we may touch on:

- Using a **design system** (Naive UI, Tailwind, or Vuetify)
- Persisting data in **SQL Server** or **MongoDB**
- Structuring your code for testability or scalability
- Handling errors, validations, and async operations cleanly

---

## 🕐 Session Flow

| Phase                   | Duration  | Description                                            |
| ----------------------- | --------- | ------------------------------------------------------ |
| **Intro & Setup**       | 5–10 min  | Discuss your environment and project plan              |
| **Implementation**      | 30–40 min | Build backend and frontend features live               |
| **Review & Discussion** | 10–15 min | Review design decisions, trade-offs, and stretch goals |

---

## 💡 Tips

- Focus on **clarity over completeness** — show how you think.
- Narrate your reasoning (e.g., “I’d usually separate this logic into a service…”).
- Keep commits or checkpoints small and incremental.
- Don’t stress over visuals — functionality and structure matter more.

---

## 📦 Summary of What You’ll Need

| Category     | Minimum Required                          | Optional                      |
| ------------ | ----------------------------------------- | ----------------------------- |
| **Backend**  | .NET 8 SDK, EF Core, working API template | Docker for SQL                |
| **Frontend** | Node.js, npm, Vue 3 CLI or Vite           | Naive UI, Tailwind            |
| **Tools**    | Code editor, Postman                      | Docker Desktop, Mongo Express |

---

**That’s it!**  
Come prepared with your environment set up and ready to build. We’ll provide the project structure and specific requirements during the session.
