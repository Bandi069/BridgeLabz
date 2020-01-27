#!/bin/sh 
echo "Enter the values "
read x
read y
a=$(( x*x ))
b=$(( y*y ))
value=$(( $a+$b ))
Distance=$value
Ans=$(awk -v x=$Distance 'BEGIN{print sqrt(x)}')
echo $Ans
