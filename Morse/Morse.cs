using System;

namespace Morse
{
	public class Morse
	{
		//file location
		private string _file;
		//
		private string _data;
		private string _character;

		//list of morse data
		private string[] _morse;

		private Random _random = new Random ();


		public Morse (string file)
		{
			this._file = file;
			ParseMorse ();
			GetRandomCharacter ();
			Console.Write (_character);
			//Console.Write (string.Join("\n", _morse));
		}

		private void ParseMorse ()
		{
			_morse = System.IO.File.ReadAllLines (@_file);
		}

		public void ParseMorse (string file)
		{
			_morse = System.IO.File.ReadAllLines (@file);
		}

		public void GetRandomCharacter ()
		{
			_character = _morse [_random.Next(0, 35)];
		}
	}
}

