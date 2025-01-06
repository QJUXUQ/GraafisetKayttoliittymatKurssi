Olemme tähän asti käyttäneet Winformsin omia tapahtumia (eventtejä) ja tapahtumien käsittelijöitä (event handlers) , jotka toimivat ohjelmamme taustalla. Tapahtumat pohjautuvat .NETin delegaattisysteemiin , joka on osa ns. observer design patternia. Hyvänä analogiana voisi olla Youtuben kanava, jota voit seurata (hit that subscibe button). Seuraajia voi olla 0-N kappaletta ja kaikkia saavat ilmoituksen kun kanavalle tulee uutta sisältöä. Seuraavaksi pääset harjoittelemaan omien delegaattien ja eventtien luomista.

* https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-add-an-event-handler?view=netdesktop-6.0
* https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
* https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern


# Delegaatit ja eventit

## Warehouse Pickup Notification

Tehtävänäsi on suunnitella sovellus, jolla johon merkitään varastolta haettavia tuotteita ja niiden viimeinen hakupäivä. Kun tuotteen hakupäivää edeltävä päivä koittaa, niin sovelluksessa on toinen lomake, johon tulee ilmoitus haettavasta paketista ja sen sisällöstä. Toteuta sovelluksen aikailmoitus eventti ja sen hallinta itse. ÄLÄ käytä Visual Studion valmiita eventtejä, vaan luo ne itse.

 Mieti seuraavia asioita:
* Miten teet päivämäärän valinnan ja manuaalisen testaaminen?
* Missä kohtaa luot tuotteet ja miten tarkasti haluat tuotteiden eri tietoja antaa? Toisin sanoen luo erillinen luokka (Form1, Form2 lisäksi), joka kuvastaa varaston tuotetta. Tuotteen ominaisuuksia voisivat olla esimerkiksi tuotteen nimi, paino ja määrä.


