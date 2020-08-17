using System
using System.Windows.Forms

class Talker {
	public static int Gibberish(string Words, int times)
	//Gibberish's return value is an integer. The total length of the message it displayed.
	{
		string FinalString = "";
		for (int count = 0; count < times; count++)
		{
			FinalString = FinalString + Words + "\n";
		}
		MessageBox.Show(finalString);
		return FinalString.Length;
	}
}