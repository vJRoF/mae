FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Mae/Mae.csproj", "Mae/"]
RUN dotnet restore "Mae/Mae.csproj"
COPY . .
WORKDIR "/src/Mae"
RUN dotnet build "Mae.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mae.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mae.dll"]
