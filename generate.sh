#!/usr/bin/env bash

export GO_POST_PROCESS_FILE="$(which gofmt) -w"

openapi-generator generate \
  -i spec/openapi.yaml \
  -g go \
  -o sdk/go \
  -c config/go.yaml \
  -t templates/go
