namespace Nepali_Typing;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }


    public async void OnCopyClicked(object sender, EventArgs e)
    {
        await Clipboard.Default.SetTextAsync(NepaliBox.Text);
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        EditText.Text = "";
    }
    private void OnEditTextChange(object sender, TextChangedEventArgs e){
        UnicodeConvert(EditText.Text);
        }

    public void UnicodeConvert(String text)
    {
        text = text.Replace("a", "अ");
        text = text.Replace("A", "आ");
        text = text.Replace("अअ", "आ");
        text = text.Replace("i", "इ");
        text = text.Replace("I", "ई");
        text = text.Replace("इइ", "ई");
        text = text.Replace("u", "उ");
        text = text.Replace("U", "ऊ");
        text = text.Replace("उउ", "ऊ");
        text = text.Replace("e", "ए");
        text = text.Replace("E", "ऐ");
        text = text.Replace("अइ", "ऐ");
        text = text.Replace("o", "ओ");
        text = text.Replace("O", "ओ");
        text = text.Replace("अउ", "औ");


        text = text.Replace("k", "क्");
        text = text.Replace("K", "क्");
        text = text.Replace("क्अ", "क");
        text = text.Replace("q", "क्");
        text = text.Replace("Q", "क्");
        text = text.Replace("g", "ग्");
        text = text.Replace("G", "ग्");
        text = text.Replace("c", "च्");
        text = text.Replace("C", "च्");
        text = text.Replace("j", "ज्");
        text = text.Replace("J", "ज्");
        text = text.Replace("z", "ज्");
        text = text.Replace("Z", "ज्");
        text = text.Replace("T", "ट्");
        text = text.Replace("D", "ड्");
        text = text.Replace("N", "ण्");
        text = text.Replace("t", "त्");
        text = text.Replace("d", "द्");
        text = text.Replace("n", "न्");
        text = text.Replace("p", "प्");
        text = text.Replace("P", "प्");
        text = text.Replace("f", "फ्");
        text = text.Replace("F", "फ्");
        text = text.Replace("b", "ब्");
        text = text.Replace("B", "ब्");
        text = text.Replace("m", "म्");
        text = text.Replace("M", "म्");
        text = text.Replace("y", "य्");
        text = text.Replace("Y", "य्");
        text = text.Replace("r", "र्");
        text = text.Replace("R", "र्");
        text = text.Replace("l", "ल्");
        text = text.Replace("L", "ल्");
        text = text.Replace("v", "व्");
        text = text.Replace("V", "व्");
        text = text.Replace("w", "व्");
        text = text.Replace("W", "व्");
        text = text.Replace("s", "स्");
        text = text.Replace("S", "ष्");
        text = text.Replace("h", "ह्");
        text = text.Replace("H", "ह्");

        text = text.Replace("क्ह्", "ख्");
        text = text.Replace("ग्ह्", "घ्");
        text = text.Replace("न्ग्", "ङ्");
        text = text.Replace("च्ह्", "छ्");
        text = text.Replace("छ्ह", "छ्");
        text = text.Replace("छ््", "छ्");
        text = text.Replace("ज्ह्", "झ्");
        text = text.Replace("य्न", "ञ्");
        text = text.Replace("न्ज्", "ञ्");
        text = text.Replace("ञ््", "ञ्");
        text = text.Replace("ट्ह्", "ठ्");
        text = text.Replace("ड़्ह्", "ढ़्");
        text = text.Replace("ड्ह्", "ढ्");
        text = text.Replace("त्ह्", "थ्");
        text = text.Replace("द्ह्", "ध्");
        text = text.Replace("प्ह्", "फ्");
        text = text.Replace("ब्ह्", "भ्");
        text = text.Replace("स्ह्", "श्");
        text = text.Replace("ष्ह्", "श्");
        text = text.Replace("क्छ्य", "क्ष्");
        text = text.Replace("क्ष््", "क्ष्");
        text = text.Replace("ग्य", "ज्ञ्");
        text = text.Replace("ज्ञ््", "ज्ञ्");
        text = text.Replace("x", "क्स्");
        text = text.Replace("X", "क्स्");

        text = text.Replace("\u200bक", "क");
        text = text.Replace("\u200bख", "ख");
        text = text.Replace("\u200bग", "ग");
        text = text.Replace("\u200bघ", "घ");
        text = text.Replace("\u200bङ", "ङ");
        text = text.Replace("\u200bच", "च");
        text = text.Replace("\u200bछ", "छ");
        text = text.Replace("\u200bज", "ज");
        text = text.Replace("\u200bझ", "झ");
        text = text.Replace("\u200bञ", "ञ");
        text = text.Replace("\u200bट", "ट");
        text = text.Replace("\u200bठ", "ठ");
        text = text.Replace("\u200bड", "ड");
        text = text.Replace("\u200bढ", "ढ");
        text = text.Replace("\u200bण", "ण");
        text = text.Replace("\u200bत", "त");
        text = text.Replace("\u200bथ", "थ");
        text = text.Replace("\u200bद", "द");
        text = text.Replace("\u200bध", "ध");
        text = text.Replace("\u200bन", "न");
        text = text.Replace("\u200bप", "प");
        text = text.Replace("\u200bफ", "फ");
        text = text.Replace("\u200bब", "ब");
        text = text.Replace("\u200bभ", "भ");
        text = text.Replace("\u200bम", "म");
        text = text.Replace("\u200bय", "य");
        text = text.Replace("\u200bर", "र");
        text = text.Replace("\u200bल", "ल");
        text = text.Replace("\u200bव", "व");
        text = text.Replace("\u200bस", "स");
        text = text.Replace("\u200bष", "ष");
        text = text.Replace("\u200bश", "श");
        text = text.Replace("\u200bह", "ह");
        text = text.Replace("\u200bक्ष", "क्ष");
        text = text.Replace("\u200bत्र", "त्र");
        text = text.Replace("\u200bज्ञ", "ज्ञ");

        text = text.Replace("'", "ं");
        text = text.Replace("\"", "ँ");
        text = text.Replace("्ं", "ं");
        text = text.Replace("्ँ", "ँ");
        text = text.Replace("ंं", "ँ");
        text = text.Replace("+ओम्", "ॐ");
        text = text.Replace("ॐं", "ॐ");
        text = text.Replace("\u200b ", " ");
        text = text.Replace("\u200bं", "ं");
        text = text.Replace("\u200bः", "ः");
        text = text.Replace(":", "ः");
        text = text.Replace("्ः", "ः");

        text = text.Replace(".", "।");
        text = text.Replace("|", "।");
        text = text.Replace("्।", "।");
        text = text.Replace("\\", "।");
        text = text.Replace("।।", "॥");

        text = text.Replace("0", "०");
        text = text.Replace("1", "१");
        text = text.Replace("2", "२");
        text = text.Replace("3", "३");
        text = text.Replace("4", "४");
        text = text.Replace("5", "५");
        text = text.Replace("6", "६");
        text = text.Replace("7", "७");
        text = text.Replace("8", "८");
        text = text.Replace("9", "९");


        text = text.Replace("ह्ऐ", "है");
        text = text.Replace("ह्ऐ", "है");
        text = text.Replace("ङ्ह्", "हं");
        text = text.Replace("ङ्ह", "हं");

        text = text.Replace("+ल्", "ऌ");
        text = text.Replace("्ऋ", "ृ");
        text = text.Replace("्ॠ", "ॄ");
        text = text.Replace("्ऌ", "ॢ");
        text = text.Replace("्+र्", "ृ");
        text = text.Replace("+र्", "ऋ");
        text = text.Replace("ऋइ", "ॠ");
        text = text.Replace("ृइ", "ॄ");

        text = text.Replace("् ", " ");
        text = text.Replace("्अ", "\u200b");
        text = text.Replace("्आ", "ा");
        text = text.Replace("\u200bअ", "ा");
        text = text.Replace("्इ", "ि");
        text = text.Replace("्ई", "ी");
        text = text.Replace("िइ", "ी");
        text = text.Replace("ुउ", "ू");
        text = text.Replace("\u200bउ", "ौ");
        text = text.Replace("्उ", "ु");
        text = text.Replace("्ऊ", "ू");
        text = text.Replace("्ए", "े");
        text = text.Replace("्ऐ", "ै");
        text = text.Replace("\u200bइ", "ै");
        text = text.Replace("्ओ", "ो");
        text = text.Replace("्औ", "ौ");
        NepaliBox.Text = text;
    }
}

