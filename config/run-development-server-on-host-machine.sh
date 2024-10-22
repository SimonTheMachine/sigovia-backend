#!/bin/bash

# Provided that the local database is running using: 
# docker-compose -f config/docker-compose.yml up -d local-db

# Run this script using: 
# ./config/run-development-server-on-host-machine.sh

# Read and export the environment variables from the .env file in the config folder
while IFS= read -r line || [ -n "$line" ]; do
  if [[ ! "$line" =~ ^# && "$line" =~ .*=.* ]]; then
    export "$line"
  fi
done < config/.server-on-host-machine.env

# Run the application with dotnet from the project root
dotnet watch run
