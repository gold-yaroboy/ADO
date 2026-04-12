namespace Academy
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			statusStrip = new StatusStrip();
			tabControl = new TabControl();
			tabPageStudents = new TabPage();
			tabPageGroups = new TabPage();
			tabPageDirections = new TabPage();
			dgvDirections = new DataGridView();
			tabPageDisciplines = new TabPage();
			tabPageTechers = new TabPage();
			tabControl.SuspendLayout();
			tabPageDirections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDirections).BeginInit();
			SuspendLayout();
			// 
			// statusStrip
			// 
			statusStrip.Location = new Point(0, 428);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(800, 22);
			statusStrip.TabIndex = 0;
			statusStrip.Text = "statusStrip1";
			// 
			// tabControl
			// 
			tabControl.Controls.Add(tabPageStudents);
			tabControl.Controls.Add(tabPageGroups);
			tabControl.Controls.Add(tabPageDirections);
			tabControl.Controls.Add(tabPageDisciplines);
			tabControl.Controls.Add(tabPageTechers);
			tabControl.Dock = DockStyle.Fill;
			tabControl.Location = new Point(0, 0);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(800, 428);
			tabControl.TabIndex = 1;
			// 
			// tabPageStudents
			// 
			tabPageStudents.Location = new Point(4, 24);
			tabPageStudents.Name = "tabPageStudents";
			tabPageStudents.Padding = new Padding(3);
			tabPageStudents.Size = new Size(792, 400);
			tabPageStudents.TabIndex = 0;
			tabPageStudents.Text = "Students";
			tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// tabPageGroups
			// 
			tabPageGroups.Location = new Point(4, 24);
			tabPageGroups.Name = "tabPageGroups";
			tabPageGroups.Padding = new Padding(3);
			tabPageGroups.Size = new Size(792, 400);
			tabPageGroups.TabIndex = 1;
			tabPageGroups.Text = "Groups";
			tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// tabPageDirections
			// 
			tabPageDirections.Controls.Add(dgvDirections);
			tabPageDirections.Location = new Point(4, 24);
			tabPageDirections.Name = "tabPageDirections";
			tabPageDirections.Padding = new Padding(3);
			tabPageDirections.Size = new Size(792, 400);
			tabPageDirections.TabIndex = 2;
			tabPageDirections.Text = "Directions";
			tabPageDirections.UseVisualStyleBackColor = true;
			// 
			// dgvDirections
			// 
			dgvDirections.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvDirections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgvDirections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDirections.Location = new Point(3, 37);
			dgvDirections.Name = "dgvDirections";
			dgvDirections.Size = new Size(783, 357);
			dgvDirections.TabIndex = 0;
			// 
			// tabPageDisciplines
			// 
			tabPageDisciplines.Location = new Point(4, 24);
			tabPageDisciplines.Name = "tabPageDisciplines";
			tabPageDisciplines.Padding = new Padding(3);
			tabPageDisciplines.Size = new Size(792, 400);
			tabPageDisciplines.TabIndex = 3;
			tabPageDisciplines.Text = "Disciplines";
			tabPageDisciplines.UseVisualStyleBackColor = true;
			// 
			// tabPageTechers
			// 
			tabPageTechers.Location = new Point(4, 24);
			tabPageTechers.Name = "tabPageTechers";
			tabPageTechers.Padding = new Padding(3);
			tabPageTechers.Size = new Size(792, 400);
			tabPageTechers.TabIndex = 4;
			tabPageTechers.Text = "Teachers";
			tabPageTechers.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControl);
			Controls.Add(statusStrip);
			Name = "MainForm";
			Text = "Academy PV_521";
			tabControl.ResumeLayout(false);
			tabPageDirections.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDirections).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private StatusStrip statusStrip;
		private TabControl tabControl;
		private TabPage tabPageStudents;
		private TabPage tabPageGroups;
		private TabPage tabPageDirections;
		private TabPage tabPageDisciplines;
		private DataGridView dgvDirections;
		private TabPage tabPageTechers;
	}
}
