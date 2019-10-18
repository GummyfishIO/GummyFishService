FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY gummyfishNameService/*.csproj ./gummyfishNameService/
RUN dotnet restore

# copy everything else and build app
COPY gummyfishNameService/. ./gummyfishNameService/
WORKDIR /app/gummyfishNameService
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/gummyfishNameService/out ./
ENTRYPOINT ["dotnet", "gummyfishService.dll"]