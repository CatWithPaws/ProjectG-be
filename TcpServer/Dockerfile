FROM mcr.microsoft.com/dotnet/sdk AS base

WORKDIR /app
COPY TcpServer.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish TcpServer.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet
ENV ASPNETCORE_URLS=http://+:4000
WORKDIR /app
COPY --from=base /app/publish .
ENTRYPOINT [ "dotnet", "TcpServer.dll" ]