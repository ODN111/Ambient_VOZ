


namespace ReportUT_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_comboBox = new System.Windows.Forms.ComboBox();
            this.UID_comboBox = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_Stop_Time = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start_Time = new System.Windows.Forms.DateTimePicker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button_Reports = new MaterialSkin.Controls.MaterialButton();
            this.text_DSN = new System.Windows.Forms.TextBox();
            this.text_Report = new System.Windows.Forms.TextBox();
            this.text_Sample = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Sample = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.label_Count = new System.Windows.Forms.Label();
            this.Button_Settings = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Name_comboBox);
            this.panel1.Controls.Add(this.UID_comboBox);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateTimePicker_Stop_Time);
            this.panel1.Controls.Add(this.dateTimePicker_Start_Time);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 78);
            this.panel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(660, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(475, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "UID";
            // 
            // Name_comboBox
            // 
            this.Name_comboBox.FormattingEnabled = true;
            this.Name_comboBox.Location = new System.Drawing.Point(612, 30);
            this.Name_comboBox.Name = "Name_comboBox";
            this.Name_comboBox.Size = new System.Drawing.Size(146, 24);
            this.Name_comboBox.TabIndex = 26;
            this.Name_comboBox.Click += new System.EventHandler(this.Name_comboBox_Click);
            // 
            // UID_comboBox
            // 
            this.UID_comboBox.FormattingEnabled = true;
            this.UID_comboBox.Location = new System.Drawing.Point(426, 30);
            this.UID_comboBox.Name = "UID_comboBox";
            this.UID_comboBox.Size = new System.Drawing.Size(146, 24);
            this.UID_comboBox.TabIndex = 25;
            this.UID_comboBox.Click += new System.EventHandler(this.UID_comboBox_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(594, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(409, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(184, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Конечная дата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(0, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Начальная дата";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker_Stop_Time
            // 
            this.dateTimePicker_Stop_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_Stop_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Stop_Time.Location = new System.Drawing.Point(188, 29);
            this.dateTimePicker_Stop_Time.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Stop_Time.Name = "dateTimePicker_Stop_Time";
            this.dateTimePicker_Stop_Time.Size = new System.Drawing.Size(159, 26);
            this.dateTimePicker_Stop_Time.TabIndex = 20;
            this.dateTimePicker_Stop_Time.ValueChanged += new System.EventHandler(this.dateTimePicker_Stop_Time_ValueChanged);
            // 
            // dateTimePicker_Start_Time
            // 
            this.dateTimePicker_Start_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_Start_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Start_Time.Location = new System.Drawing.Point(4, 29);
            this.dateTimePicker_Start_Time.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Start_Time.Name = "dateTimePicker_Start_Time";
            this.dateTimePicker_Start_Time.Size = new System.Drawing.Size(159, 26);
            this.dateTimePicker_Start_Time.TabIndex = 17;
            this.dateTimePicker_Start_Time.ValueChanged += new System.EventHandler(this.dateTimePicker_Start_Time_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Maximum = 110;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(784, 5);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Button_Reports);
            this.panel2.Controls.Add(this.text_DSN);
            this.panel2.Controls.Add(this.text_Report);
            this.panel2.Controls.Add(this.text_Sample);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Button_Sample);
            this.panel2.Location = new System.Drawing.Point(3, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 126);
            this.panel2.TabIndex = 19;
            this.panel2.Visible = false;
            // 
            // Button_Reports
            // 
            this.Button_Reports.AutoSize = false;
            this.Button_Reports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Reports.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Button_Reports.Depth = 0;
            this.Button_Reports.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Reports.HighEmphasis = true;
            this.Button_Reports.Icon = ((System.Drawing.Image)(resources.GetObject("Button_Reports.Icon")));
            this.Button_Reports.Location = new System.Drawing.Point(705, 44);
            this.Button_Reports.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_Reports.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Reports.Name = "Button_Reports";
            this.Button_Reports.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Button_Reports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Button_Reports.Size = new System.Drawing.Size(40, 28);
            this.Button_Reports.TabIndex = 8;
            this.Button_Reports.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Button_Reports.UseAccentColor = false;
            this.Button_Reports.UseVisualStyleBackColor = true;
            this.Button_Reports.Click += new System.EventHandler(this.Button_Reports_Click);
            // 
            // text_DSN
            // 
            this.text_DSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_DSN.Location = new System.Drawing.Point(234, 5);
            this.text_DSN.Name = "text_DSN";
            this.text_DSN.Size = new System.Drawing.Size(465, 26);
            this.text_DSN.TabIndex = 7;
            // 
            // text_Report
            // 
            this.text_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Report.Location = new System.Drawing.Point(234, 46);
            this.text_Report.Name = "text_Report";
            this.text_Report.Size = new System.Drawing.Size(465, 26);
            this.text_Report.TabIndex = 6;
            // 
            // text_Sample
            // 
            this.text_Sample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_Sample.Location = new System.Drawing.Point(234, 87);
            this.text_Sample.Name = "text_Sample";
            this.text_Sample.Size = new System.Drawing.Size(465, 26);
            this.text_Sample.TabIndex = 5;
            this.text_Sample.Text = "C:\\Program Files (x86)\\Ambient Viewer\\ReportGen\\карта_температуры_и_влажности_Юни" +
    "тесс.docx";
            this.text_Sample.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Путь для шаблона";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Путь для отчетов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Источник данных (DSN)";
            // 
            // Button_Sample
            // 
            this.Button_Sample.AutoSize = false;
            this.Button_Sample.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Sample.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Button_Sample.Depth = 0;
            this.Button_Sample.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Sample.HighEmphasis = true;
            this.Button_Sample.Icon = ((System.Drawing.Image)(resources.GetObject("Button_Sample.Icon")));
            this.Button_Sample.Location = new System.Drawing.Point(739, 153);
            this.Button_Sample.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_Sample.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Sample.Name = "Button_Sample";
            this.Button_Sample.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Button_Sample.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Button_Sample.Size = new System.Drawing.Size(10, 10);
            this.Button_Sample.TabIndex = 9;
            this.Button_Sample.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Button_Sample.UseAccentColor = false;
            this.Button_Sample.UseVisualStyleBackColor = true;
            this.Button_Sample.Visible = false;
            this.Button_Sample.Click += new System.EventHandler(this.Button_Sample_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.materialButton2);
            this.panel4.Controls.Add(this.materialButton1);
            this.panel4.Controls.Add(this.label_Count);
            this.panel4.Controls.Add(this.Button_Settings);
            this.panel4.Location = new System.Drawing.Point(3, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(779, 61);
            this.panel4.TabIndex = 21;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(514, 14);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(184, 36);
            this.materialButton2.TabIndex = 24;
            this.materialButton2.Text = "Получить Список Имен(UID)";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Visible = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(320, 14);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(184, 36);
            this.materialButton1.TabIndex = 23;
            this.materialButton1.Text = "История Имен(UID)";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Count.Location = new System.Drawing.Point(31, 14);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(166, 18);
            this.label_Count.TabIndex = 22;
            this.label_Count.Text = "Всего / Обработано";
            this.label_Count.Visible = false;
            // 
            // Button_Settings
            // 
            this.Button_Settings.AutoSize = false;
            this.Button_Settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Settings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Button_Settings.Depth = 0;
            this.Button_Settings.HighEmphasis = true;
            this.Button_Settings.Icon = ((System.Drawing.Image)(resources.GetObject("Button_Settings.Icon")));
            this.Button_Settings.Location = new System.Drawing.Point(273, 14);
            this.Button_Settings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Button_Settings.MouseState = MaterialSkin.MouseState.HOVER;
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Button_Settings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Button_Settings.Size = new System.Drawing.Size(39, 36);
            this.Button_Settings.TabIndex = 18;
            this.Button_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Settings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Button_Settings.UseAccentColor = false;
            this.Button_Settings.UseVisualStyleBackColor = true;
            this.Button_Settings.Click += new System.EventHandler(this.Button_Settings_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 303);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ReportUT_.Properties.Resources.loading_load;
            this.pictureBox1.Location = new System.Drawing.Point(358, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 150);
            this.Name = "Form1";
            this.Text = "                                             Формирование журнала изменений имен " +
    "и идентификаторов датчиков";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start_Time;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Stop_Time;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_DSN;
        private System.Windows.Forms.TextBox text_Report;
        private System.Windows.Forms.TextBox text_Sample;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton Button_Sample;
        private MaterialSkin.Controls.MaterialButton Button_Reports;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialButton Button_Settings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Count;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.ComboBox Name_comboBox;
        private System.Windows.Forms.ComboBox UID_comboBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

