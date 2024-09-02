FROM mcr.microsoft.com/dotnet/aspnet:6.0-nanoserver-1809 AS base
WORKDIR /app
EXPOSE 5149

ENV ASPNETCORE_URLS=http://+:5149

FROM mcr.microsoft.com/dotnet/sdk:6.0-nanoserver-1809 AS build
ARG configuration=Release
WORKDIR /src
COPY ["RPG/RPG.csproj", "RPG/"]
RUN dotnet restore "RPG\RPG.csproj"
COPY . .
WORKDIR "/src/RPG"
RUN dotnet build "RPG/RPG.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "RPG/RPG.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RPG/RPG.dll"]
