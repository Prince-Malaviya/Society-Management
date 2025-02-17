# Society Management System

## Overview
The **Society Management System** is a web-based application built using **ASP.NET** for both the frontend and backend. It streamlines society-related operations, such as member management, maintenance tracking, event scheduling, and complaint handling.

## Features
- **User Authentication** (Admin, Resident, Staff)
- **Member Management** (Add, Update, Delete, View)
- **Maintenance & Dues Tracking**
- **Event Scheduling & Notifications**
- **Complaint & Issue Reporting**
- **Visitor & Security Management**
- **Dashboard with Analytics**

## Tech Stack
- **Backend:** ASP.NET Web API
- **Frontend:** ASP.NET MVC
- **Database:** SQL Server
- **Authentication:** JWT Authentication

## Installation & Setup
### Prerequisites
- .NET SDK (Latest Version)
- SQL Server
- Visual Studio

### Steps to Run the Project
1. **Clone the Repository**
   ```sh
   git clone https://github.com/your-repository-url.git
   cd society-management
   ```
2. **Setup Database**
   - Configure the connection string in `appsettings.json`
   - Run database migrations or execute SQL scripts

3. **Run the Backend API**
   ```sh
   dotnet run --project SocietyManagement.API
   ```

4. **Run the Frontend Application**
   ```sh
   dotnet run --project SocietyManagement.Web
   ```

5. **Access the Application**
   Open `http://localhost:5000` in your browser.

## API Endpoints
| Method | Endpoint | Description |
|--------|---------|-------------|
| GET | `/api/members` | Get all society members |
| POST | `/api/members` | Add a new member |
| PUT | `/api/members/{id}` | Update member details |
| DELETE | `/api/members/{id}` | Remove a member |
| GET | `/api/complaints` | Fetch all complaints |
| POST | `/api/complaints` | File a new complaint |

## Contributing
Feel free to fork this repository and submit pull requests for any enhancements or bug fixes.

## License
This project is licensed under the MIT License.

