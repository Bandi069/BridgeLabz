#!/bin/sh
#Program to print elapsion time
#Start Timer of StopWatch
echo "Press enter to start a timer"
read 
hour1=$(date +%H)
minute1=$(date +%M)
second1=$(date +%s)

#Stop block of StioWatch
echo "Press enter to stop Timer"
read 
hour2=$(date +%H)
minute2=$(date +%M)
second2=$(date +%s)
#Calculating Hour,Minute,Seconds
Hour=$(( $hour2-$hour1 ))
Minute=$(( $minute2-$minute1 ))
second=$(( $second2-$second1 ))

#Printing Time Elapsion
echo "Timer-> $Hour : $Minute : $second"

