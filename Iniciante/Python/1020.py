dias_total = int(input()) #400

anos = dias_total // 365 
resto = dias_total % 365
mes = resto // 30
dias = resto % 30

print("{:.0f} ano(s)".format(anos))
print("{:.0f} mes(es)".format(mes))
print("{:.0f} dia(s)".format(dias))
