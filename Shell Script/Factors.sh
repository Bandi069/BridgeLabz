#!/bin/sh
echo "Enter a number  to find factors"
read InputValue

for(( i=2; i<=$InputValue; i++ ))
do
while(( InputValue%$i == 0 ))
do
echo "$i"
InputValue=$(( $InputValue/$i ))
 done
done
