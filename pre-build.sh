#!/bin/bash
set -e

sed -i'' -e 's|<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="1.1.0" />|<PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL" Version="1.1.0" />|' src/SimplCommerce.WebHost/SimplCommerce.WebHost.csproj
sed -i'' -e 's/UseSqlServer/UseNpgsql/' src/SimplCommerce.WebHost/Startup.cs
sed -i'' -e 's/UseSqlServer/UseNpgsql/' src/SimplCommerce.WebHost/Extensions/ServiceCollectionExtensions.cs

rm -rf src/SimplCommerce.WebHost/Migrations/*
