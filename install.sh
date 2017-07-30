#!/bin/sh

temp_dir=packages/Grpc.Tools.1.4.x/tmp
curl_url=https://www.nuget.org/api/v2/package/Grpc.Tools/
mkdir -p $temp_dir && cd $temp_dir && curl -sL $curl_url > tmp.zip; unzip tmp.zip && cd .. && cp -r tmp/tools . && rm -rf tmp && cd ../..

chmod +x packages/Grpc.Tools.1.4.x/tools/macosx_x64/protoc
chmod +x packages/Grpc.Tools.1.4.x/tools/macosx_x64/grpc_csharp_plugin
