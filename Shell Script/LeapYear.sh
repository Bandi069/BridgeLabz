#!/bin/sh
echo "Enter a Year to check leap year or not"
read Year
if [ $(( $Year%4 )) -eq 0 ] || [ $(( $Year%400 )) -eq 0 ] && [ $(( $Year%100 )) -ne 0 ]
then
	echo "Given year is Leap Year :$Year"
	else
	echo "Given Year is Non Leap Year : $Year"
fi
