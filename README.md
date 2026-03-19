# Global Exception Handling Middleware

## Overview
This project showcases a middleware approach for handling exceptions globally in a web application. It aims to standardize error responses and improve error management.

## Features
- Global exception handling
- Custom error responses
- Logging of exceptions
- Detailed error information for clients

## Technology Stack
- Programming Language: C#
- Framework: ASP.NET Core
- Database: SQL Server

## Project Structure
```
├── Middleware
│   └── GlobalExceptionHandler.cs
├── Models
│   └── ErrorResponse.cs
├── Services
│   └── EmailService.cs
├── Controllers
│   └── SampleController.cs
└── Startup.cs
```

## Middleware Components
1. **GlobalExceptionHandler**: This is the core component that intercepts all unhandled exceptions.
2. **ErrorResponse**: This model defines the structure of the error response sent to clients.
3. **Logging**: Logs all exceptions for further analysis.

## Getting Started Guide
To start using this middleware in your project:
1. Clone the repository.
2. Install the required packages using `dotnet restore`.
3. Register the middleware in the `Startup.cs` file.

## Services
- **EmailService**: A sample service to send email notifications when an error occurs.

## Database Configuration
Make sure your database connection string is correctly set in `appsettings.json`.

## Error Response Format
```json
{
  "status": "error",
  "message": "Description of the error",
  "errorCode": 1234
}
```

## Exception Handling Flow
1. An exception occurs in a controller or service.
2. The GlobalExceptionHandler middleware intercepts the exception.
3. It logs the exception and formats the error response.
4. The formatted response is sent back to the client.

## Best Practices
- Always provide meaningful error messages.
- Log exceptions with stack traces for easier debugging.
- Avoid exposing sensitive information in error responses.

## Development Commands
- Run the application: `dotnet run`
- Execute tests: `dotnet test`

## Configuration Files
- `appsettings.json`: Contains configuration settings for the application.

## Contributing Guidelines
1. Fork the repository.
2. Create a feature branch.
3. Make the changes and commit.
4. Submit a pull request.

## Support Information
For support, please reach out to [lipun619](https://github.com/lipun619) or open an issue in the GitHub repository.