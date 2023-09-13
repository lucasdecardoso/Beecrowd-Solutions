#beecrowd | 1010 - Cálculo Simples

totalCompra = 0

for i in range(2):
    dadosCompra = input().split()   
    totalCompra = totalCompra + float(dadosCompra[1]) * float(dadosCompra[2])

print("VALOR A PAGAR: R$ {:.2f}".format(totalCompra))
