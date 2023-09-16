#URI Online Judge | 1048 - Aumento de Salário

salario = float(input())

if salario <= 400.00:
  novo_salario = salario + (salario * 0.15)
  reajuste_ganho = salario  * 0.15
  
  print("Novo salario: {:.2f}".format(novo_salario))
  print("Reajuste ganho: {:.2f}".format(reajuste_ganho))
  print("Em percentual: 15 %")

elif salario <= 800.00:
  novo_salario = salario + (salario * 0.12)
  reajuste_ganho = salario  * 0.12
  
  print("Novo salario: {:.2f}".format(novo_salario))
  print("Reajuste ganho: {:.2f}".format(reajuste_ganho))
  print("Em percentual: 12 %")

elif salario <= 1200.00:
  novo_salario = salario + (salario * 0.10)
  reajuste_ganho = salario  * 0.10
  
  print("Novo salario: {:.2f}".format(novo_salario))
  print("Reajuste ganho: {:.2f}".format(reajuste_ganho))
  print("Em percentual: 10 %")

elif salario <= 2000.00:
  novo_salario = salario + (salario * 0.07)
  reajuste_ganho = salario  * 0.07
  
  print("Novo salario: {:.2f}".format(novo_salario))
  print("Reajuste ganho: {:.2f}".format(reajuste_ganho))
  print("Em percentual: 7 %")

else:
  novo_salario = salario + (salario * 0.04)
  reajuste_ganho = salario  * 0.04
  
  print("Novo salario: {:.2f}".format(novo_salario))
  print("Reajuste ganho: {:.2f}".format(reajuste_ganho))
  print("Em percentual: 4 %")

