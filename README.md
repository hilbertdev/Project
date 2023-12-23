Event Ticketing Platform
![Project Logo/Image]

Overview
This project is a comprehensive event ticketing platform designed to empower event organizers to seamlessly register and manage events while facilitating the sale of tickets to attendees. Leveraging a modern tech stack, the system is built with a focus on maintainability, scalability, and clean architecture principles.

Tech Stack
Backend: .NET Core
Frontend: Next.js
Architecture: CLEAN Architecture
Patterns: CQRS (Command Query Responsibility Segregation)
Libraries: MediatR, Fluent API for Validation
Features
User Registration: Event organizers can easily register on the platform, providing essential details for account creation.

Event Creation: Organizers can create and manage events, setting event details, ticket types, and pricing.

Ticket Sales: Seamless ticket purchasing experience for attendees, with support for multiple ticket types and secure payment processing.

Clean Architecture: The project structure follows the CLEAN architecture, promoting modularization and maintainability.

CQRS Pattern: Command Query Responsibility Segregation ensures a clear separation of commands and queries, leading to a more scalable and maintainable codebase.

Validation with Fluent API: Fluent API is employed for robust input validation, ensuring data integrity and preventing common security vulnerabilities.

Project Structure
The codebase is organized following the CLEAN architecture, separating concerns into distinct layers for improved maintainability.

Application Layer: Contains the CQRS handlers, application services, and DTOs for handling business logic and interactions.

Domain Layer: Defines the core domain entities, value objects, and business rules.

Infrastructure Layer: Houses data access logic, repositories, and external service integrations.

Presentation Layer: Consists of the API controllers, Next.js components, and other UI-related elements.

Getting Started
Clone the Repository:

bash
Copy code
git clone https://github.com/your-username/your-repo.git
Backend Setup:

Navigate to the src/Backend directory.
Run dotnet build and dotnet run to start the backend API.
Frontend Setup:

Navigate to the src/Frontend directory.
Run npm install to install dependencies.
Run npm run dev to start the Next.js development server.
Access the Application:

Open your browser and visit http://localhost:3000 to access the application.
Contribution Guidelines
If you'd like to contribute to the project, please follow the guidelines outlined in the CONTRIBUTING.md file.

License
This project is licensed under the MIT License.

Acknowledgments
Special thanks to MediatR and FluentValidation for their invaluable contributions to the project.
