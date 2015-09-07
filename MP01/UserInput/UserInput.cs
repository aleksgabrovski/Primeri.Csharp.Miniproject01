using System;

namespace UserInput
{
	public class UInput
	{
		About.Me about = new About.Me ();
		Colors.ForCLI _c = new Colors.ForCLI ();
		Calculations.MainLibrary _calc = new Calculations.MainLibrary();

		public UInput ()
		{
		}

		public void sayHello()
		{
			_c.Default (); 	
			Console.WriteLine ("Dobre doshli\n" + about.shortName + "\n" + about.version + "\n");
		}

		public void getUsercommand()
		{
			string _command = "";

			do {

				//Vzimane na komanda
				_c.Prompt();	Console.Write("$ ");
				_c.Command(); 	_command = Console.ReadLine();
				//Proverka za nalichni komandi
				if (_command.Contains ("qma"))	_calc.F01.calc (_command);
			
				if (_command.Contains ("komanda2")) Console.WriteLine ("Startirana e komanda2\n");
				if (_command.Contains ("komanda3")) Console.WriteLine ("Startirana e komanda3\n");

			} while(_command != "izhod");

		}


		public void justTesting ()
		{
		Console.WriteLine ("Startirane na UserInput.UInput.justTesting()");
		}
	}
}

