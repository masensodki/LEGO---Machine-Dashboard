# LEGO - Machine Dashboard

## Introduction
Welcome to the all new LEGO Machine Dashboard!


# Requirements

.NET v9
npm (latest version is recommended)

# Getting Started

To run this project, you will first need to initalize the database, there is a file called machines.bak that can be used to restore a test database in SQL Server Management Studio, for more information on how to do so, follow this guide [Restore a Database](https://learn.microsoft.com/en-us/sql/relational-databases/backup-restore/restore-a-database-backup-using-ssms?view=sql-server-ver16)

Once that is done, ensure that your connectionString is set up properly, there is a field called {YOUR_COMPUTER} under api/appsettings.json, replace this with your computers name so that you can connect to the correct database you have set up locally. Example name: DESKTOP-IJAF7F0

Make sure that the port 5173 and 5241 are free as the project is set up to prefer those ports.

## Run Backend
run dotnet run watch in /api folder

## Run FE
Run the command npm install in /frontend
Run the comment npm run dev in /frontend
