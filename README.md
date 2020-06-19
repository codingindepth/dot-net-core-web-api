# dot-net-core-web-api

This project is build using .net core web api and Language C#

# Installation

Install dot net core version 3

dotnet --version

dotnet new webapi -o ProductCSAPI

Remove system generated controllers and create models and controller

# Running Web API

dotnet build
dotnet run

# IDE

Visual Code

# Dockerize .NET Core API 

docker build -t productapp .   

docker run -d -p 8080:80 --name prod  productapp

docker ps -a  
