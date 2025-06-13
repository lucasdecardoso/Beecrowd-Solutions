tempo_viagem = int(input())
velocidade_media = int(input())

combustivel = (tempo_viagem * velocidade_media) / 12
print("{:.3f}".format(combustivel))
