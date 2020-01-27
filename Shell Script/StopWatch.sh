#!/bin/sh
#Stop Watch program in shell scripting
#Timer Start Block

echo "Press enetr to start of timer"
read 
Begin=$(date '+%s')
echo "Begin Time : $Begin "

#Stop Timer Block
echo "press eneter to stop "
read  
Stop=$(date '+%s') 
echo "Stoped Time : $Stop"

#time elapsion
timer=$(( $Stop-$Begin ))
echo "Time Elapsion : $timer"
#Funtion Calling
ElapsionTimer $timer


ElapsionTimer()
{
Hours=0
Minutes=0
Seconds=0
timer=$1
if (( timer >= 3600 ))
then
Hours=$timer / 3600
timer=$timer % 3600
fi
if (( $timer >=60 ))
then
Minutes=$timer / 60
timer=$timer % 60
fi
Seconds=$timer
echo "${Hours}:${Minutes}:${Seconds}"
}
