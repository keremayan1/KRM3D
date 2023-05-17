FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY src/corePackages/Core.Shared/*.csproj src/corePackages/Core.Shared/
COPY src/projects/Adults/AdultView/Application/*.csproj src/projects/Adults/AdultView/Application
COPY src/projects/Adults/AdultView/Persistance/*.csproj src/projects/Adults/AdultView/Persistance

RUN dotnet restore src/projects/Adults/AdultView/WebAPI
