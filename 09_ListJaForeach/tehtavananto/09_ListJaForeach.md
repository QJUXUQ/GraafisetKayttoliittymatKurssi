# 09_List ja Foreach

Kirjoita Windows Forms -ohjelma, jonka formissa on toiminnot listan luontia, merkkijonojen lisäämistä, listan sisällön hakemista ja tulostamista varten (Kuva 1).  

![paaformi](https://github.com/Gradia-Ohjelmistokehitys-k2022/graafiset-kayttoliittymat-pohja/blob/main/09_ListJaForeach/kuvat/listjaforeachpaaformi01.png)

Kuva 1. Pääformi 

a) Kirjoita ensin listan luontitoiminto. Kun formissa olevaa Luo lista -nappia klikataan, niin luodaan String-tyyppinen lista  (Kuva 1.). 

 - Testaa ohjelman toimivuus tässä vaiheessa eli varmista debuggerin avulla, että lista tulee luoduksi. Kysy tarvittaessa opettajalta neuvoa kuinka tarkistuksen voi tehdä! 

b) Lisää formiin toiminto, jolla voi lisätä uusia merkkijonoja listaan. Kun tekstikenttään kirjoittaa merkkijonon ja klikkaa Lisää-nappia, niin napin tapahtumankäsittelijässä lisätään kyseinen merkkijono listaan. 

 - Tarkista jälleen debuggerin avulla, että merkkijono meni listaan ! 

c) Lisää formiin toiminto, jolla voidaan hakea listan sisältö ja tulostaa kaikki listassa olevat merkkijonot ComboBox-komponenttiin. Kun Haku-nappia klikataan, niin napin tapahtumankäsitelijässä luetaan foreach-luupissa listan sisältä alusta loppuun ja viedään jokainen listassa oleva merkkijono ComboBox-komponenttiin. 
