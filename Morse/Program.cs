using System;
using System.Media;

namespace Morse
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Sound sineWave = new Sound ("Sound/dit.wav", "Sound/dah.wav");
			Morse morse = new Morse("InternationalMorse.txt", sineWave);

			while (true)
			{
				morse.RunAll ();
				System.Threading.Thread.Sleep (200);
			}

		}
	}
}
