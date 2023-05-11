FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80

COPY src/corePackages/Core.Shared/*.csproj src/corePackages/Core.Shared/
COPY src/projects/ChildMaterializedView/Application/*.csproj src/projects/ChildMaterializedView/Application/
COPY src/projects/ChildMaterializedView/Persistance/*.csproj src/projects/ChildMaterializedView/Persistance/
COPY src/projects/ChildMaterializedView/WebAPI/*.csproj src/projects/ChildMaterializedView/WebAPI/

RUN dotnet restore src/projects/ChildMaterializedView/WebAPI/*.csproj
COPY . .
RUN dotnet publish src/projects/ChildMaterializedView/WebAPI/*.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","WebAPI.dll" ]