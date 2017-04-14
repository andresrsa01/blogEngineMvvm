﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BlogEngine.ViewModel;

namespace BlogEngine.View
{
    /// <summary>
    /// Interaction logic for ListPublication.xaml
    /// </summary>
    public partial class ListPublication : Page
    {

        public ListPublicationViewModel Vm = new ListPublicationViewModel();

        public ListPublication()
        {
            InitializeComponent();
            DataContext = Vm;
        }
    }
}
