﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PathIdentifyEquipDemo.Dialogs
{
    public partial class RetransDataForm : Form
    {
        public DateTime StartTime
        {
            get
            {
                return dtpStartTime.Value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return dtpEndTime.Value;
            }
        }

        public RetransDataForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}