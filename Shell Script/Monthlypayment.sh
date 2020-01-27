#!/bin/sh
#Calculating monthly payment
echo "Enter Principle Amount"
read PrincipalAmount
echo  "Enter Time Period in Years"
read year
echo "Enter rate of intrest per anum"
read RateofInterest
n=$(( 12*$year ))
r=$(( $RateofInterest/12*100 ))
#Monthly Payment 
payment=$(( $PrincipalAmount*$r/(1-(1+$r)^(-n)) ))
echo "Monthly payment is :"$payment
