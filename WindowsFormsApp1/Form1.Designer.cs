namespace WindowsFormsApp1
{
    partial class Alexophia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alexophia));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простыеФильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чернобелыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.насыщенностьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеФильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеПоГауссуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фильрСобеляXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрСобеляYToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрПрюиттаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матМорфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сужениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.растяжениеdilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.градиентToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.другоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйФильрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.идеальныйОтражательToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйМирToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.линейноеРастяжениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.файлToolStripMenuItem.CheckOnClick = true;
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.простыеФильтрыToolStripMenuItem,
            this.матричныеФильтрыToolStripMenuItem,
            this.матМорфологияToolStripMenuItem,
            this.другоеToolStripMenuItem});
            this.фильтрыToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // простыеФильтрыToolStripMenuItem
            // 
            this.простыеФильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.иверсияToolStripMenuItem,
            this.чернобелыйToolStripMenuItem1,
            this.сепияToolStripMenuItem1,
            this.яркостьToolStripMenuItem1,
            this.насыщенностьToolStripMenuItem1});
            this.простыеФильтрыToolStripMenuItem.Name = "простыеФильтрыToolStripMenuItem";
            this.простыеФильтрыToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.простыеФильтрыToolStripMenuItem.Text = "Простые фильтры";
            // 
            // иверсияToolStripMenuItem
            // 
            this.иверсияToolStripMenuItem.Name = "иверсияToolStripMenuItem";
            this.иверсияToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.иверсияToolStripMenuItem.Text = "Иверсия";
            this.иверсияToolStripMenuItem.Click += new System.EventHandler(this.иверсияToolStripMenuItem_Click);
            // 
            // чернобелыйToolStripMenuItem1
            // 
            this.чернобелыйToolStripMenuItem1.Name = "чернобелыйToolStripMenuItem1";
            this.чернобелыйToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.чернобелыйToolStripMenuItem1.Text = "Черно-белый";
            this.чернобелыйToolStripMenuItem1.Click += new System.EventHandler(this.чернобелыйToolStripMenuItem1_Click);
            // 
            // сепияToolStripMenuItem1
            // 
            this.сепияToolStripMenuItem1.Name = "сепияToolStripMenuItem1";
            this.сепияToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.сепияToolStripMenuItem1.Text = "Сепия";
            this.сепияToolStripMenuItem1.Click += new System.EventHandler(this.сепияToolStripMenuItem1_Click);
            // 
            // яркостьToolStripMenuItem1
            // 
            this.яркостьToolStripMenuItem1.Name = "яркостьToolStripMenuItem1";
            this.яркостьToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.яркостьToolStripMenuItem1.Text = "Яркость";
            this.яркостьToolStripMenuItem1.Click += new System.EventHandler(this.яркостьToolStripMenuItem1_Click);
            // 
            // насыщенностьToolStripMenuItem1
            // 
            this.насыщенностьToolStripMenuItem1.Name = "насыщенностьToolStripMenuItem1";
            this.насыщенностьToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.насыщенностьToolStripMenuItem1.Text = "Насыщенность";
            this.насыщенностьToolStripMenuItem1.Click += new System.EventHandler(this.насыщенностьToolStripMenuItem1_Click);
            // 
            // матричныеФильтрыToolStripMenuItem
            // 
            this.матричныеФильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem1,
            this.размытиеПоГауссуToolStripMenuItem1,
            this.фильрСобеляXToolStripMenuItem,
            this.фильтрСобеляYToolStripMenuItem1,
            this.резкостьToolStripMenuItem1,
            this.фильтрПрюиттаToolStripMenuItem});
            this.матричныеФильтрыToolStripMenuItem.Name = "матричныеФильтрыToolStripMenuItem";
            this.матричныеФильтрыToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.матричныеФильтрыToolStripMenuItem.Text = "Матричные фильтры";
            // 
            // размытиеToolStripMenuItem1
            // 
            this.размытиеToolStripMenuItem1.Name = "размытиеToolStripMenuItem1";
            this.размытиеToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.размытиеToolStripMenuItem1.Text = "Размытие";
            this.размытиеToolStripMenuItem1.Click += new System.EventHandler(this.размытиеToolStripMenuItem1_Click);
            // 
            // размытиеПоГауссуToolStripMenuItem1
            // 
            this.размытиеПоГауссуToolStripMenuItem1.Name = "размытиеПоГауссуToolStripMenuItem1";
            this.размытиеПоГауссуToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.размытиеПоГауссуToolStripMenuItem1.Text = "Размытие по Гауссу";
            this.размытиеПоГауссуToolStripMenuItem1.Click += new System.EventHandler(this.размытиеПоГауссуToolStripMenuItem1_Click);
            // 
            // фильрСобеляXToolStripMenuItem
            // 
            this.фильрСобеляXToolStripMenuItem.Name = "фильрСобеляXToolStripMenuItem";
            this.фильрСобеляXToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.фильрСобеляXToolStripMenuItem.Text = "Фильтр Собеля X";
            this.фильрСобеляXToolStripMenuItem.Click += new System.EventHandler(this.фильрСобеляXToolStripMenuItem_Click);
            // 
            // фильтрСобеляYToolStripMenuItem1
            // 
            this.фильтрСобеляYToolStripMenuItem1.Name = "фильтрСобеляYToolStripMenuItem1";
            this.фильтрСобеляYToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.фильтрСобеляYToolStripMenuItem1.Text = "Фильтр Собеля Y";
            this.фильтрСобеляYToolStripMenuItem1.Click += new System.EventHandler(this.фильтрСобеляYToolStripMenuItem1_Click);
            // 
            // резкостьToolStripMenuItem1
            // 
            this.резкостьToolStripMenuItem1.Name = "резкостьToolStripMenuItem1";
            this.резкостьToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.резкостьToolStripMenuItem1.Text = "Резкость";
            this.резкостьToolStripMenuItem1.Click += new System.EventHandler(this.резкостьToolStripMenuItem1_Click);
            // 
            // фильтрПрюиттаToolStripMenuItem
            // 
            this.фильтрПрюиттаToolStripMenuItem.Name = "фильтрПрюиттаToolStripMenuItem";
            this.фильтрПрюиттаToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.фильтрПрюиттаToolStripMenuItem.Text = "Фильтр Прюитта";
            this.фильтрПрюиттаToolStripMenuItem.Click += new System.EventHandler(this.фильтрПрюиттаToolStripMenuItem_Click);
            // 
            // матМорфологияToolStripMenuItem
            // 
            this.матМорфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сужениеToolStripMenuItem1,
            this.растяжениеdilationToolStripMenuItem,
            this.градиентToolStripMenuItem1});
            this.матМорфологияToolStripMenuItem.Name = "матМорфологияToolStripMenuItem";
            this.матМорфологияToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.матМорфологияToolStripMenuItem.Text = "Мат. морфология";
            // 
            // сужениеToolStripMenuItem1
            // 
            this.сужениеToolStripMenuItem1.Name = "сужениеToolStripMenuItem1";
            this.сужениеToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.сужениеToolStripMenuItem1.Text = "Сужение (erosion)";
            this.сужениеToolStripMenuItem1.Click += new System.EventHandler(this.сужениеToolStripMenuItem1_Click);
            // 
            // растяжениеdilationToolStripMenuItem
            // 
            this.растяжениеdilationToolStripMenuItem.Name = "растяжениеdilationToolStripMenuItem";
            this.растяжениеdilationToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.растяжениеdilationToolStripMenuItem.Text = "Растяжение (dilation)";
            this.растяжениеdilationToolStripMenuItem.Click += new System.EventHandler(this.растяжениеdilationToolStripMenuItem_Click);
            // 
            // градиентToolStripMenuItem1
            // 
            this.градиентToolStripMenuItem1.Name = "градиентToolStripMenuItem1";
            this.градиентToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.градиентToolStripMenuItem1.Text = "Градиент";
            this.градиентToolStripMenuItem1.Click += new System.EventHandler(this.градиентToolStripMenuItem1_Click);
            // 
            // другоеToolStripMenuItem
            // 
            this.другоеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.медианныйФильрToolStripMenuItem,
            this.идеальныйОтражательToolStripMenuItem1,
            this.серыйМирToolStripMenuItem1,
            this.линейноеРастяжениеToolStripMenuItem1});
            this.другоеToolStripMenuItem.Name = "другоеToolStripMenuItem";
            this.другоеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.другоеToolStripMenuItem.Text = "Другое";
            // 
            // медианныйФильрToolStripMenuItem
            // 
            this.медианныйФильрToolStripMenuItem.Name = "медианныйФильрToolStripMenuItem";
            this.медианныйФильрToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.медианныйФильрToolStripMenuItem.Text = "Медианный фильр";
            this.медианныйФильрToolStripMenuItem.Click += new System.EventHandler(this.медианныйФильрToolStripMenuItem_Click);
            // 
            // идеальныйОтражательToolStripMenuItem1
            // 
            this.идеальныйОтражательToolStripMenuItem1.Name = "идеальныйОтражательToolStripMenuItem1";
            this.идеальныйОтражательToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.идеальныйОтражательToolStripMenuItem1.Text = "Идеальный отражатель";
            this.идеальныйОтражательToolStripMenuItem1.Click += new System.EventHandler(this.идеальныйОтражательToolStripMenuItem1_Click);
            // 
            // серыйМирToolStripMenuItem1
            // 
            this.серыйМирToolStripMenuItem1.Name = "серыйМирToolStripMenuItem1";
            this.серыйМирToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.серыйМирToolStripMenuItem1.Text = "Серый мир";
            this.серыйМирToolStripMenuItem1.Click += new System.EventHandler(this.серыйМирToolStripMenuItem1_Click);
            // 
            // линейноеРастяжениеToolStripMenuItem1
            // 
            this.линейноеРастяжениеToolStripMenuItem1.Name = "линейноеРастяжениеToolStripMenuItem1";
            this.линейноеРастяжениеToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.линейноеРастяжениеToolStripMenuItem1.Text = "Линейное растяжение";
            this.линейноеРастяжениеToolStripMenuItem1.Click += new System.EventHandler(this.линейноеРастяжениеToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar1.Location = new System.Drawing.Point(129, 28);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(645, 36);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(780, 28);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(993, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 36);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(51, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 36);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1081, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "...";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(90, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 36);
            this.button4.TabIndex = 8;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1058, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 26);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(994, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 26);
            this.button6.TabIndex = 10;
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(893, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Параметр:";
            // 
            // Alexophia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1128, 644);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Alexophia";
            this.Text = "Artifex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem простыеФильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чернобелыйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem яркостьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem насыщенностьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem матМорфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеФильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem размытиеПоГауссуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фильрСобеляXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрСобеляYToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фильтрПрюиттаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сужениеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem растяжениеdilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem градиентToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem медианныйФильрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem идеальныйОтражательToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem линейноеРастяжениеToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
    }
}

