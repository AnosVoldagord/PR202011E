#include<stdio.h>
float n1,n2;
float area();
main()
{
	printf("Enter Two Numbers:");
	scanf("%f %f",&n1,&n2);
	printf("The Result Is %.1f",area(n1,n2));
}
float area()
{
	return(n1*n2);
}
