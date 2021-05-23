
namespace TiK_KR
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckResultLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckData_button = new System.Windows.Forms.Button();
            this.InputCRC_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.messageForCheck_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.message2_textBox = new System.Windows.Forms.TextBox();
            this.CalculateCRC_button = new System.Windows.Forms.Button();
            this.CalculatedCRC_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.message16_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.huffmanInputStr_textBox = new System.Windows.Forms.TextBox();
            this.huffmanCode_textBox = new System.Windows.Forms.TextBox();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.averageLengthLabel = new System.Windows.Forms.Label();
            this.entropyLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CheckResultLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CheckData_button);
            this.groupBox2.Controls.Add(this.InputCRC_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.messageForCheck_textBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(175, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 249);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Проверка данных";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.comboBox2.Location = new System.Drawing.Point(47, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(41, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "16";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Base:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Base: 2";
            // 
            // CheckResultLabel
            // 
            this.CheckResultLabel.AutoSize = true;
            this.CheckResultLabel.Location = new System.Drawing.Point(89, 195);
            this.CheckResultLabel.Name = "CheckResultLabel";
            this.CheckResultLabel.Size = new System.Drawing.Size(0, 13);
            this.CheckResultLabel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Результат:";
            // 
            // CheckData_button
            // 
            this.CheckData_button.Location = new System.Drawing.Point(211, 157);
            this.CheckData_button.Name = "CheckData_button";
            this.CheckData_button.Size = new System.Drawing.Size(111, 23);
            this.CheckData_button.TabIndex = 5;
            this.CheckData_button.Text = "Проверить";
            this.CheckData_button.UseVisualStyleBackColor = true;
            this.CheckData_button.Click += new System.EventHandler(this.CheckData_button_Click_1);
            // 
            // InputCRC_textBox
            // 
            this.InputCRC_textBox.Location = new System.Drawing.Point(92, 46);
            this.InputCRC_textBox.Multiline = true;
            this.InputCRC_textBox.Name = "InputCRC_textBox";
            this.InputCRC_textBox.ReadOnly = true;
            this.InputCRC_textBox.Size = new System.Drawing.Size(353, 43);
            this.InputCRC_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CRC:";
            // 
            // messageForCheck_textBox
            // 
            this.messageForCheck_textBox.Location = new System.Drawing.Point(92, 108);
            this.messageForCheck_textBox.Multiline = true;
            this.messageForCheck_textBox.Name = "messageForCheck_textBox";
            this.messageForCheck_textBox.Size = new System.Drawing.Size(353, 43);
            this.messageForCheck_textBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Входные данные:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.message2_textBox);
            this.groupBox1.Controls.Add(this.CalculateCRC_button);
            this.groupBox1.Controls.Add(this.CalculatedCRC_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.message16_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(175, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 241);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вычисление CRC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Base:  2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.comboBox1.Location = new System.Drawing.Point(45, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(41, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "16";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Base:  2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Base:";
            // 
            // message2_textBox
            // 
            this.message2_textBox.Location = new System.Drawing.Point(92, 89);
            this.message2_textBox.Multiline = true;
            this.message2_textBox.Name = "message2_textBox";
            this.message2_textBox.ReadOnly = true;
            this.message2_textBox.Size = new System.Drawing.Size(353, 43);
            this.message2_textBox.TabIndex = 5;
            // 
            // CalculateCRC_button
            // 
            this.CalculateCRC_button.Location = new System.Drawing.Point(211, 203);
            this.CalculateCRC_button.Name = "CalculateCRC_button";
            this.CalculateCRC_button.Size = new System.Drawing.Size(111, 23);
            this.CalculateCRC_button.TabIndex = 4;
            this.CalculateCRC_button.Text = "Вычислить CRC";
            this.CalculateCRC_button.UseVisualStyleBackColor = true;
            this.CalculateCRC_button.Click += new System.EventHandler(this.CalculateCRC_button_Click_1);
            // 
            // CalculatedCRC_textBox
            // 
            this.CalculatedCRC_textBox.Location = new System.Drawing.Point(92, 154);
            this.CalculatedCRC_textBox.Multiline = true;
            this.CalculatedCRC_textBox.Name = "CalculatedCRC_textBox";
            this.CalculatedCRC_textBox.Size = new System.Drawing.Size(353, 43);
            this.CalculatedCRC_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CRC:";
            // 
            // message16_textBox
            // 
            this.message16_textBox.Location = new System.Drawing.Point(92, 40);
            this.message16_textBox.Multiline = true;
            this.message16_textBox.Name = "message16_textBox";
            this.message16_textBox.Size = new System.Drawing.Size(353, 43);
            this.message16_textBox.TabIndex = 0;
            this.message16_textBox.Text = "61676573";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Входные данные:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.huffmanCode_textBox);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.huffmanInputStr_textBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 528);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кодирование";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Probability,
            this.Код});
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(434, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закодировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(458, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 295);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Декодирование";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Декодированное сообщение";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Закодированное сообщение";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Декодировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 38);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(317, 96);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 184);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(317, 96);
            this.textBox3.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 566);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CRC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.averageLengthLabel);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.entropyLabel);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Код Хаффмана";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // huffmanInputStr_textBox
            // 
            this.huffmanInputStr_textBox.Location = new System.Drawing.Point(6, 285);
            this.huffmanInputStr_textBox.Multiline = true;
            this.huffmanInputStr_textBox.Name = "huffmanInputStr_textBox";
            this.huffmanInputStr_textBox.Size = new System.Drawing.Size(434, 96);
            this.huffmanInputStr_textBox.TabIndex = 2;
            this.huffmanInputStr_textBox.Text = "is desired to reprogram, for example a talk group";
            // 
            // huffmanCode_textBox
            // 
            this.huffmanCode_textBox.Location = new System.Drawing.Point(6, 416);
            this.huffmanCode_textBox.Multiline = true;
            this.huffmanCode_textBox.Name = "huffmanCode_textBox";
            this.huffmanCode_textBox.Size = new System.Drawing.Size(434, 96);
            this.huffmanCode_textBox.TabIndex = 3;
            // 
            // Symbol
            // 
            this.Symbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Symbol.FillWeight = 60.9137F;
            this.Symbol.HeaderText = "Символ";
            this.Symbol.Name = "Symbol";
            this.Symbol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Symbol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Symbol.Width = 63;
            // 
            // Probability
            // 
            this.Probability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Probability.FillWeight = 119.5431F;
            this.Probability.HeaderText = "Вероятность";
            this.Probability.Name = "Probability";
            // 
            // Код
            // 
            this.Код.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Код.FillWeight = 119.5431F;
            this.Код.HeaderText = "Код";
            this.Код.Name = "Код";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(137, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 31);
            this.label13.TabIndex = 10;
            this.label13.Text = "↓";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(278, 382);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 31);
            this.label15.TabIndex = 11;
            this.label15.Text = "↓";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(260, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 31);
            this.label14.TabIndex = 13;
            this.label14.Text = "↓";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(41, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 31);
            this.label16.TabIndex = 12;
            this.label16.Text = "↓";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 15);
            this.label17.TabIndex = 14;
            this.label17.Text = "Входное сообщение";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 398);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 15);
            this.label18.TabIndex = 15;
            this.label18.Text = "Код Хаффмана";
            // 
            // averageLengthLabel
            // 
            this.averageLengthLabel.AutoSize = true;
            this.averageLengthLabel.Location = new System.Drawing.Point(467, 85);
            this.averageLengthLabel.Name = "averageLengthLabel";
            this.averageLengthLabel.Size = new System.Drawing.Size(149, 13);
            this.averageLengthLabel.TabIndex = 14;
            this.averageLengthLabel.Text = "Средняя длина сообщения: ";
            // 
            // entropyLabel
            // 
            this.entropyLabel.AutoSize = true;
            this.entropyLabel.Location = new System.Drawing.Point(468, 109);
            this.entropyLabel.Name = "entropyLabel";
            this.entropyLabel.Size = new System.Drawing.Size(61, 13);
            this.entropyLabel.TabIndex = 15;
            this.entropyLabel.Text = "Энтропия: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 578);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CheckResultLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CheckData_button;
        private System.Windows.Forms.TextBox InputCRC_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox messageForCheck_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox message2_textBox;
        private System.Windows.Forms.Button CalculateCRC_button;
        private System.Windows.Forms.TextBox CalculatedCRC_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox message16_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox huffmanInputStr_textBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код;
        private System.Windows.Forms.TextBox huffmanCode_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label averageLengthLabel;
        private System.Windows.Forms.Label entropyLabel;
    }
}

