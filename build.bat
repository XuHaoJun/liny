:: Generated by: https://openapi-generator.tech
::

@echo off

dotnet restore src\Liny.Core
dotnet build src\Liny.Core
echo Now, run the following to start the project: dotnet run -p src\Liny.Core\Liny.Core.csproj --launch-profile web.
echo.
