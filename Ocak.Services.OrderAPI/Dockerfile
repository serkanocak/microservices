#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 7004

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Ocak.Services.OrderAPI/Ocak.Services.OrderAPI.csproj", "Ocak.Services.OrderAPI/"]
COPY ["Ocak.MessageBus/Ocak.MessageBus.csproj", "Ocak.MessageBus/"]
RUN dotnet restore "Ocak.Services.OrderAPI/Ocak.Services.OrderAPI.csproj"
COPY . .
WORKDIR "/src/Ocak.Services.OrderAPI"
RUN dotnet build "Ocak.Services.OrderAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ocak.Services.OrderAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ocak.Services.OrderAPI.dll"]