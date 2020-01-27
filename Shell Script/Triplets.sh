#!/bin/sh
#Print the numbers in array which will give sum of 3 elements is 0
echo "Enter the length of array"
read arraylength
n=$arraylength
sum=0
#Read the array elements through user inputo

echo "Enter the elements"
for(( i=0; i<n; i++))
do
	read arr[${i}]
done
for(( i=0; i<n-2; i++ ))
#do
 #   for(( j=0; j<n-1; j++ ))
  #  do
#	
#	for(( k=0; k<n; k++ ))
#	do
	sum=$(IFS=+; echo "$((${arr[*]}))")
echo $sum

	#sum= $(( $arr[i] + $arr[j] + $arr[k] ))
	   # if [ $sum=0 ]
	   # then
           # echo  "is zero"
	 #   fi
#done
#done
#done
