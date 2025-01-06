# 16_Miinaharava (kiitettävä arvosana)

Tee Miinaharava-peli.
Miinaharavassa käytössä on pelilauta, jonka kaikki ruudut ovat alussa paljastamattomia. 
Laudalla on piilossa miinoja, joiden paikat pelaajan tulee merkitä lipuilla.
Käyttäjä voi valita…
1. helpon vaikeustason, jolloin laudan koko on 9 x 9 ruutua ja miinoja on 10.
2. keskivaikean vaikeustason, jolloin laudan koko on 16 x 16 ruutua ja miinoja on 40.
3. vaikean vaikeustason, jolloin laudan koko on 30 x 16 ruutua ja miinoja on 99.

Pelaaja klikkaa hiiren vasemmalla näppäimellä paljastamattomia ruutuja: jos ruudussa 
on miina, se räjähtää ja peli päättyy. Jos ruudussa ei ole miinaa, ruudussa näkyy, 
monessako ruudun kahdeksasta naapuriruudusta on miina.

Mikäli klikatun ruudun yhdessäkään naapuriruudussa ei ole miinaa, peli paljastaa ensin 
kaikki siihen yhteydessä olevat ruudut, joiden naapurissa ei myöskään ole miinaa, sekä 
lisäksi tämän paljastetun alueen reunalla olevat ruudut, joiden naapurissa on miina. 
Tämä ei helpota mutta nopeuttaa peliä etenkin suurella laudalla, jossa on vähän miinoja, 
koska "nollaruutuja" ei tarvitse klikkailla yksitellen.

Pelaaja voi oikealla hiirennapilla klikkaamalla merkitä paljastamattoman ruudun, jossa 
päättelee olevan miinan. Kun kaikki miinattomat ruudut on paljastettu, pelaaja on 
onnistunut ja hänen tuloksensa on käytetty aika.

*HUOM!* Luo pelialue ohjelmallisesti grafiikkana, eli älä käytä Form Designeriä 
nappien luomiseen.

Aloita pelin suunnittelu tekemällä käyttötapauskaavio. Käytä kaaviota eri 
käyttöliittymänäkymien havainnollistamiseen