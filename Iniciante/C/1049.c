#include <stdio.h>

int main(){

    char palavra1[30],palavra2[30],palavra3[30];

    scanf("%s %s %s",palavra1,palavra2,palavra3);

    if(!strcmp(palavra1,"vertebrado")){

	if(!strcmp(palavra2,"ave")){

		if(!strcmp(palavra3,"carnivoro")){
			printf("aguia\n");
		}else{
			printf("pomba\n");
		}

	}else{
		if(!strcmp(palavra3,"onivoro")){
			printf("homem\n");
		}else{
			printf("vaca\n");
		}


	}

    }
    else{

	if(!strcmp(palavra2,"inseto")){

		if(!strcmp(palavra3,"hematofago")){
			printf("pulga\n");
		}else{
			printf("lagarta\n");
		}

	}else{
		if(!strcmp(palavra3,"hematofago")){
			printf("sanguessuga\n");
		}else{
			printf("minhoca\n");
		}


	}

    }


    return 0;
}
