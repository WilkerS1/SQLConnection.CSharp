﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DS.Projeto.View {
	public partial class frmConsulta : Form {
		public frmConsulta(object DataSource) {
			InitializeComponent();
			this.dtg.DataSource = DataSource;
			this.Show();
		}

		private void selecionar(object sender, DataGridViewCellEventArgs e) {

		}

		private void fechar(object sender, FormClosingEventArgs e) { frmMain.windowConsulta = null; }
	}
}
