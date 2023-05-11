FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY src/corePackages/Core.Shared/*.csproj src/corePackages/Core.Shared/
COPY src/projects/Child/Child.Application/*.csproj src/projects/Child/Child.Application/
COPY src/projects/Child/Child.Persistance/*.csproj src/projects/Child/Child.Persistance/
COPY src/projects/Child/Child.WebAPI/*.csproj src/projects/Child/Child.WebAPI/

RUN dotnet restore src/projects/Child/Child.WebAPI/*.csproj
COPY . .
RUN dotnet publish src/projects/Child/Child.WebAPI/*.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","Child.WebAPI.dll" ]

