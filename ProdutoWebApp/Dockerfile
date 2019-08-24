FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY ProdutoWebApp/ProdutoWebApp.csproj ProdutoWebApp/
RUN dotnet restore ProdutoWebApp/ProdutoWebApp.csproj
COPY . .
WORKDIR /src/ProdutoWebApp
RUN dotnet build ProdutoWebApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ProdutoWebApp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProdutoWebApp.dll"]
