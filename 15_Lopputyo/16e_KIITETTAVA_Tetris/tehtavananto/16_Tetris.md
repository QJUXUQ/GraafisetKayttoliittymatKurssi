# 16_Tetris (kiitettävä arvosana)

Tetriksessä on tarkoitus kerätä pisteitä pudottelemalla neljästä laatikosta koostuvia 
palikoita, tetrominoja, joita on seitsemän erilaista ja koota niistä rivejä jotka täyttävät 
suorakulmaisen pelialueen vaakasuoraan laidasta laitaan.

1. Peliä pelataan viidellä näppäimellä: oikealle, vasemmalle, kierrä myötäpäivään, 
kierrä vastapäivään ja pudota. Voit määritellä näppäimet itse.
a. Pelaaja voi siirtää palikoita sivuttain oikealle ja vasemmalle näppäimillä. 
Palikka siirtyy yhden paikan jokaista näppäimen alaspainoa kohden.
b. Pelaaja voi myös kiertää palikoita myötä- ja vastapäivään vastaavilla 
näppäimillä. Jokainen näppäimen alaspainallus kiertää palikkaa 90°.
c. Pelaaja voi myös pudottaa palikan suoraan alas painamalla pudotanäppäintä.

2. Palikat putoavat itsekseen vakionopeudella joka kasvaa vaikeusasteen 
kasvaessa. Vaikeusaste voi olla vakio, ts. sinun ei tarvitse toteuttaa kasvavaa 
vaikeusastetta ellet halua.

3. Kun palikka on saavuttanut palikkapinon, tai pelialueen pohjan, ja jos yksi tai 
useampi rivi on kokonainen, se/ne poistetaan ja ylempänä olevat rivit putoavat 
alemmaksi. Täyttämällä kaksi tai kolme riviä kerralla saa enemmän pisteitä kuin 
yhden rivin poistamisesta. Eniten pisteitä saa poistamalla neljä riviä kerralla. 
Tämä peliliike on nimeltään tetris.

![tetromiino](https://github.com/Gradia-Ohjelmistokehitys-k2022/graafiset-kayttoliittymat-pohja/blob/main/Lopputyo/16e_KIITETTAVA_Tetris/kuvat/tetris01.png)

Tehtäväsi on ohjelmoida Tetris. Vaikeustaso ja pistelasku ovat vapaaehtoisia 
ominaisuuksia
