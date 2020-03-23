
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/RoteProcessing.API/RoteProcessing.API.csproj", "src/RoteProcessing.API/"]
COPY ["src/RoteProcessing.Infra/RoteProcessing.Infra.csproj", "src/RoteProcessing.Infra/"]
COPY ["src/RoteProcessing.Domain/RoteProcessing.Domain.csproj", "src/RoteProcessing.Domain/"]
RUN dotnet restore "src/RoteProcessing.API/RoteProcessing.API.csproj"
COPY . .
WORKDIR "/src/src/RoteProcessing.API"
RUN dotnet build "RoteProcessing.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RoteProcessing.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RoteProcessing.API.dll"]
