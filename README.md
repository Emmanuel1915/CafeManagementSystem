Description
The Cafe Management App is a software solution designed to help manage various aspects of a café, including order processing, inventory management, customer management, and employee tracking. Built using C# for the front-end and SQL for the database, this application aims to provide an easy-to-use interface for café owners and employees to streamline daily operations and enhance customer satisfaction.

Features
Order Management: Create, update, and manage customer orders with ease.
Inventory Management: Keep track of ingredients and supplies in real-time.
Employee Management: Manage employee details, shift schedules, and performance.
Customer Management: Store and view customer details, including their order history.
Reports & Analytics: Generate sales reports and analyze trends over time.
User Authentication: Admin and staff login functionality with role-based access control.
Technologies Used
C#: Used for building the desktop application interface, logic, and operations.
SQL Server: Used for storing and managing application data such as orders, inventory, and employee details.
Windows Forms: Utilized for the graphical user interface (GUI).
ADO.NET: Used for database connectivity and operations.

Installation
Clone the Repository
Set up the Database
Open SQL Server Management Studio and create a new database (e.g., CafeManagementDB).
Run the SQL scripts located in the Database folder to set up the required tables and schema.
Configure the Application

Open the project in Visual Studio.
In the App.config file, update the connection string to point to your local or remote SQL Server instance.
Build and Run the Application

Build the project in Visual Studio.
Run the application to start managing the café's operations.
Relationships:
Customers ↔ Orders: One customer can have many orders.
Orders ↔ MenuItems: Many-to-many relationship, as an order can include multiple menu items.
Employees ↔ Orders: Employees can process multiple orders.
