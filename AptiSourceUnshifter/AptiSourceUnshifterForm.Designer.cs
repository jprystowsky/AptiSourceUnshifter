namespace OSCPA.AptiSourceUnshifter {
	partial class AptiSourceUnshifterForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnBoom = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBoom
			// 
			this.btnBoom.Location = new System.Drawing.Point(12, 12);
			this.btnBoom.Name = "btnBoom";
			this.btnBoom.Size = new System.Drawing.Size(139, 23);
			this.btnBoom.TabIndex = 0;
			this.btnBoom.Text = "Lock and Load";
			this.btnBoom.UseVisualStyleBackColor = true;
			// 
			// AptiSourceUnshifterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(164, 48);
			this.Controls.Add(this.btnBoom);
			this.Name = "AptiSourceUnshifterForm";
			this.Text = "AptiSourceUnshifter";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnBoom;
	}
}

