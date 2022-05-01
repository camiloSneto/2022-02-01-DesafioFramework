FROM mcr.microsoft.com/dotnet/sdk:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MathOperationService/MathOperationService.csproj", "MathOperationService/"]
COPY ["MathFunctions/MathFunctions.csproj", "MathFunctions/"]
RUN dotnet restore "MathOperationService/MathOperationService.csproj"
COPY . .
WORKDIR "/src/MathOperationService"
RUN dotnet build "MathOperationService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MathOperationService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app`enter code here`
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MathOperationService.dll"]