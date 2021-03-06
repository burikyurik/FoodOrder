#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["PaymentService/FoodOrder.Payment.Api/FoodOrder.Payment.Api.csproj", "PaymentService/FoodOrder.Payment.Api/"]
COPY ["Common/FoodOrder.Models/FoodOrder.Shared.Models.csproj", "Common/FoodOrder.Models/"]
RUN dotnet restore "PaymentService/FoodOrder.Payment.Api/FoodOrder.Payment.Api.csproj"
COPY . .
WORKDIR "/src/PaymentService/FoodOrder.Payment.Api"
RUN dotnet build "FoodOrder.Payment.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FoodOrder.Payment.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FoodOrder.Payment.Api.dll"]
