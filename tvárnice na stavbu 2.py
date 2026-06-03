program = """Program slouží k výpočtu tvárnic potřebných na zdění pomocí zadaných rozměrů steny a oken
Autor:
Jméno - Michal
Přijmení - Směták
Email - michal.smetak@office365.spspzlin.cz
Přihlášovací údaje:
Uživatelské jméno - stavebnik
Heslo - stavba
"""

print(program)

print("Konfigurátor zdícího systému")
print("****************************")

uzivatelske_jmeno = input("Zadej uživatelské jméno: ")
heslo = input("Zadej heslo: ")

uziv_jmeno_kontrola = "stavebnik"
heslo_kontrola = "stavba"

if uzivatelske_jmeno == uziv_jmeno_kontrola and heslo == heslo_kontrola:
    print("Vítejte!")
    delka_steny = float(input("Zadejte délku stěny (metry): "))
    vyska_steny = float(input("Zadejte výšku stěny (metry): "))
    vyska_okna = float(input("Zadejte výšku okna (metry): "))
    sirka_okna = float(input("Zadejte šířku okna (metry): "))
    plocha_tvarnice = 0.1

    plocha_steny = delka_steny * vyska_steny
    plocha_okna = vyska_okna * sirka_okna
    plocha_steny_bez_okna = plocha_steny - plocha_okna
    pocet_tvarnic = (plocha_steny - plocha_okna) / plocha_tvarnice

    print(f"Plocha stěny včetně okna: {plocha_steny} m^2")
    print(f"Plocha okna: {plocha_okna} m^2")
    print(f"Plocha stěny bez okna: {plocha_steny_bez_okna} m^2")
    print(f"Počet tvárnic potřebných k vyzdění plochy stěny: {pocet_tvarnic} ks")

    print("Dostupnost materiálu na pobočkách v ČR")
    print("**************************************")
    print("| Město   | Druh materiálu | Počet kusů na pobočce  |")
    print("*****************************************************")

    if pocet_tvarnic <= 500:
        print("| Praha   | tvárnice       | 500                    |")
    if pocet_tvarnic <= 300:
        print("| Brno    | tvárnice       | 300                    |")
    if pocet_tvarnic <= 700:
        print("| Ostrava | tvárnice       | 700                    |")

else:
    print("Zadali jste chybné jméno nebo heslo!")
    
