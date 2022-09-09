FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["test-datingapp/test-datingapp.csproj", "test-datingapp/"]
RUN dotnet restore "test-datingapp/test-datingapp.csproj"
COPY . .
WORKDIR "/src/test-datingapp"
RUN dotnet build "test-datingapp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "test-datingapp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "test-datingapp.dll"]
