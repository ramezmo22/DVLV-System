# 🚗 Driver & Vehicle Licensing Department (DVLD) System

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/.badge/Platform-Windows%20Forms%20(.NET)-purple.svg)](https://dotnet.microsoft.com/)
[![Database](https://img.shields.io/badge/Database-SQL%20Server-red.svg)](https://www.microsoft.com/en-us/sql-server)
[![Architecture](https://img.shields.io/badge/Architecture-3--Tier%20Architecture-brightgreen.svg)]()
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

An enterprise-grade desktop management system tailored for the **Driver and Vehicle Licensing Department (DVLD)**. The system streamlines and automates licensing operations, driving tests lifecycle, international permits, person management, and application workflow with high integrity, structured access control, and optimized database performance.

---

## 📑 Table of Contents
- [Architecture Overview](#-architecture-overview)
- [Key Features](#-key-features)
- [Screenshots & UI Showcase](#-screenshots--ui-showcase)
- [Database & ERD](#-database--erd)
- [Performance & Optimization Highlights](#-performance--optimization-highlights)
- [Getting Started & Installation](#-getting-started--installation)
- [Configuration](#-configuration)
- [Author](#-author)

---

## 🏛 Architecture Overview

The system strictly adheres to the **3-Tier Architecture pattern** to ensure separation of concerns, scalability, and maintainability:

```text
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
│             Data Access Layer (DAL)                    │
│       - ADO.NET (SqlConnection, SqlCommand, SqlParam)  │
│       - Parameterized Queries & Transactions           │
└───────────────────────────┬────────────────────────────┘
                            │
┌───────────────────────────▼────────────────────────────┐
│               Microsoft SQL Server                     │
│       - Normalized Relational Tables                   │
│       - Views & Procedures                             │
└────────────────────────────────────────────────────────┘
```

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

<!-- Place your screenshots here following either Method 1 (GitHub URLs) or Method 2 (local ./screenshots/ folder) -->

### 🔐 Authentication & Main Dashboard
| Login Screen | Main Navigation |
| :---: | :---: |
| ![Login Screen](screenshots/login.png) | ![Main Form](screenshots/dashboard.png) |

### 📋 Applications & In-Memory Filtered Lists
| Local Driving License Applications | International License Applications |
| :---: | :---: |
| ![Local Applications](screenshots/local_applications.png) | ![International Applications](screenshots/international_applications.png) |

### 🧪 Tests Management & License Card
| Test Appointment Workflow | Driving License Card |
| :---: | :---: |
| ![Test Appointments](screenshots/test_appointments.png) | ![License Card](screenshots/license_card.png) |

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
2. Create a database named `DVLV` (or execute the script directly).
3. Open and run the included SQL script file:
   ```sql
   DVLV-Script.sql
   ```
4. Verify that tables, default application types, and test types are populated.

### Project Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/ramezmo22/DVLV-System.git
   ```
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

---

## 👨‍💻 Author

**Ramez Alkhabbas**  
- GitHub: [@ramezmo22](https://github.com/ramezmo22)