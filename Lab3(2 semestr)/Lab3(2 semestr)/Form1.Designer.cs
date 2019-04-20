namespace Lab2_2_semestr_
{
    partial class Form1
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
            this.DisciplineLabel = new System.Windows.Forms.Label();
            this.DisciplineName = new System.Windows.Forms.TextBox();
            this.CourseValue = new System.Windows.Forms.NumericUpDown();
            this.CouseLabel = new System.Windows.Forms.Label();
            this.SemestrLabel = new System.Windows.Forms.Label();
            this.SemestrValue = new System.Windows.Forms.ComboBox();
            this.Specialization = new System.Windows.Forms.Label();
            this.LecturesCount = new System.Windows.Forms.TrackBar();
            this.LecturesCountLabel = new System.Windows.Forms.Label();
            this.LecturesCountValue = new System.Windows.Forms.Label();
            this.LabsCount = new System.Windows.Forms.TrackBar();
            this.LabsCountLabel = new System.Windows.Forms.Label();
            this.LabsCountValue = new System.Windows.Forms.Label();
            this.SpecializationPOIT = new System.Windows.Forms.CheckBox();
            this.SpecializationPOIBMS = new System.Windows.Forms.CheckBox();
            this.SpecializationISIT = new System.Windows.Forms.CheckBox();
            this.SpecializationDEVI = new System.Windows.Forms.CheckBox();
            this.DisciplineControl = new System.Windows.Forms.Label();
            this.exam = new System.Windows.Forms.RadioButton();
            this.test = new System.Windows.Forms.RadioButton();
            this.Lector = new System.Windows.Forms.Label();
            this.OutputList = new System.Windows.Forms.TreeView();
            this.Pulpit = new System.Windows.Forms.TextBox();
            this.SNP = new System.Windows.Forms.TextBox();
            this.NumberAudit = new System.Windows.Forms.NumericUpDown();
            this.CorpusAydit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Literature = new System.Windows.Forms.Label();
            this.CreationDate = new System.Windows.Forms.DateTimePicker();
            this.Author = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.BookList = new System.Windows.Forms.ListView();
            this.Add = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Button();
            this.AddAll = new System.Windows.Forms.Button();
            this.Example1 = new System.Windows.Forms.Button();
            this.Example2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.LectorSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.SemestrSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.LecturesSort = new System.Windows.Forms.ToolStripMenuItem();
            this.PassTypeSort = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CourseValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusAydit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisciplineLabel
            // 
            this.DisciplineLabel.AutoSize = true;
            this.DisciplineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisciplineLabel.Location = new System.Drawing.Point(13, 32);
            this.DisciplineLabel.Name = "DisciplineLabel";
            this.DisciplineLabel.Size = new System.Drawing.Size(91, 16);
            this.DisciplineLabel.TabIndex = 0;
            this.DisciplineLabel.Text = "Дисциплина:";
            // 
            // DisciplineName
            // 
            this.DisciplineName.Location = new System.Drawing.Point(111, 32);
            this.DisciplineName.Name = "DisciplineName";
            this.DisciplineName.Size = new System.Drawing.Size(268, 20);
            this.DisciplineName.TabIndex = 1;
            this.DisciplineName.Text = "Название дисциплины";
            this.DisciplineName.Enter += new System.EventHandler(this.DisciplineName_Enter);
            // 
            // CourseValue
            // 
            this.CourseValue.Location = new System.Drawing.Point(352, 59);
            this.CourseValue.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CourseValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CourseValue.Name = "CourseValue";
            this.CourseValue.Size = new System.Drawing.Size(27, 20);
            this.CourseValue.TabIndex = 2;
            this.CourseValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CouseLabel
            // 
            this.CouseLabel.AutoSize = true;
            this.CouseLabel.Location = new System.Drawing.Point(312, 61);
            this.CouseLabel.Name = "CouseLabel";
            this.CouseLabel.Size = new System.Drawing.Size(34, 13);
            this.CouseLabel.TabIndex = 3;
            this.CouseLabel.Text = "Курс:";
            // 
            // SemestrLabel
            // 
            this.SemestrLabel.AutoSize = true;
            this.SemestrLabel.Location = new System.Drawing.Point(206, 61);
            this.SemestrLabel.Name = "SemestrLabel";
            this.SemestrLabel.Size = new System.Drawing.Size(54, 13);
            this.SemestrLabel.TabIndex = 4;
            this.SemestrLabel.Text = "Семестр:";
            // 
            // SemestrValue
            // 
            this.SemestrValue.FormattingEnabled = true;
            this.SemestrValue.Items.AddRange(new object[] {
            "1",
            "2"});
            this.SemestrValue.Location = new System.Drawing.Point(266, 58);
            this.SemestrValue.Name = "SemestrValue";
            this.SemestrValue.Size = new System.Drawing.Size(40, 21);
            this.SemestrValue.TabIndex = 5;
            // 
            // Specialization
            // 
            this.Specialization.AutoSize = true;
            this.Specialization.Location = new System.Drawing.Point(28, 88);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(88, 13);
            this.Specialization.TabIndex = 6;
            this.Specialization.Text = "Специальность:";
            // 
            // LecturesCount
            // 
            this.LecturesCount.Location = new System.Drawing.Point(159, 111);
            this.LecturesCount.Maximum = 32;
            this.LecturesCount.Minimum = 10;
            this.LecturesCount.Name = "LecturesCount";
            this.LecturesCount.Size = new System.Drawing.Size(205, 45);
            this.LecturesCount.TabIndex = 11;
            this.LecturesCount.Value = 10;
            this.LecturesCount.ValueChanged += new System.EventHandler(this.LecturesCount_ValueChanged);
            // 
            // LecturesCountLabel
            // 
            this.LecturesCountLabel.AutoSize = true;
            this.LecturesCountLabel.Location = new System.Drawing.Point(45, 111);
            this.LecturesCountLabel.Name = "LecturesCountLabel";
            this.LecturesCountLabel.Size = new System.Drawing.Size(108, 13);
            this.LecturesCountLabel.TabIndex = 12;
            this.LecturesCountLabel.Text = "Количество лекций:";
            // 
            // LecturesCountValue
            // 
            this.LecturesCountValue.AutoSize = true;
            this.LecturesCountValue.Location = new System.Drawing.Point(364, 111);
            this.LecturesCountValue.Name = "LecturesCountValue";
            this.LecturesCountValue.Size = new System.Drawing.Size(0, 13);
            this.LecturesCountValue.TabIndex = 13;
            // 
            // LabsCount
            // 
            this.LabsCount.Location = new System.Drawing.Point(159, 159);
            this.LabsCount.Maximum = 32;
            this.LabsCount.Minimum = 10;
            this.LabsCount.Name = "LabsCount";
            this.LabsCount.Size = new System.Drawing.Size(205, 45);
            this.LabsCount.TabIndex = 14;
            this.LabsCount.Value = 10;
            this.LabsCount.ValueChanged += new System.EventHandler(this.LabsCount_ValueChanged);
            // 
            // LabsCountLabel
            // 
            this.LabsCountLabel.AutoSize = true;
            this.LabsCountLabel.Location = new System.Drawing.Point(9, 159);
            this.LabsCountLabel.Name = "LabsCountLabel";
            this.LabsCountLabel.Size = new System.Drawing.Size(144, 13);
            this.LabsCountLabel.TabIndex = 15;
            this.LabsCountLabel.Text = "Количество лабораторных:";
            // 
            // LabsCountValue
            // 
            this.LabsCountValue.AutoSize = true;
            this.LabsCountValue.Location = new System.Drawing.Point(364, 159);
            this.LabsCountValue.Name = "LabsCountValue";
            this.LabsCountValue.Size = new System.Drawing.Size(0, 13);
            this.LabsCountValue.TabIndex = 16;
            // 
            // SpecializationPOIT
            // 
            this.SpecializationPOIT.AutoSize = true;
            this.SpecializationPOIT.Location = new System.Drawing.Point(122, 88);
            this.SpecializationPOIT.Name = "SpecializationPOIT";
            this.SpecializationPOIT.Size = new System.Drawing.Size(57, 17);
            this.SpecializationPOIT.TabIndex = 17;
            this.SpecializationPOIT.Text = "ПОИТ";
            this.SpecializationPOIT.UseVisualStyleBackColor = true;
            // 
            // SpecializationPOIBMS
            // 
            this.SpecializationPOIBMS.AutoSize = true;
            this.SpecializationPOIBMS.Location = new System.Drawing.Point(185, 88);
            this.SpecializationPOIBMS.Name = "SpecializationPOIBMS";
            this.SpecializationPOIBMS.Size = new System.Drawing.Size(73, 17);
            this.SpecializationPOIBMS.TabIndex = 18;
            this.SpecializationPOIBMS.Text = "ПОИБМС";
            this.SpecializationPOIBMS.UseVisualStyleBackColor = true;
            // 
            // SpecializationISIT
            // 
            this.SpecializationISIT.AutoSize = true;
            this.SpecializationISIT.Location = new System.Drawing.Point(264, 88);
            this.SpecializationISIT.Name = "SpecializationISIT";
            this.SpecializationISIT.Size = new System.Drawing.Size(56, 17);
            this.SpecializationISIT.TabIndex = 19;
            this.SpecializationISIT.Text = "ИСИТ";
            this.SpecializationISIT.UseVisualStyleBackColor = true;
            // 
            // SpecializationDEVI
            // 
            this.SpecializationDEVI.AutoSize = true;
            this.SpecializationDEVI.Location = new System.Drawing.Point(326, 88);
            this.SpecializationDEVI.Name = "SpecializationDEVI";
            this.SpecializationDEVI.Size = new System.Drawing.Size(57, 17);
            this.SpecializationDEVI.TabIndex = 20;
            this.SpecializationDEVI.Text = "ДЭВИ";
            this.SpecializationDEVI.UseVisualStyleBackColor = true;
            // 
            // DisciplineControl
            // 
            this.DisciplineControl.AutoSize = true;
            this.DisciplineControl.Location = new System.Drawing.Point(166, 212);
            this.DisciplineControl.Name = "DisciplineControl";
            this.DisciplineControl.Size = new System.Drawing.Size(79, 13);
            this.DisciplineControl.TabIndex = 21;
            this.DisciplineControl.Text = "Вид контроля:";
            // 
            // exam
            // 
            this.exam.AutoSize = true;
            this.exam.Location = new System.Drawing.Point(251, 210);
            this.exam.Name = "exam";
            this.exam.Size = new System.Drawing.Size(69, 17);
            this.exam.TabIndex = 22;
            this.exam.TabStop = true;
            this.exam.Text = "экзамен";
            this.exam.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(326, 210);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(53, 17);
            this.test.TabIndex = 23;
            this.test.TabStop = true;
            this.test.Text = "зачёт";
            this.test.UseVisualStyleBackColor = true;
            // 
            // Lector
            // 
            this.Lector.AutoSize = true;
            this.Lector.Location = new System.Drawing.Point(9, 257);
            this.Lector.Name = "Lector";
            this.Lector.Size = new System.Drawing.Size(47, 13);
            this.Lector.TabIndex = 24;
            this.Lector.Text = "Лектор:";
            // 
            // OutputList
            // 
            this.OutputList.Location = new System.Drawing.Point(402, 32);
            this.OutputList.Name = "OutputList";
            this.OutputList.Size = new System.Drawing.Size(386, 388);
            this.OutputList.TabIndex = 25;
            // 
            // Pulpit
            // 
            this.Pulpit.Location = new System.Drawing.Point(66, 267);
            this.Pulpit.Name = "Pulpit";
            this.Pulpit.Size = new System.Drawing.Size(298, 20);
            this.Pulpit.TabIndex = 26;
            this.Pulpit.Text = "Кафедра";
            this.Pulpit.Enter += new System.EventHandler(this.Pulpit_Enter);
            // 
            // SNP
            // 
            this.SNP.Location = new System.Drawing.Point(66, 241);
            this.SNP.Name = "SNP";
            this.SNP.Size = new System.Drawing.Size(206, 20);
            this.SNP.TabIndex = 27;
            this.SNP.Text = "Ф.И.О.";
            this.SNP.Enter += new System.EventHandler(this.SNP_Enter);
            // 
            // NumberAudit
            // 
            this.NumberAudit.Location = new System.Drawing.Point(278, 241);
            this.NumberAudit.Maximum = new decimal(new int[] {
            430,
            0,
            0,
            0});
            this.NumberAudit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumberAudit.Name = "NumberAudit";
            this.NumberAudit.Size = new System.Drawing.Size(42, 20);
            this.NumberAudit.TabIndex = 28;
            this.NumberAudit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // CorpusAydit
            // 
            this.CorpusAydit.Location = new System.Drawing.Point(338, 241);
            this.CorpusAydit.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.CorpusAydit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CorpusAydit.Name = "CorpusAydit";
            this.CorpusAydit.Size = new System.Drawing.Size(26, 20);
            this.CorpusAydit.TabIndex = 29;
            this.CorpusAydit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(323, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "-";
            // 
            // Literature
            // 
            this.Literature.AutoSize = true;
            this.Literature.Location = new System.Drawing.Point(9, 296);
            this.Literature.Name = "Literature";
            this.Literature.Size = new System.Drawing.Size(69, 13);
            this.Literature.TabIndex = 31;
            this.Literature.Text = "Литература:";
            // 
            // CreationDate
            // 
            this.CreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreationDate.Location = new System.Drawing.Point(278, 293);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(99, 20);
            this.CreationDate.TabIndex = 32;
            this.CreationDate.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(87, 293);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(185, 20);
            this.Author.TabIndex = 33;
            this.Author.Text = "Автор";
            this.Author.Enter += new System.EventHandler(this.Author_Enter);
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(87, 319);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(290, 20);
            this.BookName.TabIndex = 34;
            this.BookName.Text = "Название";
            this.BookName.Enter += new System.EventHandler(this.BookName_Enter);
            // 
            // BookList
            // 
            this.BookList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.BookList.AutoArrange = false;
            this.BookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookList.GridLines = true;
            this.BookList.Location = new System.Drawing.Point(12, 348);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(367, 72);
            this.BookList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.BookList.TabIndex = 35;
            this.BookList.UseCompatibleStateImageBehavior = false;
            this.BookList.View = System.Windows.Forms.View.List;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 315);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(66, 27);
            this.Add.TabIndex = 36;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(104, 59);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(75, 23);
            this.Output.TabIndex = 37;
            this.Output.Text = "Вывод";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // AddAll
            // 
            this.AddAll.Location = new System.Drawing.Point(16, 59);
            this.AddAll.Name = "AddAll";
            this.AddAll.Size = new System.Drawing.Size(75, 23);
            this.AddAll.TabIndex = 38;
            this.AddAll.Text = "Добавить";
            this.AddAll.UseVisualStyleBackColor = true;
            this.AddAll.Click += new System.EventHandler(this.AddAll_Click);
            // 
            // Example1
            // 
            this.Example1.Location = new System.Drawing.Point(16, 212);
            this.Example1.Name = "Example1";
            this.Example1.Size = new System.Drawing.Size(26, 23);
            this.Example1.TabIndex = 39;
            this.Example1.Text = "1";
            this.Example1.UseVisualStyleBackColor = true;
            this.Example1.Click += new System.EventHandler(this.Example1_Click);
            // 
            // Example2
            // 
            this.Example2.Location = new System.Drawing.Point(48, 212);
            this.Example2.Name = "Example2";
            this.Example2.Size = new System.Drawing.Size(26, 23);
            this.Example2.TabIndex = 40;
            this.Example2.Text = "2";
            this.Example2.UseVisualStyleBackColor = true;
            this.Example2.Click += new System.EventHandler(this.Example2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Search,
            this.Sort,
            this.Save,
            this.About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "Menu";
            // 
            // Search
            // 
            this.Search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LectorSearch,
            this.SemestrSearch,
            this.CourseSearch});
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(54, 20);
            this.Search.Text = "Поиск";
            // 
            // LectorSearch
            // 
            this.LectorSearch.Name = "LectorSearch";
            this.LectorSearch.Size = new System.Drawing.Size(144, 22);
            this.LectorSearch.Text = "По лектору";
            this.LectorSearch.Click += new System.EventHandler(this.LectorSearch_Click);
            // 
            // SemestrSearch
            // 
            this.SemestrSearch.Name = "SemestrSearch";
            this.SemestrSearch.Size = new System.Drawing.Size(144, 22);
            this.SemestrSearch.Text = "По семестру";
            this.SemestrSearch.Click += new System.EventHandler(this.SemestrSearch_Click);
            // 
            // CourseSearch
            // 
            this.CourseSearch.Name = "CourseSearch";
            this.CourseSearch.Size = new System.Drawing.Size(144, 22);
            this.CourseSearch.Text = "По курсу";
            this.CourseSearch.Click += new System.EventHandler(this.CourseSearch_Click);
            // 
            // Sort
            // 
            this.Sort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LecturesSort,
            this.PassTypeSort});
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(107, 20);
            this.Sort.Text = "Сортировать по";
            // 
            // LecturesSort
            // 
            this.LecturesSort.Name = "LecturesSort";
            this.LecturesSort.Size = new System.Drawing.Size(181, 22);
            this.LecturesSort.Text = "Количеству лекций";
            this.LecturesSort.Click += new System.EventHandler(this.LecturesSort_Click);
            // 
            // PassTypeSort
            // 
            this.PassTypeSort.Name = "PassTypeSort";
            this.PassTypeSort.Size = new System.Drawing.Size(181, 22);
            this.PassTypeSort.Text = "Виду контроля";
            this.PassTypeSort.Click += new System.EventHandler(this.PassTypeSort_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(77, 20);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(94, 20);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.Example2);
            this.Controls.Add(this.Example1);
            this.Controls.Add(this.AddAll);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.BookList);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.CreationDate);
            this.Controls.Add(this.Literature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CorpusAydit);
            this.Controls.Add(this.NumberAudit);
            this.Controls.Add(this.SNP);
            this.Controls.Add(this.Pulpit);
            this.Controls.Add(this.OutputList);
            this.Controls.Add(this.Lector);
            this.Controls.Add(this.test);
            this.Controls.Add(this.exam);
            this.Controls.Add(this.DisciplineControl);
            this.Controls.Add(this.SpecializationDEVI);
            this.Controls.Add(this.SpecializationISIT);
            this.Controls.Add(this.SpecializationPOIBMS);
            this.Controls.Add(this.SpecializationPOIT);
            this.Controls.Add(this.LabsCountValue);
            this.Controls.Add(this.LabsCountLabel);
            this.Controls.Add(this.LabsCount);
            this.Controls.Add(this.LecturesCountValue);
            this.Controls.Add(this.LecturesCountLabel);
            this.Controls.Add(this.LecturesCount);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.SemestrValue);
            this.Controls.Add(this.SemestrLabel);
            this.Controls.Add(this.CouseLabel);
            this.Controls.Add(this.CourseValue);
            this.Controls.Add(this.DisciplineName);
            this.Controls.Add(this.DisciplineLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CourseValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberAudit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusAydit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisciplineLabel;
        private System.Windows.Forms.TextBox DisciplineName;
        private System.Windows.Forms.NumericUpDown CourseValue;
        private System.Windows.Forms.Label CouseLabel;
        private System.Windows.Forms.Label SemestrLabel;
        private System.Windows.Forms.ComboBox SemestrValue;
        private System.Windows.Forms.Label Specialization;
        private System.Windows.Forms.TrackBar LecturesCount;
        private System.Windows.Forms.Label LecturesCountLabel;
        private System.Windows.Forms.Label LecturesCountValue;
        private System.Windows.Forms.TrackBar LabsCount;
        private System.Windows.Forms.Label LabsCountLabel;
        private System.Windows.Forms.Label LabsCountValue;
        private System.Windows.Forms.CheckBox SpecializationPOIT;
        private System.Windows.Forms.CheckBox SpecializationPOIBMS;
        private System.Windows.Forms.CheckBox SpecializationISIT;
        private System.Windows.Forms.CheckBox SpecializationDEVI;
        private System.Windows.Forms.Label DisciplineControl;
        private System.Windows.Forms.RadioButton exam;
        private System.Windows.Forms.RadioButton test;
        private System.Windows.Forms.Label Lector;
        private System.Windows.Forms.TreeView OutputList;
        private System.Windows.Forms.TextBox Pulpit;
        private System.Windows.Forms.TextBox SNP;
        private System.Windows.Forms.NumericUpDown NumberAudit;
        private System.Windows.Forms.NumericUpDown CorpusAydit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Literature;
        private System.Windows.Forms.DateTimePicker CreationDate;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.ListView BookList;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.Button AddAll;
        private System.Windows.Forms.Button Example1;
        private System.Windows.Forms.Button Example2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripMenuItem Sort;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem LectorSearch;
        private System.Windows.Forms.ToolStripMenuItem SemestrSearch;
        private System.Windows.Forms.ToolStripMenuItem CourseSearch;
        private System.Windows.Forms.ToolStripMenuItem LecturesSort;
        private System.Windows.Forms.ToolStripMenuItem PassTypeSort;
    }
}

