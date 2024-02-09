namespace ToDoApp
{
    partial class HomeWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.Label();
            this.NotesButton = new System.Windows.Forms.Button();
            this.ToDoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(12, 21);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(546, 97);
            this.Header.TabIndex = 1;
            this.Header.Text = "LifeMap";
            this.Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.Click += new System.EventHandler(this.Header_Click);
            // 
            // NotesButton
            // 
            this.NotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesButton.ForeColor = System.Drawing.Color.RosyBrown;
            this.NotesButton.Location = new System.Drawing.Point(171, 155);
            this.NotesButton.Name = "NotesButton";
            this.NotesButton.Size = new System.Drawing.Size(206, 41);
            this.NotesButton.TabIndex = 6;
            this.NotesButton.Text = "Notes";
            this.NotesButton.UseVisualStyleBackColor = true;
            this.NotesButton.Click += new System.EventHandler(this.NotesButton_Click);
            // 
            // ToDoButton
            // 
            this.ToDoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoButton.ForeColor = System.Drawing.Color.RosyBrown;
            this.ToDoButton.Location = new System.Drawing.Point(171, 202);
            this.ToDoButton.Name = "ToDoButton";
            this.ToDoButton.Size = new System.Drawing.Size(206, 41);
            this.ToDoButton.TabIndex = 7;
            this.ToDoButton.Text = "To Do";
            this.ToDoButton.UseVisualStyleBackColor = true;
            this.ToDoButton.Click += new System.EventHandler(this.ToDoButton_Click);
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(570, 427);
            this.Controls.Add(this.ToDoButton);
            this.Controls.Add(this.NotesButton);
            this.Controls.Add(this.Header);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "HomeWindow";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.HomeWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button NotesButton;
        private System.Windows.Forms.Button ToDoButton;
    }
}