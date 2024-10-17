# To build this image run
# `````
# docker build --platform=linux/amd64 -t sigovia-local-db -f db.Dockerfile .
# `````
# To run the container
# ````
# docker run -d --name sigovia-local-db --env-file .dev.env -p 1433:1433 sigovia-local-db
# ````

# Use the official Microsoft SQL Server image as the base image
FROM mcr.microsoft.com/mssql/server:2022-latest

# Set environment variables required to configure SQL Server
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=dockerStrongPwd123
# Specify the database name 
ENV MSSQL_DBNAME=SigoviaDb
# Expose the SQL Server port
EXPOSE 1433

# Run SQL Server process
CMD ["/opt/mssql/bin/sqlservr"]