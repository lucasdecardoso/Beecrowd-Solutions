#beecrowd | 1009 - Salário com Bônus

nomeVendedor = str(input())
salarioVendedor = float(input())
totalVendas = float(input())

print("TOTAL = R${: .2f}".format(salarioVendedor + totalVendas * 0.15))
