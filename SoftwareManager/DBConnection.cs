using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SoftwareManager
{
	static class DbConnection
	{
		//Измените эту строку для подключения к другой базе данных.
		public static string ConnectionString = "server=localhost;port=3306;userid=root;password=VoaV2004;database=softwaremanagerdb";

		private static MySqlConnection mySqlConnection = new MySqlConnection(ConnectionString);

		public static void Open()
		{
			mySqlConnection.Open();
		}

		public static void Close()
		{
			mySqlConnection.Close();
		}

		
		
		//создание команды
		public static MySqlCommand CreateCommand()
		{
			return mySqlConnection.CreateCommand();
		}
		//проверка на логин
		public static bool IsLoginUnique(string login)
		{
			MySqlCommand cmd = CreateCommand();
			cmd.CommandText = "SELECT * FROM `пользователи`";

			mySqlConnection.Open();
			using (MySqlDataReader reader = cmd.ExecuteReader())
			{
				while (reader.Read())
				{
					string dbLogin = reader.GetString("имя для входа");

					if (login == dbLogin)
					{
						mySqlConnection.Close();
						return false;
					}
				}
			}
			mySqlConnection.Close();
			return true;
		}

		

	}
}
