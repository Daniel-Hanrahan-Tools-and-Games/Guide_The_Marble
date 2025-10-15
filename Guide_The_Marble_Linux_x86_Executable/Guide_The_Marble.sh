#!/bin/sh
echo -ne '\033c\033]0;Guide_The_Marble\a'
base_path="$(dirname "$(realpath "$0")")"
"$base_path/Guide_The_Marble.x86_64" "$@"
