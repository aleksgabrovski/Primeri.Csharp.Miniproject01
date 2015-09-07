using System;

namespace Calculations
{
	public class Formula01
	{
		//Bilbioteki
		private Colors.ForCLI _c = new Colors.ForCLI ();
		public Formula01 ()//Formula za obiknovenna stroitelna qma
		{
		}
	//Parsvane
		public void calc (string _userInput)
		{
			try {
				string[] param = _userInput.Split (' ');

				if (param.Length > 1 && _userInput.Contains ( "-p" ))
				{
					//Pomosht za komandata

					help ();

				}

				if (param.Length > 1 && !_userInput.Contains ( "-p" ))
				{
					//Izchisleniq
					double _result = 0;

					if (runCalculations (param , out _result))
						{
						_c.Default();	Console.Write ("Obema na stroitelnata qma e: ");
						_c.Result();	Console.Write (_result.ToString("N2") );
						_c.Default();	Console.WriteLine(" m3\n");
					}else{
						_c.Default(); Console.WriteLine("Ima greshno vuvedeni parametri , Mojete da proverite parametura sas sintaksisa '-p'\n");
					}

				}


			}catch{
			}
		}
		//Izchislenie i izpisvane
		private bool runCalculations (string[] _param , out double _result)
		{
			try{
				double _a1 = 0 , _b1 = 0 , _a2 = 0 , _b2 = 0 , _h = 0;

				//_param[0] == <ime na komanda> 
				Double.TryParse(_param[1],out _a1);
				Double.TryParse(_param[2],out _b1);
				Double.TryParse(_param[3],out _a2);
				Double.TryParse(_param[4],out _b2);
				Double.TryParse(_param[5],out _h);

				Double F1 = _a1*_b1, F2 = _a2*_b2;
				_result =_h*(F1 + F2)/2;
			
				return true;
			}catch{
			}
			_result = 0;
			return false;

		}
		//Pomosht za komandata
		private void help ()
		{

			_c.Result ();
			Console.Write ("[qma]");
			_c.Default ();
			Console.WriteLine ("Komanda za presmqtane na stroitelna qma ");

			_c.Command ();
			Console.Write ("parametri: ");
			_c.Default ();
			Console.WriteLine ("a1 b1 a2 b2 h\n");

			_c.Command ();
			Console.Write ("a1 i b1");
			_c.Default ();
			Console.WriteLine (" - shirina i duljina na gornata strana na izkopa");

			_c.Command ();
			Console.Write ("a2 i b2");
			_c.Default ();
			Console.WriteLine (" - shirina i duljina na dolnata strana na izkopa");

			_c.Command ();
			Console.Write ("h ");
			_c.Default ();
			Console.WriteLine ("Visochina na izkopa\n");
		}
	}
}

