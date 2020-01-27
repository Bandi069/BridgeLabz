#!/bin/sh
echo "Enter  a number"
read  Harmonic
sum=1
for(( i=2; i<=$Harmonic; $((i++)) ))
do
new=""+"1/$i"
sum=($sum$new)
done
echo $sum
