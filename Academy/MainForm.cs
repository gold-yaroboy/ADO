using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DBtools;

namespace Academy
{
	public partial class MainForm : Form
	{
		DBtools.Connector connector;
		public MainForm()
		{
			InitializeComponent();
			connector = new DBtools.Connector(ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString);
			dgvDirections.DataSource = connector.Select("*","Directions");
			//toolStripStatusLabel.Text = $"Количество направления обучения: {connector.Scalar("SELECT COUNT(*) FROM Directions")}";
			toolStripStatusLabel.Text = $"Количество направления обучения: {dgvDirections.Rows.Count-1}";
		}
	}
}
