# Use SDK image to build the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["RecipeApp.csproj", "./"]
RUN dotnet restore "RecipeApp.csproj"
COPY . .
RUN dotnet publish "RecipeApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Use Runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "RecipeApp.dll"]