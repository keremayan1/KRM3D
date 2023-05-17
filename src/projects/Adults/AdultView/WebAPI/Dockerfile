FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY src/corePackages/Core.Shared/*.csproj src/corePackages/Core.Shared/
COPY src/projects/Adults/AdultView/Application/*.csproj src/projects/Adults/AdultView/Application/
COPY src/projects/Adults/AdultView/Persistance/*.csproj src/projects/Adults/AdultView/Persistance/
COPY src/projects/Adults/AdultView/WebAPI/*.csproj src/projects/Adults/AdultView/WebAPI/

RUN dotnet restore src/projects/Adults/AdultView/WebAPI/*.csproj
COPY . . 
RUN dotnet publish src/projects/Adults/AdultView/WebAPI/*.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","WebAPI.dll" ]