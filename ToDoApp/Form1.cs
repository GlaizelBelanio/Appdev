using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{

    public partial class ToDoListWindow : Form
    {
  
        public ToDoListWindow()
        {
            InitializeComponent();
        }
        DataTable todolist = new DataTable(); // stores data of table
        bool isEditing = false;

        private void TitleText_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            // Create columns
            todolist.Columns.Add("Title");
            todolist.Columns.Add("Description");

            //point view to table
            ToDoListView.DataSource = todolist;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\glaiz\Desktop\wologin\ToDoApp\ToDoApp\Database1.mdf;Integrated Security=True");
            con.Open();

            string query = "SELECT title, task FROM [dbo].[todo]"; // Selecting titles and tasks from 'todo' table
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            // Populate todolist DataTable with data from the database
            while (reader.Read())
            {
                string title = reader["title"].ToString();
                string task = reader["task"].ToString();
                todolist.Rows.Add(title, task);
            }

            // Close the data reader
            reader.Close();

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            descriptionBox.Text = "";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            isEditing = true;

            // Get the title of the selected row
            string titleToEdit = todolist.Rows[ToDoListView.CurrentCell.RowIndex]["Title"].ToString();

            // Fill text fields with data from the selected row
            titleBox.Text = todolist.Rows[ToDoListView.CurrentCell.RowIndex]["Title"].ToString();
            descriptionBox.Text = todolist.Rows[ToDoListView.CurrentCell.RowIndex]["Description"].ToString();
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the title of the selected row
                string titleToDelete = todolist.Rows[ToDoListView.CurrentCell.RowIndex]["Title"].ToString();

                // Delete the selected record from the database
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\glaiz\Desktop\wologin\ToDoApp\ToDoApp\Database1.mdf;Integrated Security=True"))
                {
                    con.Open();
                    string deleteQuery = "DELETE FROM [dbo].[todo] WHERE title = @title";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, con);
                    deleteCommand.Parameters.AddWithValue("@title", titleToDelete);
                    deleteCommand.ExecuteNonQuery();
                }

                // Remove the selected row from the DataTable
                todolist.Rows.RemoveAt(ToDoListView.CurrentCell.RowIndex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\glaiz\Desktop\wologin\ToDoApp\ToDoApp\Database1.mdf;Integrated Security=True"))
            {
                con.Open();

                if (isEditing)
                {
                    // Update existing record
                    string updateQuery = "UPDATE [dbo].[todo] SET title = @title, task = @task WHERE title = @oldTitle";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                    updateCommand.Parameters.AddWithValue("@title", titleBox.Text);
                    updateCommand.Parameters.AddWithValue("@task", descriptionBox.Text);
                    updateCommand.Parameters.AddWithValue("@oldTitle", todolist.Rows[ToDoListView.CurrentCell.RowIndex]["Title"].ToString());
                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    // Insert new record
                    string insertQuery = "INSERT INTO [dbo].[todo] (title, task) VALUES (@title, @task)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, con);
                    insertCommand.Parameters.AddWithValue("@title", titleBox.Text);
                    insertCommand.Parameters.AddWithValue("@task", descriptionBox.Text);
                    insertCommand.ExecuteNonQuery();
                }
            }

            // Update DataTable or refresh from the database
            todolist.Rows.Clear(); // Clear existing rows
            ToDoListView.DataSource = null; // Detach from the DataSource
            ToDoListView.Rows.Clear(); // Clear DataGridView rows

            // Re-populate todolist DataTable with data from the database
            string selectQuery = "SELECT title, task FROM [dbo].[todo]";
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\glaiz\Desktop\wologin\ToDoApp\ToDoApp\Database1.mdf;Integrated Security=True"))
            {
                con.Open();
                SqlCommand selectCommand = new SqlCommand(selectQuery, con);
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    string title = reader["title"].ToString();
                    string task = reader["task"].ToString();
                    todolist.Rows.Add(title, task);
                }
                reader.Close();
            }

            // Re-attach DataTable as DataSource
            ToDoListView.DataSource = todolist;

            // Clear fields and reset editing flag
            titleBox.Text = "";
            descriptionBox.Text = "";
            isEditing = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Go Home
            this.Hide();
            HomeWindow f2 = new HomeWindow();
            f2.ShowDialog();
            this.Close();

        }

        private void Header_Click(object sender, EventArgs e)
        {

        }
    }
}
