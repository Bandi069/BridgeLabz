#!/bin/sh
ran=$(($RANDOM%100))
for i in 'seq 10'
do
 echo $ran
done

