#include<stdio.h>
main()
{
	int a= 500,*ptr;
	ptr= &a;
	a++;
	printf("The value ptr is %d\n",ptr);
	printf("The value *ptr is %d\n",*ptr);
}
