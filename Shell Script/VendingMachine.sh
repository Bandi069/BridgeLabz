#!/bin/sh
#Calculating Notes of given amount in vending Machine
echo "Enter Amount"
read Amount
Echo "Enter Noumber of Notes"
read NoteCounter
echo "Enter Notes "
for (( i=0; i<NoteCounter; i++ ))
do
 read Notes[$i]
done
echo  ${Notes[@]}
declare -a NotesCount
for
do

