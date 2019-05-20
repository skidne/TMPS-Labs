using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using Labs;
using UI.ViewModels;

namespace UI.Views
{
	/// <summary>
	/// Interaction logic for StormtrooperFighting.xaml
	/// </summary>
	public partial class StormtrooperFighting : Window
	{
		public ObservableCollection<string> Actions { get; set; }

		public StormtrooperFighting()
		{
			InitializeComponent();
			InitStormtroopers();
			Actions = new ObservableCollection<string>();
		}

		private void InitStormtroopers()
		{
			Stormtroopers.ItemsSource =
				((MainWindowViewModel) Application.Current.MainWindow.DataContext).Stormtroopers.Select(x =>
					x.Identifier);
		}

		private void MeleeAttack_OnClick(object sender, RoutedEventArgs e)
		{
			if (Stormtroopers.SelectedItem != null)
			{
				var st =
					((MainWindowViewModel) Application.Current.MainWindow.DataContext).Stormtroopers.FirstOrDefault(x =>
						x.Identifier == Stormtroopers.SelectedItem.ToString());
				Actions.Add(st.Fight(new Labs.StormtrooperFighting(new MeleeToRangeAdapter(new MeleeWeapon()))));
				ActionsListView.ItemsSource = Actions;
			}
		}

		private void RangeAttack_OnClick(object sender, RoutedEventArgs e)
		{
			if (Stormtroopers.SelectedItem != null)
			{
				var st =
					((MainWindowViewModel)Application.Current.MainWindow.DataContext).Stormtroopers.FirstOrDefault(x =>
						x.Identifier == Stormtroopers.SelectedItem.ToString());
				Actions.Add(st.Fight(new Labs.StormtrooperFighting(new RangeWeapon())));
				ActionsListView.ItemsSource = Actions;
			}
		}

		private void SpecialAttack_OnClick(object sender, RoutedEventArgs e)
		{
			if (Stormtroopers.SelectedItem != null)
			{
				var st =
					((MainWindowViewModel)Application.Current.MainWindow.DataContext).Stormtroopers.FirstOrDefault(x =>
						x.Identifier == Stormtroopers.SelectedItem.ToString());
				Actions.Add(st.Fight(new StormtrooperSpecialAttackDecorator(new Labs.StormtrooperFighting(new RangeWeapon()))));
				ActionsListView.ItemsSource = Actions;
			}
		}
	}
}
