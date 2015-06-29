using System;

namespace Morse
{
	public class Morse
	{
		//file location
		private string _file;

		//vars to hold morse chars
		private string[] _morse;
		private string _character;
		private string _code;
		private char _userCharacter;

		private Random _random = new Random ();


		public Morse (string file)
		{
			this._file = file;
			ParseMorse ();
		}

		public void RunTextOnly()
		{

			GetRandomCharacter ();
			GetCode ();
			Console.WriteLine (_code);
			GetUserCharacter ();
			CheckAnswer ();
		}

		public void RunSoundOnly()
		{

		}

		public void RunAll()
		{

		}

		//Parses morse from selected file
		public void ParseMorse (string file)
		{
			_morse = System.IO.File.ReadAllLines (@file);
		}

		//Parses morse from file specified on construct
		private void ParseMorse ()
		{
			_morse = System.IO.File.ReadAllLines (@_file);
		}

		//Selects random element of morse dictionary
		private void GetRandomCharacter ()
		{
			_character = _morse [_random.Next(0, 35)];
		}

		private void GetCode()
		{
			_code = "";
			for (int i = 2; i < _character.Length; i++) 
			{
				_code += _character [i];
			}
		}

		private void GetUserCharacter ()
		{
			_userCharacter = Console.ReadKey().KeyChar;
		}

		private bool CompareCharacter ()
		{
			if (_userCharacter == _character[0]) 
			{
				return true;
			} else 
			{
				return false;
			}
		}

		private void CheckAnswer ()
		{
			if (CompareCharacter ())
			{
				Console.WriteLine (" correct!");
			} else if (_userCharacter == ' ')
			{
				Console.WriteLine ("\n" + _character);
			} else
			{
				CheckAnswer ();
			}
		}


	}
}

