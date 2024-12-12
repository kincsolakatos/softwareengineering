
# Pontozólap
Név: Lakatos Kincső

Neptun: IASR1J
## Projekt rövid leírása:
Egy `Windows Forms App`, ami User Control-okon keresztül megjeleníti a két tábla tartalmát. Fel lehet venni új utast, de törölni is lehet az utasokat. 
Egy egyszerű webapplikáció a felhasználók megjelenítésére. A `hozott.html`  betöltésénél a backend lekér az  `Azure`-ban lévő adatbázisból miden felhasználót. Tartalmaz egy `Form`-ot, amivel új felhasználót lehet létrehozni.
## Windows Forms Application
###  User Interface
![User Interface + Tábla adatainak megjelenítése Data Grid View-ban](https://github.com/kincsolakatos/softwareengineering/blob/master/Cseresznye_IASR1J_App/doc/UserInterface.gif)
- `1x2p` Az alkalmazásból a **kilépés csak megerősítő kérdés után** lehetséges. 
- `2x2p` Olyan alkalmazás **elrendezés, melyben gombok lenyomására UserControl-ok kerülnek elhelyezésre egy Panel vezérlőben**, teljesen kitöltve azt. Minden gombra jár a pont, amennyiben az funckionlalitással rendelkező UserControl-t tölt be. 
- `1x2p` **Anchorok alkalmazása**: az alkalmazás egészében meg van oldva, hogy az ablak átméretezésekor ki legyen használva a rendelkezésre álló terület.	

Részösszeg:  `8p` 
### Tábla adatainak megjelenítése `DataGridView`-ban 
- `1x2p` Adatok  megjelenítése 
- `1x2p` Ha a tábla adatforrása saját osztály. 

Részösszeg:  `4p`  Eddig:  `12p`
### Tábla adatainak megjelenítése `ListBox`-ban.
![Tábla adatainak megjelenítése ListBox-ban + Rekord törlése](https://github.com/kincsolakatos/softwareengineering/blob/master/Cseresznye_IASR1J_App/doc/AdatMegjelenites_Torles.gif) 
- `1x2p` Adatok  megjelenítése 
- `1x2p` Ha az adatok tetszőleges módszerrel, pl. `TextBox`-on keresztül szűrhetőek. 

Részösszeg:  `4p`  Eddig:  `16p`
###  Rekord törlése 
- `1x2p` Sikeres törlés
- `1x2p` Megerősítéshez kötött törlés

Részösszeg:  `4p`  Eddig:  `20p`
### Adatkötés `BindingSource` -on keresztül
![ Adatkötés BindingSource-on keresztül + Új rekord rögzítése](https://github.com/kincsolakatos/softwareengineering/blob/master/Cseresznye_IASR1J_App/doc/Adatkotes_UjRekord.gif)
- `1x2p` Működő  `BindingSource` 
- `1x1p` Egy `BindingSource`-ra egy gyűjemény megjelenítésére alkalmas vezérlő (ListÍBox, ComboBox, DataGridVIew) mellett más adatkötött vezérlő is van kötve, mint `TextBox`, `DateTimePicker`, `ComboBox` idegen kulcs értékének beállítására, stb. (`ComboBox`)

Részösszeg:  `3p`  Eddig:  `23p`
### Új rekord rögzítése 
A pontok összeadódnak. 
- `1x2p` master-detail reláció detail táblájába ÉS/VAGY több-a-több kapcsolatban álló táblák kapcsolótáblájába
- `1x2p` Ha csak az idegen kulcsok vannak felvéve
- `1x1p` Ha legalább egy nem kulcs mező, pl. _Mennyiség_ is fel van véve 
- `1x2p` Felugró ablakon keresztül történik _Ok_ és _Mégse_ gombbal
- `1x2p` Ha az űrlap legördülő dobozon vagy listán keresztül beállítható idegen kulcsot is tartalmaz

Részösszeg:  `9p`  Eddig:  `32p`
## ASP .NET
-   `2p`  `program.cs`  beállítása  `wwwroot`  mappában tárolt statikus tartalmak megosztására

Részösszeg:  `2p`  Eddig:  `34p`
### API végpontok
![API végpontok](https://github.com/kincsolakatos/softwareengineering/blob/master/Cseresznye_IASR1J_App/doc/API.gif)
-   `3p`  Teljes SQL tábla adatainak szolgáltatása API végponton keresztül 
-   `2p`  SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül
-   `3p`  SQL tábla egy választható rekordjának törlése (deleteUser)
-   `5p`  Új rekord felvétele  `HttpPost`  metóduson keresztül SQL táblába 

Részösszeg:  `13p`  Eddig:  `47p`
## Hozott anyagok:
### Saját Adatbázis
![Adatbázis](https://github.com/kincsolakatos/softwareengineering/blob/master/Cseresznye_IASR1J_App/doc/adatbazis.png)
-   `2x1p`  Az alkalmazásban használt táblánként pont (Users, Rides)
-   `2p`  Az adatbázis saját Azure SQL szerveren van
-   `1p`  Az adatbázis adatainak forrásmegjelölése értsd: miből készült és hogyan:
> Az adatbázishoz az SQL-t a [ChatGPT](https://chatgpt.com/) generálta, majd a scripteket lefuttattam Visual studio-ban. Az adatbázisnak két táblája van, a Users tartalmazza a felhasználókat, a Rides pedig az utakat.

Részösszeg:  `5p` Eddig:  `52p`
### Weboldal
![Weboldal](https://github.com/kincsolakatos/softwareengineering/blob/master/Cseresznye_IASR1J_App/doc/Weboldal.gif)
-   `1p`  A weboldalnak van egy értelmezhető struktúrája
-   `1p`  A weboldal dinamikus tartalommal tölthető fel adatbázison keresztül
-   `1p`  A weboldal használ legalább 20 sor értelmes css-t
-   `1p`  A weboldal javascriptje más funkciót is ellát, mint az adatok betöltése

Részösszeg:  `4p`  Eddig:  `56p`
### Egyéb, extra
-   `1p`  `Scaffold-DbContext`  használata

Részösszeg:  `1p`  Eddig:  `57p`
## Összesen:  `57p`

