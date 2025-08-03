#  Dynamic Personal Web Panel & Admin Interface – ASP.NET Core MVC

This is a **fully dynamic personal portfolio management system** built with **ASP.NET Core 8.0**. It includes both a **user interface** and a **custom admin panel**, with complete database integration for dynamic content management.


##  Project Overview

This application allows full CRUD control over personal portfolio content via an admin dashboard, while delivering a clean and modern UI for public users.

###  User Panel Features

- Fully database-driven sections: `About`, `Skills`, `Experience`, `Education`
- Dynamic `Statistics` area showing:
  - Total number of projects
  - Number of skills
  - Total messages received
  - Randomized metrics
- `Portfolio` section includes **category-based filtering**
- `Services` section dynamically lists the **latest 6 services**
- **SweetAlert2** integration for interactive alert pop-ups

###  Admin Panel Features

- Fully dynamic content management system for all sections
- Custom **Card-Title** UI components for editing entities
- Custom-designed **404 Error Page**
- Admin dashboard includes **10+ dynamic statistics widgets**


##  Technologies Used

- **ASP.NET Core 8.0**
- **Entity Framework Core** (Code First + Migrations)
- **SQL Server**
- **Razor View Engine**
- **ViewComponent** architecture
- **HTML / CSS / Bootstrap 5**
- **JavaScript / SweetAlert2**
- **Layered Architecture:** Entity, Data Access, UI
- **Principles Followed:** SOLID, DRY



##  What I Learned

- Designing modular architecture using `ViewComponent`
- Managing relational data with **EF Core** and `Migrations`
- Writing clean, maintainable code in a layered architecture
- Implementing **user interaction enhancements** using SweetAlert2
- Developing and managing **dynamic web content**



##  Project Structure

```plaintext
PortfolioCoreProject/
├── PortfolioCoreDay.Entities        # Entity classes (About, Skill, Experience, etc.)
├── PortfolioCoreDay.DataAccess      # Data access layer using EF Core
├── PortfolioCoreDay.WebUI           # Presentation layer (Razor Views, Controllers)
├── Views/
│   ├── Default/                     # User-facing sections
│   ├── Shared/Components/          # ViewComponent definitions
│   ├── Admin/                      # Admin dashboard views
│   └── Error/                      # Custom error pages
