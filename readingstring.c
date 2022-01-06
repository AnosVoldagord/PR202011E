#include<stdio.h>
main()
{
	FILE *fptr;
	char str[200];
	printf("Enter Some Strings:");
	fptr = fopen("string.txt","a");
	while (strlen(gets(str))>0)
	{
		fputs(str,fptr);
		fputs("\n",fptr);
	}
	fclose(fptr);
}
