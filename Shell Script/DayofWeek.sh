#!/bin/sh
#Print Dayof the week by user inputs
#Year ,Month and Date

echo "Enter Year "
read Year
echo "Enter Month "
read month
echo "Enter Date "
read date 
#Mathematical Part for finding day 
y=$(( Year-(( 14-month )) / 12 ))
x=$(( $y+$y/4-$y/100+$y/400 ))
m=$(( $month +12*((((  14- $month )) /12 ))-2 ))
d=$(((( $date + $x +31* $m/12 )) % 7 ))

#Case  statement for printing day
case "$d" in
0) echo "Sunday "
;;
1) echo "Monday"
;;
2) echo "Tuesday"
;;
3) echo "Wednsday"
;;
4) echo "Thursday"
;;
5) echo "Friday "
;;
6) echo "Saturday"
;;
*) echo "Invalid "
;;
esac
