FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80

COPY src/corePackages/Core.Shared/*.csproj src/corePackages/Core.Shared/
COPY src/projects/Gender/Gender.Application/*.csproj src/projects/Gender/Gender.Application/
COPY src/projects/Gender/Gender.Persistance/*.csproj src/projects/Gender/Gender.Persistance/
COPY src/projects/Gender/Gender.WebAPI/*.csproj src/projects/Gender/Gender.WebAPI/

RUN dotnet restore src/projects/Gender/Gender.WebAPI/*.csproj
COPY . .
RUN dotnet publish src/projects/Gender/Gender.WebAPI/*.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","Gender.WebAPI.dll" ]