FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY IzinYonetim/IzinYonetim.csproj IzinYonetim/
RUN dotnet restore IzinYonetim/IzinYonetim.csproj
COPY . .
WORKDIR /src/IzinYonetim
RUN dotnet build IzinYonetim.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish IzinYonetim.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "IzinYonetim.dll"]
