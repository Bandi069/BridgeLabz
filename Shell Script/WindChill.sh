#!/bin/sh
echo "Enter Temperature"
read temp
echo "Enter Speed"
read velocity
if [ $temp -lt 51 -a $velocity -lt 120 -a $velocity -gt 3 ]
then
w=$(echo "$temp" "$velocity" | awk '{print 35.74+0.6215*$1+(0.4275*$1-35.75)*($2^0.16 )}')
echo $w
else
echo "out of Range"
fi
