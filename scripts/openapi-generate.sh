#!/bin/sh
openapi-generator generate -i merged-line-openapi.yaml -g aspnetcore  -o ./ --additional-properties=compatibilityVersion=Version_8_0,packageName=Liny.Core,useNewtonsoft=false