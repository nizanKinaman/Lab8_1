namespace Lab7_2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 800);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Controls.Add(this.radioButton8);
            this.panel2.Controls.Add(this.radioButton10);
            this.panel2.Location = new System.Drawing.Point(0, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 103);
            this.panel2.TabIndex = 6;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton6.Location = new System.Drawing.Point(14, 14);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(90, 21);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Тетраэдр";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton8.Location = new System.Drawing.Point(14, 41);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(89, 21);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Гексаэдр";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton10.Location = new System.Drawing.Point(14, 68);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(85, 21);
            this.radioButton10.TabIndex = 3;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Октаэдр";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(816, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Смещение";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(819, 453);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(830, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(877, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Y";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(865, 453);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(922, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Z";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(911, 453);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(902, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(902, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(908, 520);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "по Z";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(911, 539);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(862, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "по Y";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(865, 539);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 20);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(816, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "по X";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(819, 539);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(816, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Поворот";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(902, 574);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(908, 602);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "по Z";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(911, 621);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(40, 20);
            this.textBox7.TabIndex = 28;
            this.textBox7.Text = "1,5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(862, 602);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "по Y";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(865, 621);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(40, 20);
            this.textBox8.TabIndex = 26;
            this.textBox8.Text = "1,5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(816, 602);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "по X";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(819, 621);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(40, 20);
            this.textBox9.TabIndex = 24;
            this.textBox9.Text = "1,5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(816, 575);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Масштаб";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(816, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 122);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Многогранники";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(819, 746);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 23);
            this.button7.TabIndex = 36;
            this.button7.Text = "Очистить всё";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(816, 156);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 23);
            this.button8.TabIndex = 37;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(816, 185);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(135, 23);
            this.button9.TabIndex = 38;
            this.button9.Text = "Load";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(816, 244);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 17);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "Задать точки образующей";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(816, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 27);
            this.button4.TabIndex = 40;
            this.button4.Text = "Задать образующую";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(816, 322);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 40);
            this.button5.TabIndex = 41;
            this.button5.Text = "Создать фигуру вращения";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(816, 370);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Ось вращения:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "x",
            "y",
            "z"});
            this.comboBox1.Location = new System.Drawing.Point(902, 368);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(30, 21);
            this.comboBox1.TabIndex = 44;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(819, 695);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(40, 20);
            this.textBox10.TabIndex = 45;
            this.textBox10.Text = "0";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(866, 695);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(39, 20);
            this.textBox11.TabIndex = 46;
            this.textBox11.Text = "0";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(911, 695);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(40, 20);
            this.textBox12.TabIndex = 47;
            this.textBox12.Text = "1000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(816, 676);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 16);
            this.label14.TabIndex = 48;
            this.label14.Text = "по X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(866, 676);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 16);
            this.label15.TabIndex = 49;
            this.label15.Text = "по Y";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(908, 676);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 16);
            this.label16.TabIndex = 50;
            this.label16.Text = "по Z";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(816, 658);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 18);
            this.label17.TabIndex = 51;
            this.label17.Text = "Вектор зрителя";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1051, 833);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

