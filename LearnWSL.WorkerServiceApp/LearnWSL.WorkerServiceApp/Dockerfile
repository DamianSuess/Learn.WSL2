#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["LearnWSL.WorkerServiceApp/LearnWSL.WorkerServiceApp.csproj", "LearnWSL.WorkerServiceApp/"]
RUN dotnet restore "LearnWSL.WorkerServiceApp/LearnWSL.WorkerServiceApp.csproj"
COPY . .
WORKDIR "/src/LearnWSL.WorkerServiceApp"
RUN dotnet build "LearnWSL.WorkerServiceApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LearnWSL.WorkerServiceApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LearnWSL.WorkerServiceApp.dll"]