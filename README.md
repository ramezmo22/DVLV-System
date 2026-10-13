# 🚗 Driver & Vehicle Licensing Department (DVLD) System

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Forms%20(DotNET)-purple.svg)](https://dotnet.microsoft.com/)
[![Database](https://img.shields.io/badge/Database-SQL%20Server-red.svg)](https://www.microsoft.com/en-us/sql-server)
[![Architecture](https://img.shields.io/badge/Architecture-3--Tier%20Architecture-brightgreen.svg)]()
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

An enterprise-grade desktop management system tailored for the **Driver and Vehicle Licensing Department (DVLD)**. The system streamlines and automates licensing operations, driving tests lifecycle, international permits, person management, and application workflow with high integrity, structured access control, and optimized database performance.

---

## 📑 Table of Contents
- [Architecture Overview](#-architecture-overview)
- [Key Features](#-key-features)
- [Screenshots & UI Showcase](#-screenshots--ui-showcase)
- [Performance & Optimization Highlights](#-performance--optimization-highlights)
- [Getting Started & Installation](#-getting-started--installation)
- [Configuration](#-configuration)
- [Author](#-author)

---

## 🏛 Architecture Overview

The system strictly adheres to the **3-Tier Architecture pattern** to ensure separation of concerns, scalability, and maintainability:

┌────────────────────────────────────────────────────────┐
│               Presentation Layer (UI)                  │
│       - Windows Forms & Custom UserControls            │
│       - In-memory Grid Filtering (DataView RowFilter)  │
└───────────────────────────┬────────────────────────────┘
                            │
┌───────────────────────────▼────────────────────────────┐
│            Business Logic Layer (BLL)                  │
│       - Business Rules & Validation                    │
│       - State Management & Workflows                   │
└───────────────────────────┬────────────────────────────┘
                            │
┌───────────────────────────▼────────────────────────────┐
│              Data Access Layer (DAL)                   │
│       - ADO.NET (SqlConnection, SqlCommand, SqlParam)  │
│       - Parameterized Queries & Transactions           │
└───────────────────────────┬────────────────────────────┘
                            │
┌───────────────────────────▼────────────────────────────┐
│               Microsoft SQL Server                     │
│       - Normalized Relational Tables                   │
│       - Views & Procedures                             │
└────────────────────────────────────────────────────────┘

---

## ✨ Key Features

### 👤 Person & User Management
- Complete CRUD operations for individuals with national ID validation.
- User accounts management with role enablement/disablement.
- Credential caching via Windows Registry (`Remember Me` functionality).

### 📝 Application & Driving Licenses Workflow
- **Local Driving License Applications:** Handles class applications through sequential stages (New, In-Progress, Completed, Cancelled).
- **Three-Tier Examination Engine:**
  1. **Vision Test**
  2. **Written (Theory) Test**
  3. **Practical (Street) Test**
  - Complete appointment scheduling, test retake tracking, and automated qualification rules.
- **First-time License Issuance:** Automated issuance locked until all 3 tests are successfully passed.
- **License Operations:**
  - Renew driving licenses.
  - Replacement for lost or damaged licenses.
  - License detention and release management.
  - Comprehensive Driving License History per driver.

### 🌐 International Driving Permits
- Issue International Licenses linked directly to existing valid local licenses.
- Automated validation rules to prevent issuing multiple active international licenses simultaneously.

---

## 🖼 Screenshots & UI Showcase

### 🔐 Authentication & Main Dashboard
| Login Screen | Main Navigation |
| :---: | :---: |
| <img src="https://github.com/user-attachments/assets/335e97fa-6a65-4238-a643-b311ed94fb07" width="450" /> | <img src="https://github.com/user-attachments/assets/b4a7b686-9ed7-43e8-aa51-a187c99a8597" width="450" /> |

### 📋 Applications & In-Memory Filtered Lists
| Local Driving License Applications | International License Applications |
| :---: | :---: |
| <img src="https://github.com/user-attachments/assets/f9032d4a-cf4f-4911-845a-bd6f578b12a4" width="450" /> | <img src="https://github.com/user-attachments/assets/adccb46d-6f45-4cee-a5d8-bb507dbcdf09" width="450" /> |

### 🧪 Tests Management & License Card
| Test Appointment Workflow | Driving License Card |
| :---: | :---: |
| <img src="https://github.com/user-attachments/assets/195dda01-821b-409f-bd38-c67ee687cb05" width="450" /> | <img src="https://github.com/user-attachments/assets/2ae05c75-19c4-49cb-9c31-cb9255e9476a" width="450" /> |

---

## ⚡ Performance & Optimization Highlights

- **Smart In-Memory Grid Filtering:**
  - Upgraded data grid grids from frequent database re-queries on every keystroke (`TextChanged`) to initial single-fetch `DataTable` caching paired with `DataView.RowFilter`.
  - Dramatically lowered round-trips and connection pool contention on high-volume tables.
- **Safe ADO.NET Execution:**
  - Strict use of parameterized SQL queries across all DAL operations to eliminate SQL Injection risks.
- **Modular Reusable Controls:**
  - Custom UserControls (`ctr_Person_Info`, `Person_Finder_Filter`, `License_Info`) ensuring reusable components and consistent business states across forms.

---

## 🚀 Getting Started & Installation

### Prerequisites
- Windows OS (10 or 11)
- [.NET SDK](https://dotnet.microsoft.com/download)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express or Standard)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

### Database Setup
1. Open SSMS and connect to your SQL Server instance.
2. Create a database named `DVLV`.
3. Open and run the included SQL script file:
   `DVLV-Script.sql`
4. Verify that tables, default application types, and test types are populated.

### Project Setup
1. Clone the repository:
   `git clone https://github.com/ramezmo22/DVLV-System.git`
2. Open the solution file `DVLD.slnx` using Visual Studio.
3. Configure the database connection string in `App.config` (see below).
4. Build the solution (`Ctrl + Shift + B`) and Run (`F5`).

---

## ⚙ Configuration

Update the `connectionStrings` section in your local `App.config`:

```xml
<configuration>
  <connectionStrings>
    <!-- Windows Authentication (Local Server) -->
    <add name="ConnectionString" 
         connectionString="Server=.;Database=DVLV;Integrated Security=True;TrustServerCertificate=True;" 
         providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
```
👨‍💻 Author
Ramez Alkhabbas

GitHub: @ramezmo22
