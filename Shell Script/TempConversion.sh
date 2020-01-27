#!/bin/sh
# Converting Temperature from Fahrenheit to celsius and vice vers in shell scripting 
echo -e "Enter a Number for conversion type \n1.Farenheit to Celsius \n2.Celsius to Farenheit"
read Choice
case "$Choice" in
1) echo "Enter a Fahrenheit Temperature"
	read  FTemp
	Celsius=$(( ($FTemp-32)*5/9 ))
	echo  "Converted Celsius Temp is : $Celsius"
;;

2) echo "Enter a celsius Temperature"
	read CelsiusTemp
	FaherenheitTemp=$(( ($CelsiusTemp*9/5)+32 ))
	echo $FaherenheitTemp
;;
*) echo "Invalid Choice"
;;
esac



