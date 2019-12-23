using System;
public class Suduko{
	public static void Main(){
	
		Console.Clear();
		Console.WriteLine("Ali Ghaffari and Ahmer Ali's Code");
		Console.WriteLine();
		Console.WriteLine("1 - PLAY");
		Console.WriteLine("2 - Settings");
		char userInput = Convert.ToChar(Console.ReadLine());

		switch(userInput){
			
			case '1':
			Play();
			break;

			case '2':
			Settings();
			break;			
				

			default:
			Main();
			break;
		}
	}
		public static void Settings(){
			Console.Clear();
			Console.WriteLine("Code");
			Console.WriteLine();
			Console.WriteLine("Settings");
			Console.WriteLine("1 - Change Background Color");
			Console.WriteLine("2 - Change Text Color");
			Console.WriteLine("3 - Back");
			char setting =	Convert.ToChar(Console.ReadLine());
			switch(setting){
				
				case '1':
				Console.Clear();
				Console.WriteLine("Select Background Color");
				Console.WriteLine();
				Console.WriteLine("1 - White");
				Console.WriteLine("2 - Blue");
				Console.WriteLine("3 - Green");
				Console.WriteLine("4 - Red");
				Console.WriteLine("5 - Gray");
				Console.WriteLine("6 - Yellow");
				Console.WriteLine("7 - Black");
				char backgroundColor = Convert.ToChar(Console.ReadLine());
				switch(backgroundColor){
					case '1':
					Console.BackgroundColor = ConsoleColor.White;
					Console.Clear();
					Settings();
					break;
					case '2':
					Console.BackgroundColor = ConsoleColor.Blue;
					Console.Clear();
					Settings();
					break;
					case '3':
					Console.BackgroundColor = ConsoleColor.Green;
					Console.Clear();
					Settings();
					break;
					case '4':
					Console.BackgroundColor = ConsoleColor.Red;
					Console.Clear();
					Settings();
					break;
					case '5':
					Console.BackgroundColor = ConsoleColor.Gray;
					Console.Clear();
					Settings();
					break;
					case '6':
					Console.BackgroundColor = ConsoleColor.Yellow;
					Console.Clear();
					Settings();
					break;
					case '7':
					Console.BackgroundColor = ConsoleColor.Black;
					Console.Clear();
					Settings();
					break;
					default:
					Settings();
					break;
				}
				
				
				break;

				case '2':
				Console.Clear();
				Console.WriteLine("Select Text Color");
				Console.WriteLine();
				Console.WriteLine("1 - White");
				Console.WriteLine("2 - Blue");
				Console.WriteLine("3 - Green");
				Console.WriteLine("4 - Red");
				Console.WriteLine("5 - Gray");
				Console.WriteLine("6 - Yellow");
				Console.WriteLine("7 - Black");
				char textColor = Convert.ToChar(Console.ReadLine());
				switch(textColor){
					case '1':
					Console.ForegroundColor = ConsoleColor.White;
					Console.Clear();
					Settings();
					break;
					case '2':
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Clear();
					Settings();
					break;
					case '3':
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Clear();
					Settings();
					break;
					case '4':
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Clear();
					Settings();
					break;
					case '5':
					Console.ForegroundColor = ConsoleColor.Gray;
					Console.Clear();
					Settings();
					break;
					case '6':
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Clear();
					Settings();
					break;
					case '7':
					Console.ForegroundColor = ConsoleColor.Black;
					Console.Clear();
					Settings();
					break;
					default:
					Settings();
					break;
				}
				break;

				case '3':
				Main();
				break;
				default:
				Settings();
				break;
			}
		}
		public static void Play(){
			Console.Clear();
			Console.WriteLine("Select Difficulty");
			Console.WriteLine();
			Console.WriteLine("1 - Easy");
			Console.WriteLine("2 - Medium");
			Console.WriteLine("3 - Hard");
			char userInput = Convert.ToChar(Console.ReadLine());

			if(userInput=='1'){

				Easy();

			}
			else if(userInput=='2'){
				Medium();
			}
			else{
				Console.WriteLine("you entered invalid input");
			}


	Console.Clear();
	int user;
	
	int result=0;
	Console.WriteLine("\t*************************");
	Console.WriteLine("KON	BANEGA  COROEPATII");
	Console.WriteLine("*************************");
	Console.WriteLine();


Console.WriteLine("Select Your choice ");
Console.WriteLine();
Console.WriteLine("(Which is Capital of pakistan?)");
Console.WriteLine();
Console.WriteLine("(a)=Karachi");
Console.WriteLine("(b)=Multan");
Console.WriteLine("(c)=Lahore");
Console.WriteLine("(d)=Islamabad");
Console.WriteLine();
user=Convert.ToChar(Console.ReadLine());
if(user=='d')
{
	Console.Write("Your answer is correct");

	result=result+1;
} 
else{
	Console.WriteLine("wrong Answer!");
	Console.WriteLine("The correct answer is= Islamabad");

	result=result+0;
}

Console.WriteLine("Select Your choice ");
Console.WriteLine();
Console.WriteLine("(Which is largest city of pakistan.)");
Console.WriteLine();
Console.WriteLine("(a)=Karachi");
Console.WriteLine("(b)=Faisalabad");
Console.WriteLine("(c)=Rawalpindi");
Console.WriteLine("(d)=Islamabad");
Console.WriteLine();
user=Convert.ToChar(Console.ReadLine());
if(user=='a')
{
Console.Write("your answer is correct");
	result=result+1;
} 
else{
	Console.WriteLine("your answer is wrong!");
	Console.WriteLine("The Correct answer is = Karachi");

	result=result+0;
}
Console.Clear();

Console.Clear();
Console.WriteLine("Select Your choice ");
Console.WriteLine();
Console.WriteLine("(Who is the prime minister of pakistan.)");
Console.WriteLine();
Console.WriteLine("(a)=Zaradari saeen");
Console.WriteLine("(b)=Altaf Bhai");
Console.WriteLine("(c)=Nawaz Shareef");
Console.WriteLine("(d)=Imran Khan");
Console.WriteLine();
user=Convert.ToChar(Console.ReadLine());
if(user=='c')
{
	Console.Write("your answer is correct");

	result=result+1;
} 
else{
	Console.WriteLine("your answr is wrong!");
	Console.WriteLine("The correct answer is = Nawaz Sharif");

	result=result+0;
}
Console.Clear();

Console.Clear();
Console.WriteLine("Select Your choice");
Console.WriteLine();
Console.WriteLine("Who is the father name of Holy Prophet (P.B.U.H)? ");
Console.WriteLine("(a).Abu Talib");
Console.WriteLine("(b).Qasim");
Console.WriteLine("(c).Abdullah");
Console.WriteLine("(d).Suleman");
Console.WriteLine();
user=Convert.ToChar(Console.ReadLine());
if(user=='c'){
	Console.Write("your answr is correct");
	result=result+1;
}
else{
	Console.WriteLine("your answer is wrong!");
	Console.WriteLine("The correct answer is = Abdullah");
	result=result+0;
}
Console.Clear();
Console.WriteLine("Select your choice");
Console.WriteLine();
Console.WriteLine("What name was given to the operation by the Indian Army to  rescue standed travellers from Uttarakhand during 2013 floods?");
Console.WriteLine("(a). Operation Sukun");
Console.WriteLine("(b). Operation Asha");
Console.WriteLine("(c). Operation Flood");
Console.WriteLine("(d). Operation Surya Hope");
user=Convert.ToChar(Console.ReadLine());
if(user='d'){
	result=result+1;
	Console.Write("your answer is correct");
}
else{
	result=result+0;
	Console.WriteLine("Your Answr is wrong!");
	Console.WriteLine("The correct answr is = Operation Surya Hope");
}
Console.Clear();
Console.WriteLine("Select Your choice");
Console.WriteLine();
Console.WriteLine("What is the Meaning of Pakistan?");
Console.WriteLine("(a).Muslim Land");
Console.WriteLine("(b).Land of five rivers");
Console.WriteLine("(c).Desert");
Console.WriteLine("(d).Holy Land");
user=Convert.ToChar(Console.ReadLine());
if(user=='d'){
	result=result+1;
}
else{
	result=result+0;
}
Console.Clear();
Console.WriteLine("Who is the first Governal Genral of Pakistan?");
Console.WriteLine();
Console.WriteLine("(a).Muhammad Ali Jinnah");
Console.WriteLine("(b).Liaqat Ali Khan");
Console.WriteLine("(c).Ayub Khan");
Console.WriteLine("(d).Iskandar Mirza");
user=Convert.ToChar(Console.ReadLine());
if(user=='b'){
	result=result+1;
}
else{
	result=result+0;
}
Console.Clear();
Console.WriteLine("When did Pakistan win Olympic gold medal in Hockey for the first time?");
Console.WriteLine();
Console.WriteLine("(a).1948");
Console.WriteLine("(b).1952");
Console.WriteLine("(c).1960");
Console.WriteLine("(d).1964");
user=Convert.ToChar(Console.ReadLine());
if(user=='d'){
	result=result+1;
}
else{
	result=result+0;
}
Console.Clear();
Console.WriteLine("The faces of the presidents of which country are carved on Mount Rushmore?");
Console.WriteLine();
Console.WriteLine("(a). U.S.A");
Console.WriteLine("(b).France");
Console.WriteLine("(c).Italy");
Console.WriteLine("(d).Spain");
user=Convert.ToChar(Console.ReadLine());
if(user=='a'){
	Console.Write("your answer is correct!");
	result=result+1;
}
else{
	Console.WriteLine("your answer is wrong!");
	Console.WriteLine("The correct answer is = U.S.A");
	result=result+0;
}
Console.Clear();
Console.WriteLine("What unique record did Sachin Tendulkar achieve in March 2012?");
Console.WriteLine();
Console.WriteLine("(a). 100 international series");
Console.WriteLine("(b).Double century in T20");
Console.WriteLine("(c).6 sixex in an over of Tests");
Console.WriteLine("(d).400 runs in a test innings");
user=Convert.ToChar(Console.ReadLine());
if(user=='a'){
	Console.Write("your answer is correct!");
	result=result+1;
}
else{
	Console.WriteLine("your answer is wrong!");
	Console.WriteLine("The correct answer is = 100 international series");
	result=result+0;
}
Console.Clear();
Console.WriteLine("A byte corresponds to a cluster of how many bits?");
Console.WriteLine();
Console.WriteLine("(a). 12 bits");
Console.WriteLine("(b). 25 bits");
Console.WriteLine("(c). 85 bits");
Console.WriteLine("(d). 8  bits");
user=Convert.ToChar(Console.ReadLine());
if(user=='d'){
	Console.WriteLi("your answer is correct!");
	result=result+1;
}
else{
	Console.WriteLine("your answer is wrong!");
	Console.WriteLine("The correct answer is = 8 bits");
	result=result+0;
}

Console.WriteLine("CPU is also referred to as?");
Console.WriteLine();
Console.WriteLine("(a). Microprocessor");
Console.WriteLine("(b). MicroChip");
Console.WriteLine("(c). Decoder");
Console.WriteLine("(d). Coder");
user=Convert.ToChar(Console.ReadLine());
if(user=='b'){
	Console.WriteLine("your answer is correct!");
	result=result+1;
}
else{
	Console.WriteLine("your answer is wrong!");
	Console.WriteLine("The correct answer is = MicroChip");
	result=result+0;
}

Console.WriteLine("The computer is a device and all other tools associated with it, are known as?");
Console.WriteLine();
Console.WriteLine("(a). Software");
Console.WriteLine("(b). Hardware");
Console.WriteLine("(c). Firmware");
Console.WriteLine("(d). Manware");
user=Convert.ToChar(Console.ReadLine());
if(user=='b'){
	Console.WriteLine("your answer is correct!");
	result=result+1;
}
else{
	Console.WriteLine("your answer is wrong!");
	Console.WriteLine("The correct answer is = Hardware");
	result=result+0;
}
Console.WriteLine("Among the following which is the network?");
Console.WriteLine();
Console.WriteLine("(a). MAN");
Console.WriteLine("(b). LAN");
Console.WriteLine("(c). WAN");
Console.WriteLine("(d). All of these");
user=Convert.ToChar(Console.ReadLine());
if(user=='d'){
	Console.Write("your answer is correct!");
	result=result+1;
}
else{
	Console.WriteLine("your answer is wrong!");
	Console.WriteLine("The correct answer is = All of these");
	result=result+0;
}

Console.WriteLine("The full form of RAM is?");
Console.WriteLine();
Console.WriteLine("(a). Randomly Area Memoration");
Console.WriteLine("(b). Ristricted Area Memory");
Console.WriteLine("(c). Random Access Memory");
Console.WriteLine("(d). Royal Access Memory");
user=Convert.ToChar(Console.ReadLine());
if(user=='c'){
	Console.Write("your answer is correct!");
	result=result+1;
}
else{
	Console.WriteLine("your answer is wrong!");
	Console.WriteLine("The correct answer is = Random Access Memory");
	result=result+0;
}

Console.WriteLine("The full form of GB is?");
Console.WriteLine();
Console.WriteLine("(a). Gegra Byte");
Console.WriteLine("(b). Ground Bass");
Console.WriteLine("(c). Giga Boot");
Console.WriteLine("(d). Giga Byte");
user=Convert.ToChar(Console.ReadLine());
if(user=='d'){
	Console.Write("your answer is correct!");
	result=result+1;
}
else{
	Console.WriteLine("your answer is wrong!");
	Console.WriteLine("The correct answer is = Giga Byte");
	result=result+0;
}

Console.WriteLine("The full form of WWW is?");
Console.WriteLine();
Console.WriteLine("(a). World Wide Web");
Console.WriteLine("(b). World Website Web");
Console.WriteLine("(c). World Widely Web");
Console.WriteLine("(d). World Wing Web");
user=Convert.ToChar(Console.ReadLine());
if(user=='a'){
	Console.Write("your answer is correct!");
	result=result+1;
}
else{
	Console.WriteLine("your answer is wrong!");
	Console.WriteLine("The correct answer is = World Wide Web");
	result=result+0;
}


if (result>2)
{
	Console.Clear();
	Console.WriteLine("________________________________________________");
	Console.WriteLine("Congratulations You have   "+result+"   Points");
	Console.WriteLine("________________________________________________");	
}
else{

	Console.Clear();
	Console.WriteLine("______________________________________");
	Console.WriteLine("Ohhhh You have   "+result+"   Points");
	Console.WriteLine("______________________________________");	
}
}
}