using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSCPA.AptiSourceUnshifter {
	static class CharExtensions {
		private static int _offset = 5225;

		public static char[] Unshift(this char[] input, ref UInt64 modSymbs) {
			for (int i = 0; i < input.Length; i++) {
				if ((int)input[i] >= _offset) {
					input[i] = (char)((int)input[i] - _offset);
					modSymbs++;
				}
			}

			return input;
		}
	}
}
