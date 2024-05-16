// See https://aka.ms/new-console-template for more information
using Functions;

Console.WriteLine("Hello, World!");
/*
 * 1. Birim zamanda sadece bir iş yapmalı!
 * 2. Parametresi ihtiyaca yönelik ve olabildiğince az olmalı
 * 3. Gövde kodu, mümkün olduğunca az sayıda koddan oluşmalı.
 */

bool isEven(int number)
{
   return number % 2 == 0;
}

/*
 * 1. Rastgele kelimeler arasından bir kelime seç.
 * 2. Bu kelimenin her karakterini '*' işaretine dönüştür.
 * 3. Ekranda bu bulmacayı göster.
 * 4. Kullanıcıdan harf iste
 * 5. Harfin kelimede olup olmadığına bak
 * 6. Varsa o pozisyondaki * işaretleri harfe dönüşssün yoksa haktan bir düşsün.
 * 
 */
string getRandomWord(List<string> words)
{
    return "ayna";
}

string getPuzzledWord(string word)
{
    return "****";
}

void showPuzzledWord(string puzzled) => Console.WriteLine(puzzled);

string getLetterFromUser() => "a";

bool puzzleIncludesLetter(string word, string letter) => word.Contains(letter);

string replacePuzzleWithLetter(string word, string letter) => "a**a";



var selectedWord = getRandomWord(new List<string>());
var puzzled = getPuzzledWord(selectedWord);
showPuzzledWord(puzzled);
var letter = getLetterFromUser();
var isIncludeLetter = puzzleIncludesLetter(selectedWord, letter);
if (isIncludeLetter)
{
    puzzled = replacePuzzleWithLetter(puzzled, letter);
    showPuzzledWord(puzzled);
}

var filePath = $@"{Environment.CurrentDirectory}\..\..\..\abc.xlsx";
try
{
    ReportGenerator reportGenerator = new ReportGenerator(filePath);
}
catch (ArgumentNullException)
{

    Console.WriteLine("Excel dosyasını belirtiniz");
}
catch (FileNotFoundException)
{
    Console.WriteLine("Excel dosyası bulunamadı");
}
catch (InvalidOperationException)
{
    Console.WriteLine("Validasyon hatalı");
}

