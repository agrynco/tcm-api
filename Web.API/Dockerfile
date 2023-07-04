FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["tcm-web-api/tcm-web-api.csproj", "tcm-web-api/"]
RUN dotnet restore "tcm-web-api/tcm-web-api.csproj"
COPY . .
WORKDIR "/src/tcm-web-api"
RUN dotnet build "tcm-web-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "tcm-web-api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENV ASPNETCORE_URLS=http://*:80

ENTRYPOINT ["dotnet", "tcm-web-api.dll"]
