# 14_File

Tässä tehtävässä tutustutaan RichTextBox-komponenttiin ja tekstitiedoston käsittelyyn (Luonti, talletus ja luku) sekä windowsin valmiisiin standarteihin avaus/talletus dialogeihin. Valmiin editoriohjelman ikkuna näyttää kuvan 1 mukaiselta. 


![file01](https://github.com/Gradia-Ohjelmistokehitys-k2022/graafiset-kayttoliittymat-pohja/blob/main/14_File/kuvat/file01.png)

Kuva 1 Tekstiedotorin näkymä


a) Ota tehtävän pohjaksi perusprojekti, jossa on valmiina menu ja sen File-valikossa Exit-toiminto. 

                   

b) Lisää formiin RichTextBox-komponentti ja sido se formin työalueen reunoihin asettamalla Dock-ominaisuus arvoon Fill. 

  
c) Luo File-valikkoon kuvan 1-2 mukainen valintarakenne ja valinnoille tapahtumankäsittelijät. 

![file02](https://github.com/Gradia-Ohjelmistokehitys-k2022/graafiset-kayttoliittymat-pohja/blob/main/14_File/kuvat/file02.png)

Kuva 2 File-menu

d) Lisää ohjelman alkuun uusi nimiavaruus, jossa olevia luokkia tarvitaan tiedostojen käsittelyssä: 

```c#
using System.IO; 
```

e) Lisää pääformin luokan alkuun luokan sisällä käytettävä globaali muuttuja: 
```c#
    private String EditorFileName = "Untitled"; 
```

f) Lisää luokkaan apumetodi tekstin tulostamista varten formin otsikkopalkkiin. 

```c#
    private void SetFormTitleText() 

    { 

        // Tiedoston nimi formiin. 

        FileInfo fileinfo = new FileInfo(EditorFileName); 

        Text = fileinfo.Name + " - Editor";           

    } 
```
g) Kirjoita ohjelmakoodit uuden dokumentin luontia varten File-valikon New... -valinnan tapahtumankäsittelijään: 

```c#
    EditorFileName = "Untitled"; 

    DocumentRichTextBox.Clear(); 

    SetFormTitleText(); 

```

  

h) Lisää tiedoston lukemista ja kirjoittamista varten 2 apumetodia ReadFile() ja SaveFile(): 

  
```c#
ReadFile() 

            try 

            { 

                // Luodaan StreamReader objekti ja luetaan tiedosto. 

                using (StreamReader Reader = new StreamReader(EditorFileName)) 

                { 

                    // Luku 

                    DocumentRichTextBox.Clear(); 

                    DocumentRichTextBox.Text = Reader.ReadToEnd(); 

                } 

            } 

            catch (IOException ex) 

            { 

                MessageBox.Show("Error: " + ex.Message, "Open File", 

                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 

            } 

SaveFile() 

            try 

            { 

                // Luodaan SteramWriter objekti ja kirjoitetaan teksti tiedostoon. 

                using (StreamWriter StrWriter = new StreamWriter(EditorFileName)) 

                { 

                    // Kirjoitus 

                    StrWriter.Write(DocumentRichTextBox.Text); 

                } 

            } 

            catch (IOException ex) 

            { 

                MessageBox.Show("Error: " + ex.Message, "Save File", 

                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 

            } 
```
i) Kirjoita Open...-valinnan tapahtumankäsittelijään ohjelmakoodit avausdialogin aukaisemista ja dokumentin aukaisemista varten: 
```c#
            // Luodaan standardi avausdialogiobjekti ja alustetaan se. 

            OpenFileDialog OpenFileDlg = new OpenFileDialog(); 

            OpenFileDlg.Title = "Open"; 

            OpenFileDlg.ShowReadOnly = true; 

            OpenFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*"; 

  

            // Avataan windowsin standardi avausdialogi. 

            if (OpenFileDlg.ShowDialog() == DialogResult.OK) 

            { 

                // Talletetaan tiedoston nimi ja polku lukemista varten. 

                EditorFileName = OpenFileDlg.FileName; 

  

                // Luetaan tiedosotn sisältö ja tuodaan se näytölle. 

                ReadFile(); 

  

                SetFormTitleText(); 

            }         
```
j) Kirjoita ohjelmakoodit Save-valinnan tapahtumankäsittelijään: 

```c#
            if (EditorFileName == "Untitled") 

            { 

                MenuFileSaveAs_Click(sender, e); 

            } 

            else 

            { 

                SaveFile(); 

            }       
```
k) Kirjoita koodit Save As...-valinnan tapahtumankäsittelijään: 

```c#
            // Luodaan standardi talletusdialogiobjekti ja alustetaan se. 

            SaveFileDialog SaveFileDlg = new SaveFileDialog(); 

            SaveFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*"; 

  

            // Avataan windowsin standardi talletusdialogi. 

            if (SaveFileDlg.ShowDialog() == DialogResult.OK) 

            { 

                // Talletetaan tiedoston nimi ja polku talletusta varten. 

                EditorFileName = SaveFileDlg.FileName; 

  

                SaveFile(); 

  

                SetFormTitleText(); 

            }          
```
l) Testaa lopuksi editorin toimivuus. 

 
