## Project Description: StudentForm 

This project is a basic web application developed using ASP.NET Core MVC framework. 
It allows students to register with their details, log in using their credentials, and manage their profile. 
The application features secure authentication and basic user management functionalities.

## Features

- User registration with form validation.
- User login with session management.
- Secure password handling.
- Role-based authorization (future enhancement).
- Error handling and validation messages.

## Technologies Used

- **Framework**: ASP.NET Core MVC
- **Language**: C#
- **Database**: In-memory database (EF Core) for testing, SQL Server for production.
- **Authentication**: Cookie-based authentication.
- **Frontend**: HTML, CSS, Bootstrap (for styling).
- **Tools**: Visual Studio 2022, .NET Core SDK

## Installation
Using visual studio 2022 made me easy to upload project folder in github.
-View


## Usage

### Registration
- Navigate to the registration page: `https://localhost:7002/User/Register`.
- Fill in the required fields (username, password, email).
- Click the `Register` button to create a new account.

### Login
- Navigate to the login page: `(https://localhost:7002/User/Login)`.
- Enter the registered username and password.
- Click the `Login` button to access your profile.

### Profile Management
- After logging in, you will be redirected to the profile page.
- View and update your full name on the profile page.
- Click `Logout` to end your session.

## Configuration

### Database Configuration
- By default, the application uses an in-memory database for development purposes.
- To use SQL Server, update the connection string in `appsettings.json`:

    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=my_server_name;Database=StudentFormDb; Integrated Security= true; TrustServerCertificate=True;
- Update `Startup.cs` to use SQL Server:

    ```csharp
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    ```

## Acknowledgments

- Thanks to [Microsoft](https://dotnet.microsoft.com/apps/aspnet) for the ASP.NET Core framework.
- Inspired by various tutorials and online resources.
- Special thanks to the Debandra Kandel sir  for continuous support and inspiration.
