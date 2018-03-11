#!/usr/bin/env bash

set -eu
set -o pipefail

ROOT=$(dirname "$0")
FAKE="$ROOT/fake.sh"
BUILD_FSX="$ROOT/build.fsx"

FSIARGS=""
OS=${OS:-"unknown"}
if [[ "$OS" != "Windows_NT" ]]
then
  FSIARGS="--fsiargs -d:MONO"
fi

function run() {
  if [[ "$OS" != "Windows_NT" ]]
  then
    mono "$@"
  else
    "$@"
  fi
}

run $FAKE run "$@" $FSIARGS $BUILD_FSX
