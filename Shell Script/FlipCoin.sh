#!/bin/sh
echo "How many nos want to add"
read n
int = 0
total =0
while [ $count -lt $n]
do
echo "Enter Numbers"
read x
count = 'expr $ count +1'
total = 'expr $count+1'
done
echo "$total"
