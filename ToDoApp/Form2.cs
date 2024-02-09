using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class HomeWindow : Form
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void NotesButton_Click(object sender, EventArgs e)
        {
            //Go to Notes
            this.Hide();
            NotesWindow f3 = new NotesWindow();
            f3.ShowDialog();
            this.Close();
        }

        private void ToDoButton_Click(object sender, EventArgs e)
        {
            //Go to ToDo
            this.Hide();
            ToDoListWindow f1 = new ToDoListWindow();
            f1.ShowDialog();
            this.Close();
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {

        }

        private void Header_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                
            
        }
    }
}
