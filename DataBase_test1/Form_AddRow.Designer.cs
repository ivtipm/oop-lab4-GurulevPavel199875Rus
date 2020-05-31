namespace DataBase_test1
{
    partial class Form_AddRow
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
            this.Label_ID = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label_TitleFilm = new System.Windows.Forms.Label();
            this.label_Genre = new System.Windows.Forms.Label();
            this.comboBox_Genre = new System.Windows.Forms.ComboBox();
            this.textBox_Director = new System.Windows.Forms.TextBox();
            this.label_Director = new System.Windows.Forms.Label();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.label_Country = new System.Windows.Forms.Label();
            this.textBox_Language = new System.Windows.Forms.TextBox();
            this.label_Language = new System.Windows.Forms.Label();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.label_Year = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_SearchOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_ID.Location = new System.Drawing.Point(12, 9);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(23, 16);
            this.Label_ID.TabIndex = 0;
            this.Label_ID.Text = "ID";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(100, 8);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(83, 20);
            this.textBox_ID.TabIndex = 99;
            this.textBox_ID.TabStop = false;
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(100, 34);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(217, 20);
            this.textBox_Title.TabIndex = 3;
            // 
            // label_TitleFilm
            // 
            this.label_TitleFilm.AutoSize = true;
            this.label_TitleFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TitleFilm.Location = new System.Drawing.Point(12, 35);
            this.label_TitleFilm.Name = "label_TitleFilm";
            this.label_TitleFilm.Size = new System.Drawing.Size(82, 16);
            this.label_TitleFilm.TabIndex = 2;
            this.label_TitleFilm.Text = "Название";
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Genre.Location = new System.Drawing.Point(12, 61);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(49, 16);
            this.label_Genre.TabIndex = 4;
            this.label_Genre.Text = "Жанр";
            // 
            // comboBox_Genre
            // 
            this.comboBox_Genre.FormattingEnabled = true;
            this.comboBox_Genre.Items.AddRange(new object[] {
            "Боевик\n",
            "Вестерн",
            "Гангстерский фильм",
            "Детектив",
            "Драма",
            "Исторический фильм\n",
            "Комедия\n",
            "Мелодрама\n",
            "Музыкальный фильм\n",
            "Нуар",
            "Политический фильм\n",
            "Приключенческий фильм",
            "Сказка\n",
            "Трагедия",
            "Трагикомедия",
            "Триллер",
            "\nФантастический фильм",
            "\nФильм ужасов",
            "\nФильм-катастрофа"});
            this.comboBox_Genre.Location = new System.Drawing.Point(100, 60);
            this.comboBox_Genre.Name = "comboBox_Genre";
            this.comboBox_Genre.Size = new System.Drawing.Size(217, 21);
            this.comboBox_Genre.TabIndex = 5;
            // 
            // textBox_Director
            // 
            this.textBox_Director.Location = new System.Drawing.Point(100, 87);
            this.textBox_Director.Name = "textBox_Director";
            this.textBox_Director.Size = new System.Drawing.Size(217, 20);
            this.textBox_Director.TabIndex = 7;
            // 
            // label_Director
            // 
            this.label_Director.AutoSize = true;
            this.label_Director.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Director.Location = new System.Drawing.Point(12, 88);
            this.label_Director.Name = "label_Director";
            this.label_Director.Size = new System.Drawing.Size(72, 16);
            this.label_Director.TabIndex = 6;
            this.label_Director.Text = "Режисёр";
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(100, 113);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(217, 20);
            this.textBox_Country.TabIndex = 9;
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Country.Location = new System.Drawing.Point(12, 114);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(62, 16);
            this.label_Country.TabIndex = 8;
            this.label_Country.Text = "Страна";
            // 
            // textBox_Language
            // 
            this.textBox_Language.Location = new System.Drawing.Point(100, 139);
            this.textBox_Language.Name = "textBox_Language";
            this.textBox_Language.Size = new System.Drawing.Size(217, 20);
            this.textBox_Language.TabIndex = 11;
            // 
            // label_Language
            // 
            this.label_Language.AutoSize = true;
            this.label_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Language.Location = new System.Drawing.Point(12, 140);
            this.label_Language.Name = "label_Language";
            this.label_Language.Size = new System.Drawing.Size(46, 16);
            this.label_Language.TabIndex = 10;
            this.label_Language.Text = "Язык";
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(100, 165);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(217, 20);
            this.textBox_Year.TabIndex = 13;
            // 
            // label_Year
            // 
            this.label_Year.AutoSize = true;
            this.label_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Year.Location = new System.Drawing.Point(12, 166);
            this.label_Year.Name = "label_Year";
            this.label_Year.Size = new System.Drawing.Size(34, 16);
            this.label_Year.TabIndex = 12;
            this.label_Year.Text = "Год";
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Add.Location = new System.Drawing.Point(15, 204);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(299, 27);
            this.button_Add.TabIndex = 14;
            this.button_Add.Text = "Добавить запись";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search.Location = new System.Drawing.Point(65, 11);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(53, 16);
            this.label_Search.TabIndex = 100;
            this.label_Search.Text = "Поиск";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(19, 34);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(150, 20);
            this.textBox_Search.TabIndex = 101;
            // 
            // button_SearchOK
            // 
            this.button_SearchOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_SearchOK.Location = new System.Drawing.Point(19, 61);
            this.button_SearchOK.Name = "button_SearchOK";
            this.button_SearchOK.Size = new System.Drawing.Size(150, 27);
            this.button_SearchOK.TabIndex = 102;
            this.button_SearchOK.Text = "Найти";
            this.button_SearchOK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_SearchOK);
            this.panel1.Controls.Add(this.textBox_Search);
            this.panel1.Controls.Add(this.label_Search);
            this.panel1.Location = new System.Drawing.Point(380, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 105);
            this.panel1.TabIndex = 103;
            // 
            // Form_AddRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(763, 244);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.label_Year);
            this.Controls.Add(this.textBox_Language);
            this.Controls.Add(this.label_Language);
            this.Controls.Add(this.textBox_Country);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.textBox_Director);
            this.Controls.Add(this.label_Director);
            this.Controls.Add(this.comboBox_Genre);
            this.Controls.Add(this.label_Genre);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label_TitleFilm);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.Label_ID);
            this.Name = "Form_AddRow";
            this.Text = "Добавление записи";
            this.Load += new System.EventHandler(this.Form_AddRow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.Label label_TitleFilm;
        private System.Windows.Forms.Label label_Genre;
        private System.Windows.Forms.Label label_Director;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.Label label_Language;
        private System.Windows.Forms.Label label_Year;
        private System.Windows.Forms.Button button_Add;
        public System.Windows.Forms.TextBox textBox_Title;
        public System.Windows.Forms.ComboBox comboBox_Genre;
        public System.Windows.Forms.TextBox textBox_Director;
        public System.Windows.Forms.TextBox textBox_Country;
        public System.Windows.Forms.TextBox textBox_Language;
        public System.Windows.Forms.TextBox textBox_Year;
        public System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_Search;
        public System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_SearchOK;
        private System.Windows.Forms.Panel panel1;
    }
}