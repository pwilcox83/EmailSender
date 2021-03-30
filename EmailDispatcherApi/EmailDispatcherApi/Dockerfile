FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Restoring packages can be done
# from just csproj
COPY *.csproj ./
RUN dotnet restore

# Copy everything else to build/publish
COPY . ./
RUN dotnet publish -c Release -o out --no-restore

# Build runtime image containing
# build/publish output
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "EmailDispatcherApi.dll"]