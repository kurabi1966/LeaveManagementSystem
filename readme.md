### Database
This application uses mssql database that runs as a docker container.
Please run the following command befor you start the web application
```
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD={password}' -p 1433:1433 -d --name lms-db mcr.microsoft.com/mssql/server
```

### Scaffolding new controller:
dotnet aspnet-codegenerator controller -name LeaveTypesController -m LeaveType -dc ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries