#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["DeliverySerive/FoodOrder.DeliverySerive/FoodOrder.DeliverySerive.csproj", "DeliverySerive/FoodOrder.DeliverySerive/"]
RUN dotnet restore "DeliverySerive/FoodOrder.DeliverySerive/FoodOrder.DeliverySerive.csproj"
COPY . .
WORKDIR "/src/DeliverySerive/FoodOrder.DeliverySerive"
RUN dotnet build "FoodOrder.DeliverySerive.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FoodOrder.DeliverySerive.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FoodOrder.DeliverySerive.dll"]