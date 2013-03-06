using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OSCPA.AptiSourceUnshifter {
	public partial class AptiSourceUnshifterForm : Form {
		public AptiSourceUnshifterForm() {
			InitializeComponent();

			btnBoom.Click +=new EventHandler(btnBoom_Click);
		}

		void btnBoom_Click(object sender, EventArgs e) {
			var loc = new FolderBrowserDialog() {
				Description = "Select the Aptify C# source folder"
			};

			if (loc.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				string[] files = Directory.GetFiles(loc.SelectedPath, "*.cs", SearchOption.AllDirectories);

				UInt64 symbolMods, totalSymbolMods = 0;
				uint filesRead = 0;
				StringBuilder readFile;
				foreach (string file in files) {
					filesRead++;
					symbolMods = 0;
					readFile = this.ReadFile(file, ref symbolMods);

					if (symbolMods > 0) {
						totalSymbolMods += symbolMods;
						File.WriteAllText(file, readFile.ToString());
					}
				}

				if (MessageBox.Show(string.Format("Read {0} files and modified {1} symbols in them. Exit?", filesRead, totalSymbolMods), "Done Processing. Exit?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
					Application.Exit();
				}
			}
		}

		private StringBuilder ReadFile(string path, ref UInt64 symbolsModified) {
			StringBuilder returnValue = null;

			var fileStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
			if (fileStream.CanRead) {
				returnValue = new StringBuilder();

				var streamReader = new StreamReader(fileStream, Encoding.Unicode);

				string readString;
				while ((readString = streamReader.ReadLine()) != null) {
					returnValue.AppendLine(new String(readString.ToArray<char>().Unshift(ref symbolsModified)));
				}

				streamReader.Close();
				streamReader.Dispose();
				fileStream.Close();
				fileStream.Dispose();
			}
			
			return returnValue;
		}
	}
}
