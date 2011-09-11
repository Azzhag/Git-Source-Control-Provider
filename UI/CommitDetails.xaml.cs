﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GitScc.UI
{
    /// <summary>
    /// Interaction logic for CommitDetails.xaml
    /// </summary>
    public partial class CommitDetails : UserControl
    {
        GitFileStatusTracker tracker;

        public CommitDetails()
        {
            InitializeComponent();
        }


        internal void Show(GitFileStatusTracker tracker, string p)
        {
            this.tracker = tracker;
            this.label1.Content = p;
        }

        internal void Show(GitFileStatusTracker tracker, string p, string p_2)
        {
            this.tracker = tracker;
            this.label1.Content = string.Format("{0} vs {1}", p, p_2);
        }
    }
}
