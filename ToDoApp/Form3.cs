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
    public partial class NotesWindow : Form
    {
        private string username;

        // Constructor accepting username parameter
        public NotesWindow(string username)
        {
            InitializeComponent();
            this.username = username; // Store the passed username in a member variable
        }


        // Properties to store username and password
        public string Username { get; set; }
        public string Password { get; set; }

        
        public NotesWindow()
        {
            InitializeComponent();
        }

        DataTable notes = new DataTable();
        bool editing = false;

        private void NotesWindow_Load(object sender, EventArgs e)
        {
            // Create columns
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            // Point view to table
            previousnotes.DataSource = notes;

            // Establish connection to the database
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\glaiz\Desktop\wologin\ToDoApp\ToDoApp\Database1.mdf;Integrated Security=True"))
            {
                con.Open();

                // SQL query to select data from the 'notes' table
                string query = "SELECT title, note FROM [dbo].[notes]";

                // Execute the query
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                // Populate the 'notes' DataTable with data from the database
                while (reader.Read())
                {
                    string title = reader["title"].ToString();
                    string note = reader["note"].ToString();
                    notes.Rows.Add(title, note);
                }

                // Close the data reader
                reader.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            titlebox.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            notebox.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[1].ToString();

            editing = true;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            titlebox.Text = "";
            notebox.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string title = titlebox.Text;
            string note = notebox.Text;

            // Establish connection to the database
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\glaiz\Desktop\wologin\ToDoApp\ToDoApp\Database1.mdf;Integrated Security=True"))
            {
                con.Open();

                if (editing)
                {
                    // Update existing record
                    string updateQuery = "UPDATE [dbo].[notes] SET title = @title, note = @note WHERE title = @oldTitle";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                    updateCommand.Parameters.AddWithValue("@title", title);
                    updateCommand.Parameters.AddWithValue("@note", note);
                    updateCommand.Parameters.AddWithValue("@oldTitle", notes.Rows[previousnotes.CurrentCell.RowIndex]["Title"].ToString());
                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    // Insert new record
                    string insertQuery = "INSERT INTO [dbo].[notes] (title, note) VALUES (@title, @note)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, con);
                    insertCommand.Parameters.AddWithValue("@title", title);
                    insertCommand.Parameters.AddWithValue("@note", note);
                    insertCommand.ExecuteNonQuery();

                    // Add the new record to the DataTable
                    notes.Rows.Add(title, note);
                }
            }

            // Reset fields and editing flag
            titlebox.Text = "";
            notebox.Text = "";
            editing = false;
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Establish connection to the database
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\glaiz\Desktop\wologin\ToDoApp\ToDoApp\Database1.mdf;Integrated Security=True"))
                {
                    con.Open();

                    // Delete the selected record
                    string deleteQuery = "DELETE FROM [dbo].[notes] WHERE title = @title";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, con);
                    deleteCommand.Parameters.AddWithValue("@title", notes.Rows[previousnotes.CurrentCell.RowIndex]["Title"].ToString());
                    deleteCommand.ExecuteNonQuery();

                    // Remove the record from the DataTable
                    notes.Rows.RemoveAt(previousnotes.CurrentCell.RowIndex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while deleting the note: " + ex.Message);
            }
        }


        private void previousnotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titlebox.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            notebox.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Go Home
            this.Hide();
            HomeWindow f2 = new HomeWindow();
            f2.ShowDialog();
            this.Close();
        }

        private void previousnotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Header_Click(object sender, EventArgs e)
        {

        }
    }
}
