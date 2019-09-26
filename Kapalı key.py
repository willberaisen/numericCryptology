sözlük={48:"a",
        15:"b",
        23:"c",
        12:"ç",
        71:"d",
        91:"e",
        32:"f",
        73:"g",
        83:"ğ",
        19:"h",
        65:"ı",
        41:"i",
        26:"j",
        94:"k",
        63:"l",
        58:"m",
        79:"n",
        49:"o",
        95:"ö",
        59:"p",
        56:"r",
        31:"s",
        10:"ş",
        45:"t",
        89:"u",
        20:"ü",
        21:"v",
        97:"y",
        42:"z",
        68:"w",
        30:"q",
        52:" "}
while True:
    metin= input("şifreli kod:")
    çevirilmiş=""
    uzunluk=len(metin)

    for i in range(0,uzunluk,2):
        çevirilmiş+=sözlük[int(metin[i]+metin[i+1])]

    print(çevirilmiş)

input

