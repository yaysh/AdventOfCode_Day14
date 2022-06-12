FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AdventOfCode2021/AdventOfCode2021.csproj", "AdventOfCode2021/"]
RUN dotnet restore "AdventOfCode2021/AdventOfCode2021.csproj"
COPY . .
WORKDIR "/src/AdventOfCode2021"
RUN dotnet build "AdventOfCode2021.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AdventOfCode2021.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdventOfCode2021.dll"]
