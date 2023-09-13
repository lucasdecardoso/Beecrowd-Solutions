#beecrowd | 1015 - Distância Entre Dois Pontos

import math

plano1 = input().split()
plano2 = input().split()
x1 = float(plano1[0])
y1 = float(plano1[1])
x2 = float(plano2[0])
y2 = float(plano2[1])

distancia = ((x2 - x1)**2) + ((y2 - y1)**2)

print("{:.4f}".format(math.sqrt(distancia)))
