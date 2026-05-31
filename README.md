# SucceedServices.WhatsApp

WhatsApp Message Management System built using ASP.NET Core MVC, Entity Framework Core, SQL Server, Repository Pattern, DTO Pattern, and Service Layer Architecture.

---

## Features

* WhatsApp Message Sender UI
* Dashboard
* Message Logs
* SQL Server Integration
* Entity Framework Core
* Repository Pattern
* DTO Architecture
* Service Layer
* Bootstrap UI
* Meta WhatsApp Cloud API Ready

---

## Technology Stack

* ASP.NET Core MVC (.NET 10)
* C#
* SQL Server
* Entity Framework Core
* Bootstrap 5
* GitHub

---

## Project Structure

```text
SucceedServices.WhatsApp
│
├── Controllers
├── Models
├── DTOs
├── Services
├── Repositories
├── Data
├── Views
└── wwwroot
```

---

## Modules

### Dashboard

Displays:

* Total Messages
* Today's Messages
* Successful Messages
* Failed Messages

### Send Message

Allows users to:

* Enter Mobile Number
* Enter Message
* Send WhatsApp Message

### Message Logs

Stores:

* Mobile Number
* Message
* Status
* Created Date

### Settings

Stores:

* Access Token
* Phone Number ID
* Business Account ID
* Verify Token

---

## Database

Database Name:

```sql
SucceedServicesWhatsAppDb
```

Table:

```sql
MessageLogs
```

---

## Installation

### Clone Repository

```bash
git clone https://github.com/Sushilji/SucceedServices.WhatsApp.git
```

### Open Project

```text
Visual Studio 2026
```

### Restore Packages

```bash
dotnet restore
```

### Run Migration

```powershell
Add-Migration InitialCreate
Update-Database
```

### Run Application

```bash
dotnet run
```

---

## Future Enhancements

* Meta WhatsApp Cloud API
* OTP Messaging
* Template Messaging
* PDF Attachment Sending
* Delivery Tracking
* Webhook Integration
* Employee Notifications
* HRM Integration

---

## Author

Sushil Kumar

Software Engineer | Solar Entrepreneur

---

## License

This project is for learning, research, and business development purposes.
