# Epi CMS

## How to run

Chose one of the following options to get started. 

### Windows

Prerequisities
- .NET SDK 6+
- SQL Server (I've used 2022)

Install WebSockets windows feature(Internet Information Services -> World Wide Web Services)

To create empty template use next
```
dotnet new epi-cms-empty
```

call with -h flag to see additional info

To create database use next script
```
dotnet-episerver create-cms-database `
-S <sql-server-instance name> `
-U sa `
-P <sa-user password> `
-dn <db-name> `
-du <db-user-name> `
-dp <db-user-password> `
-E AlloyDocker.csproj
```
Above script should modify [appsettings.json](appsettings.json). Copy contents of ConnectionStrings section and paste to respectively section in [appsettings.Development.json](appsettings.Development.json).

Now you can start app via
```bash
dotnet run
````

### Any OS with Docker

Prerequisities
- Docker
- Enable Docker support when applying the template

```bash
docker-compose up
````

> Note that this Docker setup is just configured for local development. Follow this [guide to enable HTTPS](https://github.com/dotnet/dotnet-docker/blob/main/samples/run-aspnetcore-https-development.md).

### Any OS with external database server

Prerequisities
- .NET SDK 6+
- SQL Server 2016 (or later) on a external server, e.g. Azure SQL

Create an empty database on the external database server and update the connection string accordingly.

```bash
dotnet run
````
