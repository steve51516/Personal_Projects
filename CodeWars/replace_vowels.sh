#!/bin/bash
# Script that replaces all vowels from input string
if [ -n "$1" ];
then
        result=$(printf "$1" | sed -e 's/a//gI; s/e//gI; s/i//gI; s/o//gI; s/u//gI' )
fi
echo "$result"
exit 0
