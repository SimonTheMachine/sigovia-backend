
# To build this image run the following command
# ````
# docker build -t sigovia-backend -f Dockerfile .
# `````
# To run the container
# ````
# docker run -d --name sigovia-backend --env-file .dev.env -p 8080:8080 -p 443:443 sigovia-backend
# ````

# Use the official ASP.NET Core runtime as the base image for .NET 8
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

# Use the SDK image to build the application with .NET 8
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "sigovia-backend.csproj"
RUN dotnet publish "sigovia-backend.csproj" -c Release -o /app/publish

# Use the runtime image to run the application
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "sigovia-backend.dll"]
