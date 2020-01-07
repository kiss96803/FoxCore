FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS builder

COPY . .

WORKDIR /src

RUN dotnet publish aspnetapp/FoxCore.csproj -c Release -o /app

RUN dotnet test --logger "trx;LogFileName=./aspnetapp.trx"

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

COPY --from=builder /app .

ENTRYPOINT ["dotnet", "FoxCore.dll"]
