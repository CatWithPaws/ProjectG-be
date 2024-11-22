FROM mcr.microsoft.com/dotnet/sdk AS base

WORKDIR /app
COPY RestServer.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish RestServer.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet
ENV ASPNETCORE_URLS=http://+:5000
WORKDIR /app
COPY --from=base /app/publish .
ENTRYPOINT [ "dotnet", "RestServer.dll" ]