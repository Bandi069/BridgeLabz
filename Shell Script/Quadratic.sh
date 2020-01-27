#!/bin/sh 
echo "Enter Quotients of Quadratic equation"
read a
read b 
read c
delta=$(( b*b - 4*a*c ))
sq=$(awk -v x=$delta 'BEGIN{print sqrt(x)}')
sqrtv=$sq
if [ $delta -gt 0 ]
then
root1=$((-b+$sqrtv/2*$a))
echo $root1
root2=$((-b-$sqrtv/2*$a))
echo $root2  
fi
