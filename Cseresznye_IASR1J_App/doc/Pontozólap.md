
# Pontozólap minta
Név: Lakatos Kincső
Neptun: IASR1J
## Projekt rövid leírása:
Egy `Windows Forms App`, ami User Controlokon keresztül megjeleníti a két tábla tartalmát. Jobb click-el új fuvart lehet hozzáadni. Illetve egy egyszerű webapplikáció a felhasználók megjelenítésére. A `hozott.html`  betöltésénél a backend lekér az  `Azure`-ban lévő adatbázisból miden felhasználót. Tartalmaz egy `Form`-ot, amivel új felhasználót lehet létrehozni.
## Hozott anyagok:
##### Saját Adatbázis
![Adatbázis](https://github.com/kincsolakatos/softwareengineering/blob/master/Cseresznye_IASR1J_App/doc/adatbazis.png)
-   `2x1p`  Az alkalmazásban használt táblánként pont (Users, Rides)
-   `1p`  Az adatbázis tartalmaz Constraint-eket (min 2)
-   `2p`  Az adatbázis saját Azure SQL szerveren van
-   `1p`  Az adatbázis adatainak forrásmegjelölése értsd: miből készült és hogyan:
> Az adatbázishoz az SQL-t a [ChatGPT](https://chatgpt.com/) generálta, majd a scripteket lefuttattam Visual studio-ban. Az adatbázisnak két táblája van, a Users tartalmazza a felhasználókat, a Rides pedig az utakat.
Részösszeg:  `6p`
##### Weboldal
-   `1p`  A weboldalnak van egy értelmezhető struktúrája
-   `1p`  A weboldal dinamikus tartalommal tölthető fel adatbázison keresztül
-   `1p`  A weboldal használ legalább 20 sor értelmes css-t
-   `1p`  A weboldal javascriptje más funkciót is ellát, mint az adatok betöltése
Részösszeg:  `4p`  Eddig:  `11p`
### Egyéb, extra

[](https://github.com/altinum/docfx_softeng/blob/master/project/softeng/ZH3_cherry_picking/pontlap_minta.md/#egy%C3%A9b-extra)

-   `2p`  Regex alkalmazása validáláson túl (PuzzleController.cs 70.sor)
-   `1p`  `Scaffold-DbContext`  használata

Részösszeg:  `3p`  Eddig:  `14p`

##### Bonyolultabb algoritmus használata értelmes feladatra

[](https://github.com/altinum/docfx_softeng/blob/master/project/softeng/ZH3_cherry_picking/pontlap_minta.md/#bonyolultabb-algoritmus-haszn%C3%A1lata-%C3%A9rtelmes-feladatra)

-   `1p`  Az algoritmus egy önállóan értelmezhető egységet képez, az alkalmazástól függetlenül
-   `1p`  Az algoritmus értelmes szerepet kap az alkalmazásban és nem lehet beépített megoldásokra kicserélni, nincs túlbonyolítva
-   `1p`  Az algoritmus az adatbázis adataira épít
-   `1p`  Az algoritmus (8. osztályig nem tanított) matematikai képletet is alkalmaz Élő pont számítás:  [https://en.wikipedia.org/wiki/Elo_rating_system](https://en.wikipedia.org/wiki/Elo_rating_system)

public abstract class EloCalculator
    {
        public static int CalculateElo(int currentElo,int puzzleRating,bool isSolved)
        {
            double K = 16;
            double E = 1 / (1 + Math.Pow(10, (puzzleRating - currentElo) / 400));
            return Convert.ToInt32(Math.Round(isSolved?currentElo+K*(1-E):currentElo-K*(E)));
        }
    }

Részösszeg:  `4p`  Eddig:  `18p`

### ASP .NET

[](https://github.com/altinum/docfx_softeng/blob/master/project/softeng/ZH3_cherry_picking/pontlap_minta.md/#asp-net)

-   `2p`  `program.cs`  beállítása  `wwwroot`  mappában tárolt statikus tartalmak megosztására

Részösszeg:  `2p`  Eddig:  `20p`

##### API végpontok

[](https://github.com/altinum/docfx_softeng/blob/master/project/softeng/ZH3_cherry_picking/pontlap_minta.md/#api-v%C3%A9gpontok)

[![swagger](https://github.com/altinum/docfx_softeng/raw/master/project/softeng/ZH3_cherry_picking/pontlapImages/swagger.png)](https://github.com/altinum/docfx_softeng/blob/master/project/softeng/ZH3_cherry_picking/pontlapImages/swagger.png)

-   `3p`  Teljes SQL tábla adatainak szolgáltatása API végponton keresztül (openings)
-   `2x2p`  SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül (getElo,getOpeningVariation)
-   `3p`  SQL tábla egy választható rekordjának törlése (deleteUser)
-   `5p`  Új rekord felvétele  `HttpPost`  metóduson keresztül SQL táblába (createUser)
-   `2x3p`  Rekord módosítása  `HttpPost`  metóduson keresztül SQL táblában (updateElo,changeUsername)
-   `2x5p`  Külső API végpont használata JS kódban, itt:  [Chess.com nap feladványa](https://api.chess.com/pub/puzzle),[Chess.com streamerek listája](https://api.chess.com/pub/streamers)  [![streamers](https://github.com/altinum/docfx_softeng/raw/master/project/softeng/ZH3_cherry_picking/pontlapImages/streamers.png)](https://github.com/altinum/docfx_softeng/blob/master/project/softeng/ZH3_cherry_picking/pontlapImages/streamers.png)

Részösszeg:  `31p`  Eddig:  `51p`

##### Javascript

[](https://github.com/altinum/docfx_softeng/blob/master/project/softeng/ZH3_cherry_picking/pontlap_minta.md/#javascript)

-   `2x5p`  DOM feltöltése javascripttel (streamerek neve és ikonja, twitch url) Részösszeg:  `10p`

## Összessen:  `61p`

