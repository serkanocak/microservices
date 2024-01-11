#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 7001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Ocak.Services.CouponAPI/Ocak.Services.CouponAPI.csproj", "Ocak.Services.CouponAPI/"]
RUN dotnet restore "Ocak.Services.CouponAPI/Ocak.Services.CouponAPI.csproj"
COPY . .
WORKDIR "/src/Ocak.Services.CouponAPI"
RUN dotnet build "Ocak.Services.CouponAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ocak.Services.CouponAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ocak.Services.CouponAPI.dll"]