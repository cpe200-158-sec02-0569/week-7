﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form , View
    {
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
        }

        public void Notify(Model m)
        {
            Update(((TwoZeroFourEightModel)m).GetScore());
        }

        private void Update(int s)
        {
            lblScore.Text = "" + s;
        }

        private void TwoZeroFourEightScoreView_Load(object sender, EventArgs e)
        {

        }
    }
}
