#include <stdio.h>

int main() {
    
    int horaInicial, minutoInicial, horaFinal, minutoFinal;
    
    scanf("%d %d %d %d", &horaInicial, &minutoInicial, &horaFinal, &minutoFinal);
    
    horaInicial = horaInicial * 60; //converter para minutos
    horaFinal = horaFinal * 60;
    minutoInicial =  minutoInicial + horaInicial;
    minutoFinal = minutoFinal + horaFinal;
    
    if (minutoFinal <= minutoInicial)
        minutoFinal = minutoFinal + 1440;
    
    printf("O JOGO DUROU %d HORA(S) E %d MINUTO(S)\n", (minutoFinal-minutoInicial)/60, (minutoFinal-minutoInicial)%60);
    
    return 0;
}
