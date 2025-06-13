valor = int(input()) #576

print(valor)

notas = valor // 100 #5 notas
resto = valor % 100 #sobra 76
valor = resto
print(notas, "nota(s) de R$ 100,00")

notas = valor // 50 #5
resto = valor % 50 #76
valor = resto
print(notas, "nota(s) de R$ 50,00")

notas = valor // 20 #5
resto = valor % 20 #76
valor = resto
print(notas, "nota(s) de R$ 20,00")

notas = valor // 10 #5
resto = valor % 10 #76
valor = resto
print(notas, "nota(s) de R$ 10,00")

notas = valor // 5 #5
resto = valor % 5 #76
valor = resto
print(notas, "nota(s) de R$ 5,00")

notas = valor // 2 #5
resto = valor % 2 #76
valor = resto
print(notas, "nota(s) de R$ 2,00")

notas = valor // 1 #5
resto = valor % 1 #76
print(notas, "nota(s) de R$ 1,00")
