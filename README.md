# Finshark (A Finance Project)

![Finshark Logo](./frontend-react-typescript/src/Picture/logo.png)

Finshark Frontend is the user interface for Finshark, a comprehensive personal finance management tool. Built using React with TypeScript, this frontend integrates seamlessly with the Finshark backend, which is developed using ASP.NET Core. The backend utilizes JWT Bearer authentication, built-in user management, Entity Framework for data access, and follows a Code-First approach for database schema generation. The frontend is styled using Tailwind CSS, providing a clean and modern user interface.
![react_logo](https://upload.wikimedia.org/wikipedia/commons/a/a7/React-icon.svg)
![.net_logo](https://upload.wikimedia.org/wikipedia/commons/e/ee/.NET_Core_Logo.svg)
![typescript](https://upload.wikimedia.org/wikipedia/commons/4/4c/Typescript_logo_2020.svg)
![Tailwind_CSS](https://tailwindcss.com/_next/static/media/tailwindcss-mark.3c5441fc7a190fb1800d4a5c7f07ba4b1345a9c8.svg)
## Features

#### Expense Tracking
Easily log and categorize expenses to gain insights into spending habits. The intuitive interface allows users to quickly add, edit, and delete expenses, making it simple to stay on top of finances.

#### Budget Management
Set monthly budgets for different expense categories and track spending against these budgets in real-time. Visualizations help users understand where their money is going and adjust budgets accordingly.

#### Financial Goal Setting
Define and monitor progress towards financial goals, such as saving for a vacation or paying off debt. Finshark Frontend provides tools to set achievable goals, track progress, and celebrate milestones along the way.

#### Secure Authentication
User authentication and authorization are handled securely using JWT tokens. This ensures that only authorized users can access their financial data and perform sensitive actions within the application.

#### Interactive Dashboard
The dashboard provides a comprehensive overview of finances, including spending trends, budget status, and goal progress. Customizable widgets allow users to tailor the dashboard to their specific needs and priorities.

#### Responsive Design
Finshark Frontend is designed with responsiveness in mind, ensuring a seamless experience across devices of all sizes. Whether accessing the application on a desktop, tablet, or mobile device, users can manage their finances with ease.

## Setup

To get started with Finshark Frontend, follow these simple steps:

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/finshark-frontend.git

2. Navigate to the frontend directory:
    ```bash
    cd finshark-frontend

3. Install dependencies:
    ```bash
    npm install

4. Start the frontend development server:
    ```bash
    npm start

Access Finshark Frontend in your web browser at `http://localhost:3000`

### Backend Information

The Finshark backend is developed using ASP.NET Core and provides robust features for managing user authentication, data storage, and API endpoints. Here are some key aspects of the backend:

* **JWT Bearer Authentication:** Secures API endpoints using JSON Web Tokens (JWT) for authentication.
* **Built-in User Management:** Utilizes ASP.NET Core Identity for user management, including registration, login, and password management.
* **Entity Framework:** Integrates Entity Framework Core for data access, enabling seamless interaction with the underlying database.
* **Code-First Approach:** Adopts a Code-First approach to database schema generation, allowing developers to define data models in code and automatically generate database tables.

### Installed Library and Packages in Backend
* EFTools
* SqlServer
* Design
* Newtonsoft.Json by James Newton-king
* AspNetCore.Mvc.NewtonsoftJson

### To Upload into Database:
    ```bash
    Add-Migration Init
    Upload-Database

## Contributing:
 
 Contributions to Finshark Frontend are welcome! If you'd like to contribute, please follow these steps:

* Fork the repository and create a new branch.
* Make your changes and ensure they adhere to the project's coding standards.
* Test your changes thoroughly.
* Submit a pull request detailing the features or improvements made.

## License

This project is licensed under the MIT License - see the LICENSE file for details.
