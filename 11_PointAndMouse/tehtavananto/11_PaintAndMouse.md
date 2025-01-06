# 11_PaintAndMouse

Tässä harjoituksessa on tarkoitus tutustua piirtämiseen Paint()-metodissa ja siihen, kuinka hiirtä käsitellään ohjelmassa. Harjoituksessa tehdään  ohjelma, jossa hiirtä klikkaamalla ja siirtämällä ohjataan tikku-ukkoa näytöllä (Kuva 1-1). 

Aloita lisämäällä Paint -tapahtuma lomakkeelle vrt click -event. 

  ![paintandmouse01](https://github.com/Gradia-Ohjelmistokehitys-k2022/graafiset-kayttoliittymat-pohja/blob/main/11_PointAndMouse/kuvat/PaintAndMouse01.png)
  
  Kuva 1. Tikku-ukko 
  

Ohjelmassa tarvitaan seuraavat rakenteet: 

Vaihe1 

// MainFrom:n alkuun määritellään koordinaattipiste(x,y), joka on käytössä koko lomakkeella. //Tällä pisteellä määritämme mistä aloitamme piirtämisen. Formin vasen ylänurkka on 0,0 //piste  

  
```c#
 Point piste = new Point(0, 0); 

// Talletetaan grafiikkaobjekti. Grafiikkaobjekti tarvitaan 

// grafikan piirtämiseksi näytölle. 

private void MainForm_Paint(object sender, PaintEventArgs e) 

        { 

Graphics Graf = e.Graphics; 

// - Pää 

Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49); 

Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49); 

// - Selkä 

Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41, 

piste.X + 21, piste.Y + 131); 

// - Kädet 

Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60, 

piste.X + 70, piste.Y + 60); 

// - Jalat 

Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131, 

piste.X - 30, piste.Y + 181); 

Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131, 

piste.X + 70, piste.Y + 181); 

  

// Kutsutaan DrawCoordinates()-metodia. 

DrawCordinates(Graf); 

} 

// DrawCoordinates() -metodi PIIRTÄÄ pisteen koordinaatit lomakkeelle.  

  

private void DrawCordinates(Graphics Graf) 

{ 

    // Piirretään piirtokoordinaattien arvot näytölle. 

    Graf.DrawString("(" + piste.X + " ," + piste.Y + ")", 

                    new Font("Arial", 14, System.Drawing.FontStyle.Regular), 

                    new SolidBrush(Color.Black), 8, 30); 

} 
```
  
Vaihe 2 

Siirrä DrawCoordinates metodin piirros oikeaan alakulmaan. Lisää teksti -kenttä ja nappi mihin käyttäjä voi syöttää halutun x,y -koordinaatin ja ohjelma piirtää tikku-ukon uudelleen kyseiseen paikkaan. 


Tikku-ukkoa ei piirretä automaattisesti uudestaan kun koordinaatti muuttuu. Invalidate -metodi merkkaa lomakkeen ”epäkelvoksi”, jolloin saadaan aikaiseksi 

paint-eventin signalointi ja tämän jälkeen Paint()-metodin kutsu. 

Napin painamis metodin loppuun lisää siis kutsu: 
```c#
Invalidate(); 
```

![paintandmouse01](https://github.com/Gradia-Ohjelmistokehitys-k2022/graafiset-kayttoliittymat-pohja/blob/main/11_PointAndMouse/kuvat/PaintAndMouse02.png)

Kuva 2. Tikku-ukko numero kaksi

Vaihe 3: 

Lisätään lomakkeelle mahdollisuus määrittää koordinaattipiste hiiren vasenta nappia painamalla. 

  
```c#
    private void MainForm_MouseDown(object sender, MouseEventArgs e) 

        {  

            if (e.Button == MouseButtons.Left) 

            { 

                // Talletetaan hiiren klikkauskohdan koordinaatit. Piste (0, 0) 

                // on formin työalueen vasemmassa ylä nurkassa 

                piste = e.Location; 

  

                // Merkitään formin työalue epäkelvoksi, jolloin saadaan aikaiseksi 

                // paint-eventin signalointi ja tämän jälkeen Paint()-metodin kutsu. 

                Invalidate(); 

            }  

        } 
```
Lisää sovellukseen vielä toiminto, jonka avulla ukkoa saadaan “raahattua”, eli se piirretään uudelleen, kun hiirtä liikutetaan lomakkeella painike pohjassa. 

 
