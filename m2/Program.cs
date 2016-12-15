/*
For this assignment, you will create the pattern of a chess board that is 8 x 8.  Use X and O to represent the squares.

Create the appropriate nested looping structure to output the characters in an 8 x 8 grid on the screen using Console.Write() or Console.WriteLine() as appropriate.
Include a decision structure to ensure that alternate rows start with opposite characters as a real chess board alternates the colors among rows.

This is what your output should look like.

XOXOXOXO
OXOXOXOX
XOXOXOXO
OXOXOXOX
XOXOXOXO
OXOXOXOX
XOXOXOXO
OXOXOXOX

Grading Criteria:

Used a nested loop
Used a decision structure to flip row output
Output is correct per above image
*/

using System;

namespace M2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int size = 0;
			bool res = Int32.TryParse (args [0], out size);
			if (!res || size == 0)
				return;

			bool flipper = false;
			for(int i = 0; i < size; i++) {
				for (int j = 0; j < size; j++) {
					flipper = !flipper;
					if (flipper)
						Console.Write('X');
					else
						Console.Write('O');
				}
				Console.Write('\n');
				flipper = !flipper;
			}
		}
	}
}