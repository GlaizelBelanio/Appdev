namespace ToDoApp
{
    partial class NotesWindow
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
            this.titlebox = new System.Windows.Forms.TextBox();
            this.notebox = new System.Windows.Forms.TextBox();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.notelabel = new System.Windows.Forms.Label();
            this.previousnotes = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previousnotes)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebox
            // 
            this.titlebox.Location = new System.Drawing.Point(556, 56);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(627, 22);
            this.titlebox.TabIndex = 0;
            this.titlebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // notebox
            // 
            this.notebox.Location = new System.Drawing.Point(556, 110);
            this.notebox.Multiline = true;
            this.notebox.Name = "notebox";
            this.notebox.Size = new System.Drawing.Size(627, 614);
            this.notebox.TabIndex = 1;
            // 
            // Titlelabel
            // 
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Titlelabel.Location = new System.Drawing.Point(556, 30);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(541, 23);
            this.Titlelabel.TabIndex = 2;
            this.Titlelabel.Text = "Title:";
            // 
            // notelabel
            // 
            this.notelabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notelabel.Location = new System.Drawing.Point(556, 84);
            this.notelabel.Name = "notelabel";
            this.notelabel.Size = new System.Drawing.Size(548, 23);
            this.notelabel.TabIndex = 3;
            this.notelabel.Text = "Note:";
            // 
            // previousnotes
            // 
            this.previousnotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previousnotes.BackgroundColor = System.Drawing.Color.White;
            this.previousnotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousnotes.Location = new System.Drawing.Point(12, 110);
            this.previousnotes.Name = "previousnotes";
            this.previousnotes.RowHeadersWidth = 51;
            this.previousnotes.RowTemplate.Height = 24;
            this.previousnotes.Size = new System.Drawing.Size(538, 566);
            this.previousnotes.TabIndex = 4;
            this.previousnotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousnotes_CellContentClick);
            this.previousnotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousnotes_CellDoubleClick);
            // 
            // Header
            // 
            this.Header.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(12, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(538, 91);
            this.Header.TabIndex = 5;
            this.Header.Text = "Notes";
            this.Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.Click += new System.EventHandler(this.Header_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.ForeColor = System.Drawing.Color.RosyBrown;
            this.LoadButton.Location = new System.Drawing.Point(12, 683);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(130, 41);
            this.LoadButton.TabIndex = 10;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.ForeColor = System.Drawing.Color.RosyBrown;
            this.NewButton.Location = new System.Drawing.Point(148, 682);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(130, 41);
            this.NewButton.TabIndex = 11;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.RosyBrown;
            this.SaveButton.Location = new System.Drawing.Point(284, 682);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 41);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.RosyBrown;
            this.DeleteButton.Location = new System.Drawing.Point(420, 682);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(130, 41);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(1108, 733);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NotesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1195, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.previousnotes);
            this.Controls.Add(this.notelabel);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.notebox);
            this.Controls.Add(this.titlebox);
            this.MaximizeBox = false;
            this.Name = "NotesWindow";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.NotesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousnotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.TextBox notebox;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label notelabel;
        private System.Windows.Forms.DataGridView previousnotes;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button button1;
    }
}