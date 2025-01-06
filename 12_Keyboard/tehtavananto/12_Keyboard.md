# 12_Keyboard

Tee lisäys harjoitukseen PaintAndMouse. Lisää ohjelmaan toiminnot joiden avulla Tikku-ukkoa voi liikutella näytöllä näppeinten a,s,d ja w avulla. 

Jotta aiemmin luodut TextBoxit eivät häiritsisi näppäimillä ohjaamista, tuhoa ne.

Lisää ohjelman alkuun:

a) Lisää formiin tapahtumankäsittelijät KeyUp ja KeyDown eventteihin. 

b) Lisää KeyDown eventin tapahtumankäsittelijään ohjelmalokiikka, jossa  if-else if -rakenteen avulla tutkitaan onko painettu a,s,d tai w -nappia. Kunkin napin omassa lohkossa Point-tietorakenteen x- ja y-koordinaattia lisätään/vähennetään yhdellä. 

c) Lisää KeyUp-eventin tapahtumankäsittelijään Invalidate()-metodin kutsu, jotta saadaan aikaiseksi Paint()-metodin kutsu. 

Kuinka saat estettyä ettei teksti kenttä ole valittuna? Ratkaisu löytyy tekstikentän ominaisuuksista. Laita TextBox:iin tabstop=false, jolloin niitä ei automaattisesti valita. Oletuksena tab arvoltaan pienin controlli, jolla on tabstop true, on valittuna lomakkeen käynnistyessä. 

![kuva](https://github.com/Gradia-Ohjelmistokehitys-k2022/graafiset-kayttoliittymat-pohja/blob/main/12_Keyboard/kuvat/keyboard01.png)

Kuva 1. Pääformi 
