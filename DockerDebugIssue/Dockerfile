FROM mcr.microsoft.com/dotnet/sdk:6.0
EXPOSE 80
WORKDIR /src
COPY . .
RUN dotnet publish -c Debug -o /app/build
ENTRYPOINT ["dotnet", "/app/build/DockerDebugIssue.dll"]
