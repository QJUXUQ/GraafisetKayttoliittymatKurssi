# 04_Switch

Kirjoita Windows Forms -ohjema, jonka pääformissa (Kuva 1-1) on 5 nappia. Huomaa, että kaikki napit käyttävät samaa tapahtumankäsittelijää (metodia). Kun jotakin nappia klikataan hiirellä, niin nappia vastaava Messagebox esitetään näytöllä (Kuva 1-2). Käytä valintojen tekemiseen switch-lausetta. 

 

Button click event antaa atribuutteina objektin mikä kutsui sitä ja tapahtuman tiedon. Object on kaikkien lomakkeen controllien(nappi, textbox, label ym.) yläluokka. Ja se täytyy muuttaa haluttuun muotoon, jotta voimme hyödyntää sen ominaisuuksia. 

```c#
private void ButtonClick(object sender, EventArgs e) 

{ 

Button painettuNappi = sender as Button; 

} 

```

Castaus  on explisiittinen muunnos ja johtaa helposti virheisiin ja tiedon menettämiseen, jos sitä ei käytä harkiten. Koska aliluokassa on kaikki yläluokan kentät ja metodit ja sidomme metodin vain nappeihin on se nyt luvallista.  


Muunnoksen jälkeen voit käyttää kaikkia napin ominaisuuksia, mitä designerissäkin näkyy.  

painettuNappi.BackColor, painettuNappi.Text... 

![switch_01](https://github.com/Gradia-Ohjelmistokehitys-k2022/graafiset-kayttoliittymat-pohja/blob/main/04_Switch/kuvat/switch01.png)

Kuva 1. Pääformi

![switch_02](https://github.com/Gradia-Ohjelmistokehitys-k2022/graafiset-kayttoliittymat-pohja/blob/main/04_Switch/kuvat/switch02.png)

Kuva 2. Messuboksit
