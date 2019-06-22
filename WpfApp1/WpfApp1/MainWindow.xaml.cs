using MySql.Data.MySqlClient;
using System;
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

namespace WpfApp1
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			// https://es.ourcodeworld.com/articulos/leer/70/como-conectarse-a-una-base-de-datos-mysql-con-c-en-winforms-y-xampp
			string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=prueba;";
			string query = "SELECT * FROM tabla";
			MySqlConnection databaseConnection = new MySqlConnection(connectionString);
			MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
			commandDatabase.CommandTimeout = 60;
			MySqlDataReader reader;
			try
			{
				databaseConnection.Open();
				reader = commandDatabase.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						string[] row = { reader.GetInt32(0).ToString(), reader.GetString(1) };
						MessageBox.Show(row[1]);
					}
				}
				else
				{
					Console.WriteLine("No se encontraron datos.");
				}
				databaseConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
