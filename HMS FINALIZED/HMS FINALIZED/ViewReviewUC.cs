﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_FINALIZED
{
    public partial class ViewReviewUC : UserControl
    {
        public ViewReviewUC()
        {
            InitializeComponent();
        }

        public void ShowReviewDataGridView(DataTable ReviewDataTable)
        {
            ReviewDataGridView.DataSource = ReviewDataTable;
            ReviewDataGridView.Refresh();
        }
    }
}
