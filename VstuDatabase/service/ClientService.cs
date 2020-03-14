using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VstuDatabase.service
{
    class ClientService
    {

        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public ClientService()
        {
        }

        public void DisplayClientData(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from client", connection);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            connection.Close();
        }

        public void DeleteClient(string clientId, DataGridView dataGrid)
        {
            if (clientId != "")
            {
                cmd = new SqlCommand("delete client where client_id = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", int.Parse(clientId));
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Клиент удален");
                DisplayClientData(dataGrid);
            }
            else
            {
                MessageBox.Show("Не выбран клиент");
            }
        }

        public void AddClient(string name, string lastName, string dateOfBirth, string phone, string sex, DataGridView dataGrid)
        {
            if (name != "" && lastName != "" && dateOfBirth != "" && phone != "" && sex != "")
            {
                cmd = new SqlCommand("insert into client (first_name, last_name, date_of_birht, phone, sex) values (@name, @lastName, @date, @phone, @sex)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@date", dateOfBirth);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Клиент добавлен");
                DisplayClientData(dataGrid);
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }

        public void ChangeClient(string name, string lastName, string dateOfBirth, string phone, string sex, string id, DataGridView dataGrid)
        {
            if (name != "" && lastName != "" && dateOfBirth != "" && phone != "" && sex != "")
            {
                cmd = new SqlCommand("update client set first_name=@name, last_name=@lastName, date_of_birht=@date, phone=@phone, sex=@sex where @id=client_id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", int.Parse(id));
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@date", dateOfBirth);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Клиент обновлен");
                DisplayClientData(dataGrid);
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }


    }
}
