namespace DataBase_test1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеСтрокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискСтрокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.labelAutoSave = new System.Windows.Forms.Label();
            this.button_SaveFile = new System.Windows.Forms.Button();
            this.button_AddRow = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.label_Year = new System.Windows.Forms.Label();
            this.textBox_Language = new System.Windows.Forms.TextBox();
            this.label_Language = new System.Windows.Forms.Label();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.label_Country = new System.Windows.Forms.Label();
            this.textBox_Director = new System.Windows.Forms.TextBox();
            this.label_Director = new System.Windows.Forms.Label();
            this.comboBox_Genre = new System.Windows.Forms.ComboBox();
            this.label_Genre = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label_TitleFilm = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.Label_ID = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.button_Sort = new System.Windows.Forms.Button();
            this.comboBoxChoiceSort = new System.Windows.Forms.ComboBox();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.button_SearchOK = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.labelSave = new System.Windows.Forms.Label();
            this.label_Search2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panel_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Title,
            this.Column_Genre,
            this.Column_Director,
            this.Column_Year,
            this.Column_Country,
            this.Column_Language});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid.Location = new System.Drawing.Point(0, 260);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(697, 160);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGrid_CellBeginEdit);
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellEndEdit);
            this.dataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGrid_RowsRemoved);
            // 
            // Column_ID
            // 
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            // 
            // Column_Title
            // 
            this.Column_Title.HeaderText = "Название";
            this.Column_Title.Name = "Column_Title";
            // 
            // Column_Genre
            // 
            this.Column_Genre.HeaderText = "Жанр";
            this.Column_Genre.Name = "Column_Genre";
            // 
            // Column_Director
            // 
            this.Column_Director.HeaderText = "Режисёр";
            this.Column_Director.Name = "Column_Director";
            // 
            // Column_Year
            // 
            this.Column_Year.HeaderText = "Год";
            this.Column_Year.Name = "Column_Year";
            // 
            // Column_Country
            // 
            this.Column_Country.HeaderText = "Страна";
            this.Column_Country.Name = "Column_Country";
            // 
            // Column_Language
            // 
            this.Column_Language.HeaderText = "Язык";
            this.Column_Language.Name = "Column_Language";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.менюToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(697, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеСтрокToolStripMenuItem,
            this.поискСтрокToolStripMenuItem,
            this.удалитьВсёToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.менюToolStripMenuItem.Text = "Команды";
            // 
            // добавлениеСтрокToolStripMenuItem
            // 
            this.добавлениеСтрокToolStripMenuItem.Name = "добавлениеСтрокToolStripMenuItem";
            this.добавлениеСтрокToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавлениеСтрокToolStripMenuItem.Text = "Добавление строк";
            this.добавлениеСтрокToolStripMenuItem.Click += new System.EventHandler(this.добавлениеСтрокToolStripMenuItem_Click);
            // 
            // поискСтрокToolStripMenuItem
            // 
            this.поискСтрокToolStripMenuItem.Name = "поискСтрокToolStripMenuItem";
            this.поискСтрокToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поискСтрокToolStripMenuItem.Text = "Поиск строк";
            this.поискСтрокToolStripMenuItem.Click += new System.EventHandler(this.поискСтрокToolStripMenuItem_Click);
            // 
            // удалитьВсёToolStripMenuItem
            // 
            this.удалитьВсёToolStripMenuItem.Name = "удалитьВсёToolStripMenuItem";
            this.удалитьВсёToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьВсёToolStripMenuItem.Text = "Удалить всё";
            this.удалитьВсёToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсёToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_OpenFile.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_OpenFile.Location = new System.Drawing.Point(12, 91);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(288, 26);
            this.button_OpenFile.TabIndex = 13;
            this.button_OpenFile.Text = "Открыть файл";
            this.button_OpenFile.UseVisualStyleBackColor = false;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // labelAutoSave
            // 
            this.labelAutoSave.AutoSize = true;
            this.labelAutoSave.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutoSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAutoSave.Location = new System.Drawing.Point(544, 0);
            this.labelAutoSave.Name = "labelAutoSave";
            this.labelAutoSave.Size = new System.Drawing.Size(148, 17);
            this.labelAutoSave.TabIndex = 26;
            this.labelAutoSave.Text = "Автосохранение...";
            this.labelAutoSave.Visible = false;
            // 
            // button_SaveFile
            // 
            this.button_SaveFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_SaveFile.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_SaveFile.Location = new System.Drawing.Point(12, 123);
            this.button_SaveFile.Name = "button_SaveFile";
            this.button_SaveFile.Size = new System.Drawing.Size(288, 26);
            this.button_SaveFile.TabIndex = 27;
            this.button_SaveFile.Text = "Сохранить файл";
            this.button_SaveFile.UseVisualStyleBackColor = false;
            this.button_SaveFile.Click += new System.EventHandler(this.button_SaveFile_Click);
            // 
            // button_AddRow
            // 
            this.button_AddRow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddRow.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddRow.Location = new System.Drawing.Point(10, 155);
            this.button_AddRow.Name = "button_AddRow";
            this.button_AddRow.Size = new System.Drawing.Size(290, 26);
            this.button_AddRow.TabIndex = 28;
            this.button_AddRow.Text = "Добавление данных";
            this.button_AddRow.UseVisualStyleBackColor = false;
            this.button_AddRow.Click += new System.EventHandler(this.button_AddRow_Click);
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Search.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(10, 187);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(290, 26);
            this.button_Search.TabIndex = 29;
            this.button_Search.Text = "Поиск записей";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTitle.Location = new System.Drawing.Point(12, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(288, 43);
            this.labelTitle.TabIndex = 30;
            this.labelTitle.Text = "База фильмов";
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Add.Location = new System.Drawing.Point(16, 190);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(299, 27);
            this.button_Add.TabIndex = 113;
            this.button_Add.Text = "Добавить запись";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(101, 164);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(217, 20);
            this.textBox_Year.TabIndex = 112;
            // 
            // label_Year
            // 
            this.label_Year.AutoSize = true;
            this.label_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Year.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Year.Location = new System.Drawing.Point(13, 165);
            this.label_Year.Name = "label_Year";
            this.label_Year.Size = new System.Drawing.Size(34, 16);
            this.label_Year.TabIndex = 111;
            this.label_Year.Text = "Год";
            // 
            // textBox_Language
            // 
            this.textBox_Language.Location = new System.Drawing.Point(101, 138);
            this.textBox_Language.Name = "textBox_Language";
            this.textBox_Language.Size = new System.Drawing.Size(217, 20);
            this.textBox_Language.TabIndex = 110;
            // 
            // label_Language
            // 
            this.label_Language.AutoSize = true;
            this.label_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Language.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Language.Location = new System.Drawing.Point(13, 139);
            this.label_Language.Name = "label_Language";
            this.label_Language.Size = new System.Drawing.Size(46, 16);
            this.label_Language.TabIndex = 109;
            this.label_Language.Text = "Язык";
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(101, 112);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(217, 20);
            this.textBox_Country.TabIndex = 108;
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Country.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Country.Location = new System.Drawing.Point(13, 113);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(62, 16);
            this.label_Country.TabIndex = 107;
            this.label_Country.Text = "Страна";
            // 
            // textBox_Director
            // 
            this.textBox_Director.Location = new System.Drawing.Point(101, 86);
            this.textBox_Director.Name = "textBox_Director";
            this.textBox_Director.Size = new System.Drawing.Size(217, 20);
            this.textBox_Director.TabIndex = 106;
            // 
            // label_Director
            // 
            this.label_Director.AutoSize = true;
            this.label_Director.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Director.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Director.Location = new System.Drawing.Point(13, 87);
            this.label_Director.Name = "label_Director";
            this.label_Director.Size = new System.Drawing.Size(72, 16);
            this.label_Director.TabIndex = 105;
            this.label_Director.Text = "Режисёр";
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
            this.comboBox_Genre.Location = new System.Drawing.Point(101, 59);
            this.comboBox_Genre.Name = "comboBox_Genre";
            this.comboBox_Genre.Size = new System.Drawing.Size(217, 21);
            this.comboBox_Genre.TabIndex = 104;
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Genre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Genre.Location = new System.Drawing.Point(13, 60);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(49, 16);
            this.label_Genre.TabIndex = 103;
            this.label_Genre.Text = "Жанр";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(101, 33);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(217, 20);
            this.textBox_Title.TabIndex = 102;
            // 
            // label_TitleFilm
            // 
            this.label_TitleFilm.AutoSize = true;
            this.label_TitleFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TitleFilm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TitleFilm.Location = new System.Drawing.Point(13, 34);
            this.label_TitleFilm.Name = "label_TitleFilm";
            this.label_TitleFilm.Size = new System.Drawing.Size(82, 16);
            this.label_TitleFilm.TabIndex = 101;
            this.label_TitleFilm.Text = "Название";
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ID.Location = new System.Drawing.Point(101, 7);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(83, 20);
            this.textBox_ID.TabIndex = 114;
            this.textBox_ID.TabStop = false;
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_ID.Location = new System.Drawing.Point(13, 8);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(23, 16);
            this.Label_ID.TabIndex = 100;
            this.Label_ID.Text = "ID";
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdd.Controls.Add(this.button_Add);
            this.panelAdd.Controls.Add(this.textBox_Year);
            this.panelAdd.Controls.Add(this.label_Year);
            this.panelAdd.Controls.Add(this.textBox_Language);
            this.panelAdd.Controls.Add(this.label_Language);
            this.panelAdd.Controls.Add(this.textBox_Country);
            this.panelAdd.Controls.Add(this.label_Country);
            this.panelAdd.Controls.Add(this.textBox_Director);
            this.panelAdd.Controls.Add(this.label_Director);
            this.panelAdd.Controls.Add(this.comboBox_Genre);
            this.panelAdd.Controls.Add(this.label_Genre);
            this.panelAdd.Controls.Add(this.textBox_Title);
            this.panelAdd.Controls.Add(this.label_TitleFilm);
            this.panelAdd.Controls.Add(this.textBox_ID);
            this.panelAdd.Controls.Add(this.Label_ID);
            this.panelAdd.Location = new System.Drawing.Point(367, 26);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(329, 228);
            this.panelAdd.TabIndex = 115;
            // 
            // button_Sort
            // 
            this.button_Sort.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Sort.Font = new System.Drawing.Font("Eras Bold ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sort.Location = new System.Drawing.Point(12, 219);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(114, 26);
            this.button_Sort.TabIndex = 116;
            this.button_Sort.Text = "Сортировать";
            this.button_Sort.UseVisualStyleBackColor = false;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // comboBoxChoiceSort
            // 
            this.comboBoxChoiceSort.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBoxChoiceSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoiceSort.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChoiceSort.FormattingEnabled = true;
            this.comboBoxChoiceSort.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
            this.comboBoxChoiceSort.Location = new System.Drawing.Point(132, 219);
            this.comboBoxChoiceSort.Name = "comboBoxChoiceSort";
            this.comboBoxChoiceSort.Size = new System.Drawing.Size(168, 24);
            this.comboBoxChoiceSort.TabIndex = 117;
            // 
            // panel_Search
            // 
            this.panel_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Search.Controls.Add(this.label_Search2);
            this.panel_Search.Controls.Add(this.button_SearchOK);
            this.panel_Search.Controls.Add(this.textBox_Search);
            this.panel_Search.Controls.Add(this.label_Search);
            this.panel_Search.Location = new System.Drawing.Point(358, 26);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(334, 224);
            this.panel_Search.TabIndex = 118;
            this.panel_Search.Visible = false;
            // 
            // button_SearchOK
            // 
            this.button_SearchOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_SearchOK.Location = new System.Drawing.Point(50, 184);
            this.button_SearchOK.Name = "button_SearchOK";
            this.button_SearchOK.Size = new System.Drawing.Size(208, 27);
            this.button_SearchOK.TabIndex = 102;
            this.button_SearchOK.Text = "Найти";
            this.button_SearchOK.UseVisualStyleBackColor = true;
            this.button_SearchOK.Click += new System.EventHandler(this.button_SearchOK_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(50, 159);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(208, 20);
            this.textBox_Search.TabIndex = 101;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search.Location = new System.Drawing.Point(115, 94);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(78, 25);
            this.label_Search.TabIndex = 100;
            this.label_Search.Text = "Поиск";
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSave.Location = new System.Drawing.Point(279, 0);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(108, 17);
            this.labelSave.TabIndex = 119;
            this.labelSave.Text = "Cохранение...";
            this.labelSave.Visible = false;
            // 
            // label_Search2
            // 
            this.label_Search2.AutoSize = true;
            this.label_Search2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search2.Location = new System.Drawing.Point(16, 122);
            this.label_Search2.Name = "label_Search2";
            this.label_Search2.Size = new System.Drawing.Size(297, 32);
            this.label_Search2.TabIndex = 103;
            this.label_Search2.Text = "Введите любое слово, которое хотите \r\nнайти в базе";
            this.label_Search2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(697, 420);
            this.Controls.Add(this.panel_Search);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.comboBoxChoiceSort);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_AddRow);
            this.Controls.Add(this.button_SaveFile);
            this.Controls.Add(this.labelAutoSave);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(713, 458);
            this.Name = "MainForm";
            this.Text = "База данных для фильмов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.Label labelAutoSave;
        private System.Windows.Forms.Button button_SaveFile;
        private System.Windows.Forms.Button button_AddRow;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.DataGridView dataGrid;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеСтрокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискСтрокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсёToolStripMenuItem;
        private System.Windows.Forms.Button button_Add;
        public System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.Label label_Year;
        public System.Windows.Forms.TextBox textBox_Language;
        private System.Windows.Forms.Label label_Language;
        public System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.Label label_Country;
        public System.Windows.Forms.TextBox textBox_Director;
        private System.Windows.Forms.Label label_Director;
        public System.Windows.Forms.ComboBox comboBox_Genre;
        private System.Windows.Forms.Label label_Genre;
        public System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label_TitleFilm;
        public System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.ComboBox comboBoxChoiceSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Language;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.Button button_SearchOK;
        public System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Label label_Search2;
    }
}

