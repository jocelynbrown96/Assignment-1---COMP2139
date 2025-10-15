Assignment-1 — COMP2139
TicketMe - Virtual Event Ticketing System
Welcome to TicketMe, a virtual event ticketing system built with ASP.NET Core MVC and Entity Framework Core using PostgreSQL. This application allows users to browse events, purchase tickets, and manage event listings.

📑 Table of Contents
Project Overview

Prerequisites

Database Configuration

How to configure your database

Running the Application

Notes

Project Overview
TicketMe provides the following features:

Browse events by category and price

Purchase tickets

Add, edit, or delete events

View purchase history and event details

Clean, responsive UI with banners, filters, and alerts for low ticket stock

Prerequisites
Before running the application, make sure you have installed:

.NET 7 SDK

PostgreSQL

pgAdmin 4

JetBrains Rider

Database Configuration
TicketMe uses PostgreSQL for its database. The connection string is stored in appsettings.json:

json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=TicketMeDB;Username=YOUR_DB_USERNAME;Password=YOUR_DB_PASSWORD"
}
How to configure your database
Open pgAdmin 4 and ensure your PostgreSQL server is running.

Create a new database (e.g., TicketMeDB) if it does not exist.

Open appsettings.json in Rider.

Replace placeholders with your credentials:

YOUR_DB_USERNAME → your PostgreSQL username

YOUR_DB_PASSWORD → your PostgreSQL password

Save the changes.

Running the Application
Open the project in JetBrains Rider.

Ensure the connection string in appsettings.json is correctly set.

Apply migrations to create the database schema:

bash
dotnet ef database update
Start the application:

Click the Run button in Rider, or

Use the terminal:

bash
dotnet run
Open a browser and navigate to: https://localhost:5001 (or the port shown in the console).

Notes
Default landing page: Home

Admin features: create, edit, and delete events.

Prices display consistently with two decimal places (e.g., $45.00).

Low ticket stock alerts appear in red bold text next to the ticket count.

Banner is attached seamlessly to the navbar for a clean UI.

About page includes team member info and course details.

Ensure PostgreSQL is running before starting the application.

Use environment variables for sensitive information like database passwords.

pgAdmin 4 can be used to inspect and manage your database.



