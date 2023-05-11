FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80

COPY src/projects/QuestionTitle/QuestionTitle.WebAPI/*.csproj src/projects/QuestionTitle/QuestionTitle.WebAPI/
COPY src/corePackages/Core.Shared/*.csproj src/corePackages/Core.Shared/
COPY src/projects/QuestionTitle/QuestionTitle.Application/*.csproj src/projects/QuestionTitle/QuestionTitle.Application/
COPY src/projects/QuestionTitle/QuestionTitle.Persistance/*.csproj src/projects/QuestionTitle/QuestionTitle.Persistance/

RUN dotnet restore src/projects/QuestionTitle/QuestionTitle.WebAPI/*.csproj
COPY . .
RUN dotnet publish src/projects/QuestionTitle/QuestionTitle.WebAPI/*.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","QuestionTitle.WebAPI.dll" ]