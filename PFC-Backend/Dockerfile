#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY PFC-Backend/PFC-Backend.csproj PFC-Backend/
RUN dotnet restore "PFC-Backend/PFC-Backend.csproj"
COPY . .
WORKDIR "/src/PFC-Backend"
RUN dotnet build "PFC-Backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PFC-Backend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
RUN mkdir Data
COPY ./PFC-Backend/Data/ ./Data/
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PFC-Backend.dll"]
