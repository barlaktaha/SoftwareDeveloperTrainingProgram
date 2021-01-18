dolarDun = 7.35
dolarBugun = 7.45

#syntax: Yani farklı dillerdeki yazım biçimi.
if dolarDun>dolarBugun:
  print("Azalış Oku")   #indentation: boşluk bırakma içeri atma.
elif dolarDun<dolarBugun:
  print("Artış Oku")
else:
  print("Sabit Ok")
# else: kısmı için şu yapılabilirdi:
#elif dolarDun==dolarBugun:
 #print("Sabit Ok") 