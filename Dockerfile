FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src

COPY ["OnlineForum.sln", "."]
COPY ["Web/Web.csproj", "Web/"]
COPY ["BLL.DTO/BLL.DTO.csproj", "BLL.DTO/"]
COPY ["BLL.Infrastructure/BLL.Infrastructure.csproj", "BLL.Infrastructure/"]
COPY ["BLL.Interfaces/BLL.Interfaces.csproj", "BLL.Interfaces/"]
COPY ["BLL.Models/BLL.Models.csproj", "BLL.Models/"]
COPY ["DAL.Domain/DAL.Domain.csproj", "DAL.Domain/"]
COPY ["DAL.Infrastructure/DAL.Infrastructure.csproj", "DAL.Infrastructure/"]
COPY ["DAL.Interfaces/DAL.Interfaces.csproj", "DAL.Interfaces/"]
COPY ["OnlineForum.IntegrationTests/OnlineForum.IntegrationTests.csproj", "OnlineForum.IntegrationTests/"]
COPY ["OnlineForum.UnitTests/OnlineForum.UnitTests.csproj", "OnlineForum.UnitTests/"]
RUN dotnet restore 

COPY . .

#RUN dotnet build -c Release -o /app/build
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish ./
ENTRYPOINT ["dotnet", "Web.dll"]
