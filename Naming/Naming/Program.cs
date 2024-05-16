// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");

int x = 5;
var i = 8;
var j = 12;
var ii = 26;
var jj = 36;

var d = 0; //Müşterinin sisteme kayıt olduğu andan itibaren geçen gün sayısı

//1. Anlamlı isimler kullanın
var daysSinceCustomerCreatedOnDb = 350;
var musterininKayitOlduguZamandanBuyanaGecenGunSayisi = 25;

bool banuAlkan = false;

//2. mümkün olduğunca kısaltma tercih etmeyin
var hp = 0;
var hpLaptopCount = 225;
//horse power
//Hp marka yazıcı
//hp bilgisayar
//hitPoint
//healthPoint 

//3. Değişken adı, veri tipiyle uyumlu olsun
int numberForStudents = 16;

bool hasCell = false;
bool isBigOne = true;
bool isCompleted = true;

//Kompleks tipler, değişken adında geçerse daha güzel olur.
DataTable productsDataTable = new DataTable();
Random randomNumberGenerator = new  Random();

//4. Karıştırılabileck kavramlar için kurallar belirleyin
var emailList = new List<string>();
var emails = new List<string>();

//Böyle şeyler yapıp astigmatları üzmeyin :(
//var o = 0;
//var l = 1;
//if (o == 1)
//{
//    o = l;
//}

string password = "Pa$$w0rd1";
bool isIncludeLetter = true;
bool isIncludeDigit = true;
bool isIncludeSymbol = true;

bool isSecurePassword = isIncludeLetter && isIncludeDigit && isIncludeSymbol;



if (isSecurePassword)
{

}

List<int[]> cellsOnABoard = new List<int[]>();

List<int[]> getFlaggedCells()
{
    var flaggedCells = new List<int[]>();
	foreach (var cell in cellsOnABoard)
	{
		if (cell[0] == CellTypes.Flagged)
		{
			flaggedCells.Add(cell);
		}
	}
	return flaggedCells;
}


public class CellTypes
{
	public const int Empty = 1;
	public const int Exploded = 2;
	public const int Tip = 3;
	public const int Flagged = 4;
}

