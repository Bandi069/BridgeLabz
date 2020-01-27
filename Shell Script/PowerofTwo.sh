 #!/bin/sh
echo "Enter a Number "
read n
P=1
for(( i =1; i<= $n; i++ )) 
do
P=$(( P*2 ))
echo "Power of two is: $P "
done

