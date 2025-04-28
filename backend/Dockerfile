FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Evently.Api/Evently.Api.csproj", "Evently.Api/"]
COPY ["src/Evently.Application/Evently.Application.csproj", "Evently.Application/"]
COPY ["src/Evently.Domain/Evently.Domain.csproj", "Evently.Domain/"]
COPY ["src/Evently.Contracts/Evently.Contracts.csproj", "Evently.Contracts/"]
COPY ["src/Evently.Infrastructure/Evently.Infrastructure.csproj", "Evently.Infrastructure/"]
COPY ["Directory.Packages.props", "./"]
COPY ["Directory.Build.props", "./"]
RUN dotnet restore "Evently.Api/Evently.Api.csproj"
COPY . ../
WORKDIR /src/Evently.Api
RUN dotnet build "Evently.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
ENV ASPNETCORE_HTTP_PORTS=5001
EXPOSE 5001
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Evently.Api.dll"]