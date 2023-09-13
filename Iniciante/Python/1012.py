#beecrowd | 1012 - Área

dadosTriangulo = input().split()
ladoA = float(dadosTriangulo[0])
ladoB = float(dadosTriangulo[1])
ladoC = float(dadosTriangulo[2])

print("TRIANGULO: {:.3f}".format((ladoA * ladoC)/2))
print("CIRCULO: {:.3f}".format(3.14159 * (ladoC**2)))
print("TRAPEZIO: {:.3f}".format(((ladoA + ladoB) * ladoC) / 2))
print("QUADRADO: {:.3f}".format(ladoB**2))
print("RETANGULO: {:.3f}".format(ladoA * ladoB))
