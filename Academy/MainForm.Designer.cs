namespace Academy
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			statusStrip = new StatusStrip();
			toolStripStatusLabel = new ToolStripStatusLabel();
			tabControl = new TabControl();
			tabPageStudents = new TabPage();
			buttonAddStudent = new Button();
			cbStudentsDirection = new ComboBox();
			cbStudentsGroup = new ComboBox();
			dgvStudents = new DataGridView();
			tabPageGroups = new TabPage();
			cbGroupsDirection = new ComboBox();
			dgvGroups = new DataGridView();
			tabPageDirections = new TabPage();
			dgvDirections = new DataGridView();
			tabPageDisciplines = new TabPage();
			dgvDisciplines = new DataGridView();
			tabPageTeachers = new TabPage();
			dgvTeachers = new DataGridView();
			statusStrip.SuspendLayout();
			tabControl.SuspendLayout();
			tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
			tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvGroups).BeginInit();
			tabPageDirections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDirections).BeginInit();
			tabPageDisciplines.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDisciplines).BeginInit();
			tabPageTeachers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
			SuspendLayout();
			// 
			// statusStrip
			// 
			statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
			statusStrip.Location = new Point(0, 448);
			statusStrip.Name = "statusStrip";
			statusStrip.Padding = new Padding(1, 0, 16, 0);
			statusStrip.Size = new Size(898, 22);
			statusStrip.TabIndex = 0;
			statusStrip.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			toolStripStatusLabel.Name = "toolStripStatusLabel";
			toolStripStatusLabel.Size = new Size(118, 17);
			toolStripStatusLabel.Text = "toolStripStatusLabel1";
			// 
			// tabControl
			// 
			tabControl.Controls.Add(tabPageStudents);
			tabControl.Controls.Add(tabPageGroups);
			tabControl.Controls.Add(tabPageDirections);
			tabControl.Controls.Add(tabPageDisciplines);
			tabControl.Controls.Add(tabPageTeachers);
			tabControl.Dock = DockStyle.Fill;
			tabControl.Location = new Point(0, 0);
			tabControl.Margin = new Padding(4, 3, 4, 3);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(898, 448);
			tabControl.TabIndex = 1;
			tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
			// 
			// tabPageStudents
			// 
			tabPageStudents.Controls.Add(buttonAddStudent);
			tabPageStudents.Controls.Add(cbStudentsDirection);
			tabPageStudents.Controls.Add(cbStudentsGroup);
			tabPageStudents.Controls.Add(dgvStudents);
			tabPageStudents.Location = new Point(4, 24);
			tabPageStudents.Margin = new Padding(4, 3, 4, 3);
			tabPageStudents.Name = "tabPageStudents";
			tabPageStudents.Padding = new Padding(4, 3, 4, 3);
			tabPageStudents.Size = new Size(890, 420);
			tabPageStudents.TabIndex = 0;
			tabPageStudents.Text = "Students";
			tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// buttonAddStudent
			// 
			buttonAddStudent.Location = new Point(794, 3);
			buttonAddStudent.Margin = new Padding(4, 3, 4, 3);
			buttonAddStudent.Name = "buttonAddStudent";
			buttonAddStudent.Size = new Size(88, 27);
			buttonAddStudent.TabIndex = 4;
			buttonAddStudent.Text = "Добавить";
			buttonAddStudent.UseVisualStyleBackColor = true;
			buttonAddStudent.Click += buttonAddStudent_Click;
			// 
			// cbStudentsDirection
			// 
			cbStudentsDirection.DropDownStyle = ComboBoxStyle.DropDownList;
			cbStudentsDirection.FormattingEnabled = true;
			cbStudentsDirection.Location = new Point(318, 3);
			cbStudentsDirection.Margin = new Padding(4, 3, 4, 3);
			cbStudentsDirection.Name = "cbStudentsDirection";
			cbStudentsDirection.Size = new Size(340, 23);
			cbStudentsDirection.TabIndex = 3;
			cbStudentsDirection.SelectedIndexChanged += cbStudentsDirection_SelectedIndexChanged;
			// 
			// cbStudentsGroup
			// 
			cbStudentsGroup.DropDownStyle = ComboBoxStyle.DropDownList;
			cbStudentsGroup.FormattingEnabled = true;
			cbStudentsGroup.Location = new Point(75, 3);
			cbStudentsGroup.Margin = new Padding(4, 3, 4, 3);
			cbStudentsGroup.Name = "cbStudentsGroup";
			cbStudentsGroup.Size = new Size(140, 23);
			cbStudentsGroup.TabIndex = 2;
			// 
			// dgvStudents
			// 
			dgvStudents.AllowUserToAddRows = false;
			dgvStudents.AllowUserToDeleteRows = false;
			dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvStudents.Location = new Point(7, 35);
			dgvStudents.Margin = new Padding(4, 3, 4, 3);
			dgvStudents.MultiSelect = false;
			dgvStudents.Name = "dgvStudents";
			dgvStudents.ReadOnly = true;
			dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvStudents.Size = new Size(875, 377);
			dgvStudents.TabIndex = 1;
			dgvStudents.CellMouseDoubleClick += dgvStudents_CellMouseDoubleClick;
			// 
			// tabPageGroups
			// 
			tabPageGroups.Controls.Add(cbGroupsDirection);
			tabPageGroups.Controls.Add(dgvGroups);
			tabPageGroups.Location = new Point(4, 24);
			tabPageGroups.Margin = new Padding(4, 3, 4, 3);
			tabPageGroups.Name = "tabPageGroups";
			tabPageGroups.Padding = new Padding(4, 3, 4, 3);
			tabPageGroups.Size = new Size(890, 420);
			tabPageGroups.TabIndex = 1;
			tabPageGroups.Text = "Groups";
			tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// cbGroupsDirection
			// 
			cbGroupsDirection.DropDownStyle = ComboBoxStyle.DropDownList;
			cbGroupsDirection.FormattingEnabled = true;
			cbGroupsDirection.Location = new Point(166, 7);
			cbGroupsDirection.Margin = new Padding(4, 3, 4, 3);
			cbGroupsDirection.Name = "cbGroupsDirection";
			cbGroupsDirection.Size = new Size(373, 23);
			cbGroupsDirection.TabIndex = 2;
			cbGroupsDirection.SelectedIndexChanged += cbGroupsDirection_SelectedIndexChanged;
			// 
			// dgvGroups
			// 
			dgvGroups.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgvGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvGroups.Location = new Point(5, 38);
			dgvGroups.Margin = new Padding(4, 3, 4, 3);
			dgvGroups.Name = "dgvGroups";
			dgvGroups.Size = new Size(875, 377);
			dgvGroups.TabIndex = 1;
			// 
			// tabPageDirections
			// 
			tabPageDirections.Controls.Add(dgvDirections);
			tabPageDirections.Location = new Point(4, 24);
			tabPageDirections.Margin = new Padding(4, 3, 4, 3);
			tabPageDirections.Name = "tabPageDirections";
			tabPageDirections.Padding = new Padding(4, 3, 4, 3);
			tabPageDirections.Size = new Size(890, 420);
			tabPageDirections.TabIndex = 2;
			tabPageDirections.Text = "Directions";
			tabPageDirections.UseVisualStyleBackColor = true;
			// 
			// dgvDirections
			// 
			dgvDirections.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvDirections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgvDirections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDirections.Location = new Point(7, 35);
			dgvDirections.Margin = new Padding(4, 3, 4, 3);
			dgvDirections.Name = "dgvDirections";
			dgvDirections.Size = new Size(875, 377);
			dgvDirections.TabIndex = 0;
			// 
			// tabPageDisciplines
			// 
			tabPageDisciplines.Controls.Add(dgvDisciplines);
			tabPageDisciplines.Location = new Point(4, 24);
			tabPageDisciplines.Margin = new Padding(4, 3, 4, 3);
			tabPageDisciplines.Name = "tabPageDisciplines";
			tabPageDisciplines.Padding = new Padding(4, 3, 4, 3);
			tabPageDisciplines.Size = new Size(890, 420);
			tabPageDisciplines.TabIndex = 3;
			tabPageDisciplines.Text = "Disciplines";
			tabPageDisciplines.UseVisualStyleBackColor = true;
			// 
			// dgvDisciplines
			// 
			dgvDisciplines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvDisciplines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgvDisciplines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDisciplines.Location = new Point(7, 35);
			dgvDisciplines.Margin = new Padding(4, 3, 4, 3);
			dgvDisciplines.Name = "dgvDisciplines";
			dgvDisciplines.Size = new Size(875, 377);
			dgvDisciplines.TabIndex = 1;
			// 
			// tabPageTeachers
			// 
			tabPageTeachers.Controls.Add(dgvTeachers);
			tabPageTeachers.Location = new Point(4, 24);
			tabPageTeachers.Margin = new Padding(4, 3, 4, 3);
			tabPageTeachers.Name = "tabPageTeachers";
			tabPageTeachers.Padding = new Padding(4, 3, 4, 3);
			tabPageTeachers.Size = new Size(890, 420);
			tabPageTeachers.TabIndex = 4;
			tabPageTeachers.Text = "Teachers";
			tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// dgvTeachers
			// 
			dgvTeachers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvTeachers.Location = new Point(7, 35);
			dgvTeachers.Margin = new Padding(4, 3, 4, 3);
			dgvTeachers.Name = "dgvTeachers";
			dgvTeachers.Size = new Size(875, 377);
			dgvTeachers.TabIndex = 1;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(898, 470);
			Controls.Add(tabControl);
			Controls.Add(statusStrip);
			Margin = new Padding(4, 3, 4, 3);
			Name = "MainForm";
			Text = "Academy PV_521";
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			tabControl.ResumeLayout(false);
			tabPageStudents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
			tabPageGroups.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvGroups).EndInit();
			tabPageDirections.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDirections).EndInit();
			tabPageDisciplines.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDisciplines).EndInit();
			tabPageTeachers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageDirections;
		private System.Windows.Forms.DataGridView dgvDirections;
		private System.Windows.Forms.TabPage tabPageDisciplines;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.DataGridView dgvGroups;
		private System.Windows.Forms.DataGridView dgvDisciplines;
		private System.Windows.Forms.DataGridView dgvTeachers;
		private System.Windows.Forms.ComboBox cbGroupsDirection;
		private System.Windows.Forms.ComboBox cbStudentsDirection;
		private System.Windows.Forms.ComboBox cbStudentsGroup;
		private System.Windows.Forms.Button buttonAddStudent;
	}
}