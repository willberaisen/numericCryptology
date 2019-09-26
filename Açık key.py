sözlük={"a":48,
        "b":15,
        "c":23,
        "ç":12,
        "d":71,
        "e":91,
        "f":32,
        "g":73,
        "ğ":83,
        "h":19,
        "ı":65,
        "i":41,
        "j":26,
        "k":94,
        "l":63,
        "m":58,
        "n":79,
        "o":49,
        "ö":95,
        "p":59,
        "r":56,
        "s":31,
        "ş":10,
        "t":45,
        "u":89,
        "ü":20,
        "v":21,
        "y":97,
        "z":42,
        "w":68,
        "q":30,
        " ":52}
print("Şifreleme Ahmet-Deniz")
while True:
    
    şifreli=""
    şifrelenecek=input("Çevrilecek metni giriniz: ")
    for i in şifrelenecek:
        şifreli+=str(sözlük[i])

    print(şifreli)
    
input
        
        
