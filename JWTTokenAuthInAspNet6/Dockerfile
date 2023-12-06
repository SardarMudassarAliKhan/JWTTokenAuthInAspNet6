#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["JWTTokenAuthInAspNet6/JWTTokenAuthInAspNet6.csproj", "JWTTokenAuthInAspNet6/"]
COPY ["JWTTokenAuthInAspNet6_BAL/JWTTokenAuthInAspNet6_BAL.csproj", "JWTTokenAuthInAspNet6_BAL/"]
COPY ["JWTTokenAuthInAspNet6_DAL/JWTTokenAuthInAspNet6_DAL.csproj", "JWTTokenAuthInAspNet6_DAL/"]
RUN dotnet restore "./JWTTokenAuthInAspNet6/./JWTTokenAuthInAspNet6.csproj"
COPY . .
WORKDIR "/src/JWTTokenAuthInAspNet6"
RUN dotnet build "./JWTTokenAuthInAspNet6.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./JWTTokenAuthInAspNet6.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JWTTokenAuthInAspNet6.dll"]