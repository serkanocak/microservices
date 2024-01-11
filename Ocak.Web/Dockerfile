#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 7167

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Ocak.Web/Ocak.Web.csproj", "Ocak.Web/"]
RUN dotnet restore "Ocak.Web/Ocak.Web.csproj"
COPY . .
WORKDIR "/src/Ocak.Web"
RUN dotnet build "Ocak.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ocak.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ocak.Web.dll"]