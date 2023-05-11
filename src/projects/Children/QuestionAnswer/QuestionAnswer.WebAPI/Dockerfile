FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80

COPY src/projects/QuestionAnswer/QuestionAnswer.WebAPI/*.csproj src/projects/QuestionAnswer/QuestionAnswer.WebAPI/
COPY src/projects/QuestionAnswer/QuestionAnswer.DataAccess/*.csproj src/projects/QuestionAnswer/QuestionAnswer.DataAccess/
COPY src/projects/QuestionAnswer/QuestionAnswer.Business/*.csproj src/projects/QuestionAnswer/QuestionAnswer.Business/

RUN dotnet restore src/projects/QuestionAnswer/QuestionAnswer.WebAPI/*.csproj 
COPY . . 
RUN dotnet publish src/projects/QuestionAnswer/QuestionAnswer.WebAPI/*.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY  --from=build /app/out .
ENTRYPOINT [ "dotnet","QuestionAnswer.WebAPI.dll" ]