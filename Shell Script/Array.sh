#!/bin/sh
echo  "Enter number of Elements"
read n
#read m
echo "enter Numbers"
for(( i=0; i<n; i++ ))
do
 	read array[${i}]
done
echo "Print Array"
echo ${array[@]}
<<COMMENT
for i in "${array[@]}"
do
echo $i
done
COMMENT
