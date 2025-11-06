#include <stdio.h>

int main() {
    char str[100];  

    printf("Zadejte slovo: ");
    scanf("%s", str);  

    for (int i = 1; str[i] != '\0'; i += 2) {  
        str[i] = '#';  
    }


    printf("Vycenzurovany retezec: %s\n", str);

    return 0;
}
