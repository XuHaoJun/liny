#!/bin/sh

# Generate code from OpenAPI spec
openapi-generator generate -i merged-line-openapi.yaml -g aspnetcore  -o ./ --additional-properties=compatibilityVersion=Version_8_0,packageName=Liny.Core,useNewtonsoft=false

# Check if dotnet csharpier is installed
if ! dotnet csharpier --version >/dev/null 2>&1; then
    echo "dotnet csharpier is not installed. Installing..."
    dotnet tool install --global csharpier
fi

# Format the generated code
echo "Formatting code with csharpier..."
dotnet csharpier .
