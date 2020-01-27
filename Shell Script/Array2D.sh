#!/bin/sh 
echo  "Enter the number of rows"
read rows
echo "Enter the number of columns"
read columns
echo "Enter the elements of array"
for(( i=0; i<rows; i++ ))
do
for(( j=0; j<columns; j++ ))
do
    read array[${i},${j}]
done
done
echo "print Array "
for(( i=0; i<rows; i++ ))
do
for(( j=0; j<columns; j++ ))
do  
  echo -ne  "${array[${i},${j}]}\t"
done
echo
done

