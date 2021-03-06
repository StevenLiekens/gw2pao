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

namespace GW2PAO.Views.Events.EventTracker
{
    /// <summary>
    /// Interaction logic for WorldEventView.xaml
    /// </summary>
    public partial class WorldEventView : UserControl
    {
        public WorldEventView()
        {
            InitializeComponent();
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
            {
                ((GW2PAO.Modules.Events.ViewModels.EventViewModel)this.DataContext).CopyDataCommand.Execute(null);
            }
        }
    }
}
