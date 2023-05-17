FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80

COPY src/corePackages/Core.Shared/*.csproj src/corePackages/Core.Shared/
COPY src/projects/Children/ChildMaterializedView/Application/*.csproj src/projects/Children/ChildMaterializedView/Application/
COPY src/projects/Children/ChildMaterializedView/Persistance/*.csproj src/projects/Children/ChildMaterializedView/Persistance/
COPY src/projects/Children/ChildMaterializedView/WebAPI/*.csproj src/projects/Children/ChildMaterializedView/WebAPI/

RUN dotnet restore src/projects/Children/ChildMaterializedView/WebAPI/*.csproj
COPY . .
RUN dotnet publish src/projects/Children/ChildMaterializedView/WebAPI/*.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","WebAPI.dll" ]