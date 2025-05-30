#!/usr/bin/env bash

export GO_POST_PROCESS_FILE="$(which gofmt) -w"

openapi-generator generate \
  -i spec/openapi.yaml \
  -g go \
  -o sdk/go \
  -c config/go.yaml \
  -t templates/go

openapi-generator generate \
  -i spec/openapi.yaml \
  -g php \
  -o sdk/php \
  -c config/php.yaml \
  -t templates/php

openapi-generator generate \
  -i spec/openapi.yaml \
  -g csharp \
  -o sdk/csharp \
  -c config/csharp.yaml \
  -t templates/csharp
