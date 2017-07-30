#!/bin/sh

TOOL_VERSION=1.4.x
TOOL_TARGET_OS=macosx_x64
SRC_DIR=.
DST_DIR=Assets/App/Scripts

./packages/Grpc.Tools.$TOOL_VERSION/tools/$TOOL_TARGET_OS/protoc \
	-I$SRC_DIR \
	--csharp_out $DST_DIR \
	--grpc_out $DST_DIR \
	helloworld.proto \
	--plugin=protoc-gen-grpc=packages/Grpc.Tools.$TOOL_VERSION/tools/$TOOL_TARGET_OS/grpc_csharp_plugin
