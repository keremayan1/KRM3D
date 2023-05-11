FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80

COPY src/projects/ChildParents/ChildParents.WebAPI/*.csproj src/projects/ChildParents/ChildParents.WebAPI/
COPY src/corePackages/Core.Shared/*.csproj src/corePackages/Core.Shared/
COPY src/projects/ChildParents/ChildParents.Application/*.csproj src/projects/ChildParents/ChildParents.Application/
COPY src/projects/ChildParents/ChildParents.Persistance/*.csproj src/projects/ChildParents/ChildParents.Persistance/

RUN dotnet restore src/projects/ChildParents/ChildParents.WebAPI/*.csproj
COPY . .
RUN dotnet publish src/projects/ChildParents/ChildParents.WebAPI/*.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","ChildParents.WebAPI.dll" ]