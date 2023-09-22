#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
ENV ASPNETCORE_URLS="http://+:80;https://+:443"
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["feonao_webpage/feonao.csproj", "feonao_webpage/"]
RUN dotnet restore "feonao_webpage/feonao.csproj"
COPY . .
WORKDIR "/src/feonao_webpage"
RUN dotnet build "feonao.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "feonao.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "feonao.dll"]