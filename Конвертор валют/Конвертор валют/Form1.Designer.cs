
namespace Конвертор_валют
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
            this.components = new System.ComponentModel.Container();
            this.first_panel = new System.Windows.Forms.Panel();
            this.kzt_btn = new System.Windows.Forms.Button();
            this.byn_btn = new System.Windows.Forms.Button();
            this.rub_btn = new System.Windows.Forms.Button();
            this.cny_btn = new System.Windows.Forms.Button();
            this.eur_btn = new System.Windows.Forms.Button();
            this.usd_btn = new System.Windows.Forms.Button();
            this.first_btn = new System.Windows.Forms.Button();
            this.second_panel = new System.Windows.Forms.Panel();
            this.kzt1_btn = new System.Windows.Forms.Button();
            this.byn1_btn = new System.Windows.Forms.Button();
            this.rub1_btn = new System.Windows.Forms.Button();
            this.cny1_btn = new System.Windows.Forms.Button();
            this.eur1_btn = new System.Windows.Forms.Button();
            this.usd1_btn = new System.Windows.Forms.Button();
            this.second_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.imperian_label = new System.Windows.Forms.Label();
            this.metric_label = new System.Windows.Forms.Label();
            this.Write_Box = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ControlBox = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.animation_currency0 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.animation_currency1 = new System.Windows.Forms.Timer(this.components);
            this.convert_btn = new WindowsFormsApp1.RoundBtn();
            this.minimize_btn = new WindowsFormsApp1.RoundBtn();
            this.exit_btn = new WindowsFormsApp1.RoundBtn();
            this.first_panel.SuspendLayout();
            this.second_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // first_panel
            // 
            this.first_panel.BackColor = System.Drawing.Color.YellowGreen;
            this.first_panel.Controls.Add(this.kzt_btn);
            this.first_panel.Controls.Add(this.byn_btn);
            this.first_panel.Controls.Add(this.rub_btn);
            this.first_panel.Controls.Add(this.cny_btn);
            this.first_panel.Controls.Add(this.eur_btn);
            this.first_panel.Controls.Add(this.usd_btn);
            this.first_panel.Controls.Add(this.first_btn);
            this.first_panel.Location = new System.Drawing.Point(12, 40);
            this.first_panel.MaximumSize = new System.Drawing.Size(232, 322);
            this.first_panel.MinimumSize = new System.Drawing.Size(232, 45);
            this.first_panel.Name = "first_panel";
            this.first_panel.Size = new System.Drawing.Size(232, 45);
            this.first_panel.TabIndex = 4;
            // 
            // kzt_btn
            // 
            this.kzt_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.kzt_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.kzt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kzt_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kzt_btn.ForeColor = System.Drawing.Color.White;
            this.kzt_btn.Location = new System.Drawing.Point(0, 274);
            this.kzt_btn.Name = "kzt_btn";
            this.kzt_btn.Size = new System.Drawing.Size(232, 47);
            this.kzt_btn.TabIndex = 2;
            this.kzt_btn.Text = "Tenge                 KZT";
            this.kzt_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kzt_btn.UseVisualStyleBackColor = false;
            this.kzt_btn.Click += new System.EventHandler(this.kzt_btn_Click);
            // 
            // byn_btn
            // 
            this.byn_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.byn_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.byn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byn_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byn_btn.ForeColor = System.Drawing.Color.White;
            this.byn_btn.Location = new System.Drawing.Point(0, 228);
            this.byn_btn.Name = "byn_btn";
            this.byn_btn.Size = new System.Drawing.Size(232, 47);
            this.byn_btn.TabIndex = 1;
            this.byn_btn.Text = "Belorusian rubls  BYN";
            this.byn_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.byn_btn.UseVisualStyleBackColor = false;
            this.byn_btn.Click += new System.EventHandler(this.byn_btn_Click);
            // 
            // rub_btn
            // 
            this.rub_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.rub_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.rub_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rub_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rub_btn.ForeColor = System.Drawing.Color.White;
            this.rub_btn.Location = new System.Drawing.Point(0, 183);
            this.rub_btn.Name = "rub_btn";
            this.rub_btn.Size = new System.Drawing.Size(232, 47);
            this.rub_btn.TabIndex = 1;
            this.rub_btn.Text = "Rubls                 RUB";
            this.rub_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rub_btn.UseVisualStyleBackColor = false;
            this.rub_btn.Click += new System.EventHandler(this.rub_btn_Click);
            // 
            // cny_btn
            // 
            this.cny_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.cny_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.cny_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cny_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cny_btn.ForeColor = System.Drawing.Color.White;
            this.cny_btn.Location = new System.Drawing.Point(0, 137);
            this.cny_btn.Name = "cny_btn";
            this.cny_btn.Size = new System.Drawing.Size(232, 47);
            this.cny_btn.TabIndex = 1;
            this.cny_btn.Text = "Yuan                  CNY";
            this.cny_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cny_btn.UseVisualStyleBackColor = false;
            this.cny_btn.Click += new System.EventHandler(this.cny_btn_Click);
            // 
            // eur_btn
            // 
            this.eur_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.eur_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.eur_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eur_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eur_btn.ForeColor = System.Drawing.Color.White;
            this.eur_btn.Location = new System.Drawing.Point(0, 91);
            this.eur_btn.Name = "eur_btn";
            this.eur_btn.Size = new System.Drawing.Size(232, 47);
            this.eur_btn.TabIndex = 1;
            this.eur_btn.Text = "Euro                   EUR";
            this.eur_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eur_btn.UseVisualStyleBackColor = false;
            this.eur_btn.Click += new System.EventHandler(this.eur_btn_Click);
            // 
            // usd_btn
            // 
            this.usd_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.usd_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.usd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usd_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usd_btn.ForeColor = System.Drawing.Color.White;
            this.usd_btn.Location = new System.Drawing.Point(0, 47);
            this.usd_btn.Name = "usd_btn";
            this.usd_btn.Size = new System.Drawing.Size(232, 47);
            this.usd_btn.TabIndex = 1;
            this.usd_btn.Text = "Dollars               USD";
            this.usd_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usd_btn.UseVisualStyleBackColor = false;
            this.usd_btn.Click += new System.EventHandler(this.usd_btn_Click);
            // 
            // first_btn
            // 
            this.first_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.first_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.first_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.first_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_btn.ForeColor = System.Drawing.Color.White;
            this.first_btn.Location = new System.Drawing.Point(0, 0);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(232, 45);
            this.first_btn.TabIndex = 0;
            this.first_btn.Text = "First currency       🡻";
            this.first_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.first_btn.UseVisualStyleBackColor = false;
            this.first_btn.Click += new System.EventHandler(this.first_btn_Click);
            // 
            // second_panel
            // 
            this.second_panel.BackColor = System.Drawing.Color.YellowGreen;
            this.second_panel.Controls.Add(this.kzt1_btn);
            this.second_panel.Controls.Add(this.byn1_btn);
            this.second_panel.Controls.Add(this.rub1_btn);
            this.second_panel.Controls.Add(this.cny1_btn);
            this.second_panel.Controls.Add(this.eur1_btn);
            this.second_panel.Controls.Add(this.usd1_btn);
            this.second_panel.Controls.Add(this.second_btn);
            this.second_panel.Location = new System.Drawing.Point(261, 40);
            this.second_panel.MaximumSize = new System.Drawing.Size(232, 322);
            this.second_panel.MinimumSize = new System.Drawing.Size(232, 45);
            this.second_panel.Name = "second_panel";
            this.second_panel.Size = new System.Drawing.Size(232, 45);
            this.second_panel.TabIndex = 5;
            // 
            // kzt1_btn
            // 
            this.kzt1_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.kzt1_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.kzt1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kzt1_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kzt1_btn.ForeColor = System.Drawing.Color.White;
            this.kzt1_btn.Location = new System.Drawing.Point(0, 274);
            this.kzt1_btn.Name = "kzt1_btn";
            this.kzt1_btn.Size = new System.Drawing.Size(232, 47);
            this.kzt1_btn.TabIndex = 2;
            this.kzt1_btn.Text = "Tenge                 KZT";
            this.kzt1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kzt1_btn.UseVisualStyleBackColor = false;
            this.kzt1_btn.Click += new System.EventHandler(this.kzt1_btn_Click);
            // 
            // byn1_btn
            // 
            this.byn1_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.byn1_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.byn1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byn1_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.byn1_btn.ForeColor = System.Drawing.Color.White;
            this.byn1_btn.Location = new System.Drawing.Point(0, 228);
            this.byn1_btn.Name = "byn1_btn";
            this.byn1_btn.Size = new System.Drawing.Size(232, 47);
            this.byn1_btn.TabIndex = 1;
            this.byn1_btn.Text = "Belorusian rubls  BYN";
            this.byn1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.byn1_btn.UseVisualStyleBackColor = false;
            this.byn1_btn.Click += new System.EventHandler(this.byn1_btn_Click);
            // 
            // rub1_btn
            // 
            this.rub1_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.rub1_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.rub1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rub1_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rub1_btn.ForeColor = System.Drawing.Color.White;
            this.rub1_btn.Location = new System.Drawing.Point(0, 183);
            this.rub1_btn.Name = "rub1_btn";
            this.rub1_btn.Size = new System.Drawing.Size(232, 47);
            this.rub1_btn.TabIndex = 1;
            this.rub1_btn.Text = "Rubls                 RUB";
            this.rub1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rub1_btn.UseVisualStyleBackColor = false;
            this.rub1_btn.Click += new System.EventHandler(this.rub1_btn_Click);
            // 
            // cny1_btn
            // 
            this.cny1_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.cny1_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.cny1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cny1_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cny1_btn.ForeColor = System.Drawing.Color.White;
            this.cny1_btn.Location = new System.Drawing.Point(0, 137);
            this.cny1_btn.Name = "cny1_btn";
            this.cny1_btn.Size = new System.Drawing.Size(232, 47);
            this.cny1_btn.TabIndex = 1;
            this.cny1_btn.Text = "Yuan                  CNY";
            this.cny1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cny1_btn.UseVisualStyleBackColor = false;
            this.cny1_btn.Click += new System.EventHandler(this.cny1_btn_Click);
            // 
            // eur1_btn
            // 
            this.eur1_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.eur1_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.eur1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eur1_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eur1_btn.ForeColor = System.Drawing.Color.White;
            this.eur1_btn.Location = new System.Drawing.Point(0, 91);
            this.eur1_btn.Name = "eur1_btn";
            this.eur1_btn.Size = new System.Drawing.Size(232, 47);
            this.eur1_btn.TabIndex = 1;
            this.eur1_btn.Text = "Euro                   EUR";
            this.eur1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eur1_btn.UseVisualStyleBackColor = false;
            this.eur1_btn.Click += new System.EventHandler(this.eur1_btn_Click);
            // 
            // usd1_btn
            // 
            this.usd1_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.usd1_btn.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.usd1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usd1_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usd1_btn.ForeColor = System.Drawing.Color.White;
            this.usd1_btn.Location = new System.Drawing.Point(0, 47);
            this.usd1_btn.Name = "usd1_btn";
            this.usd1_btn.Size = new System.Drawing.Size(232, 47);
            this.usd1_btn.TabIndex = 1;
            this.usd1_btn.Text = "Dollars               USD";
            this.usd1_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usd1_btn.UseVisualStyleBackColor = false;
            this.usd1_btn.Click += new System.EventHandler(this.usd1_btn_Click);
            // 
            // second_btn
            // 
            this.second_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.second_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.second_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.second_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second_btn.ForeColor = System.Drawing.Color.White;
            this.second_btn.Location = new System.Drawing.Point(0, 0);
            this.second_btn.Name = "second_btn";
            this.second_btn.Size = new System.Drawing.Size(232, 45);
            this.second_btn.TabIndex = 0;
            this.second_btn.Text = "Second currency  🡻";
            this.second_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.second_btn.UseVisualStyleBackColor = false;
            this.second_btn.Click += new System.EventHandler(this.second_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(530, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Result:";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_label.Location = new System.Drawing.Point(539, 357);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(180, 28);
            this.result_label.TabIndex = 12;
            this.result_label.Text = "                            ";
            // 
            // imperian_label
            // 
            this.imperian_label.AutoSize = true;
            this.imperian_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imperian_label.Location = new System.Drawing.Point(606, 219);
            this.imperian_label.Name = "imperian_label";
            this.imperian_label.Size = new System.Drawing.Size(0, 25);
            this.imperian_label.TabIndex = 9;
            // 
            // metric_label
            // 
            this.metric_label.AutoSize = true;
            this.metric_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metric_label.Location = new System.Drawing.Point(539, 40);
            this.metric_label.Name = "metric_label";
            this.metric_label.Size = new System.Drawing.Size(135, 25);
            this.metric_label.TabIndex = 10;
            this.metric_label.Text = "First currency";
            // 
            // Write_Box
            // 
            this.Write_Box.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Write_Box.Location = new System.Drawing.Point(539, 69);
            this.Write_Box.Name = "Write_Box";
            this.Write_Box.Size = new System.Drawing.Size(229, 24);
            this.Write_Box.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox2.Location = new System.Drawing.Point(518, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 421);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // ControlBox
            // 
            this.ControlBox.BackColor = System.Drawing.Color.White;
            this.ControlBox.Controls.Add(this.panel2);
            this.ControlBox.Controls.Add(this.panel3);
            this.ControlBox.Controls.Add(this.pictureBox1);
            this.ControlBox.Controls.Add(this.label1);
            this.ControlBox.Controls.Add(this.minimize_btn);
            this.ControlBox.Controls.Add(this.exit_btn);
            this.ControlBox.Location = new System.Drawing.Point(0, 0);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(800, 30);
            this.ControlBox.TabIndex = 13;
            this.ControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBox_MouseDown);
            this.ControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlBox_MouseMove);
            this.ControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlBox_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(249, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 25);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(191, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 19);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Конвертор_валют.Properties.Resources.currency_exchange;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currency convertor";
            // 
            // animation_currency0
            // 
            this.animation_currency0.Interval = 10;
            this.animation_currency0.Tick += new System.EventHandler(this.animation_currency0_Tick);
            // 
            // animation_currency1
            // 
            this.animation_currency1.Interval = 10;
            this.animation_currency1.Tick += new System.EventHandler(this.animation_currency1_Tick);
            // 
            // convert_btn
            // 
            this.convert_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convert_btn.Location = new System.Drawing.Point(534, 124);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Radius = 45;
            this.convert_btn.Size = new System.Drawing.Size(150, 78);
            this.convert_btn.TabIndex = 14;
            this.convert_btn.Text = "Convert";
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(741, 2);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Radius = 25;
            this.minimize_btn.Size = new System.Drawing.Size(25, 25);
            this.minimize_btn.TabIndex = 1;
            this.minimize_btn.Text = "-";
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            this.minimize_btn.MouseEnter += new System.EventHandler(this.minimize_btn_MouseEnter);
            this.minimize_btn.MouseLeave += new System.EventHandler(this.minimize_btn_MouseLeave);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(772, 2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Radius = 25;
            this.exit_btn.Size = new System.Drawing.Size(25, 25);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "X";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            this.exit_btn.MouseEnter += new System.EventHandler(this.exit_btn_MouseEnter);
            this.exit_btn.MouseLeave += new System.EventHandler(this.exit_btn_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convert_btn);
            this.Controls.Add(this.ControlBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.imperian_label);
            this.Controls.Add(this.metric_label);
            this.Controls.Add(this.Write_Box);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.second_panel);
            this.Controls.Add(this.first_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.first_panel.ResumeLayout(false);
            this.second_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ControlBox.ResumeLayout(false);
            this.ControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel first_panel;
        private System.Windows.Forms.Button kzt_btn;
        private System.Windows.Forms.Button byn_btn;
        private System.Windows.Forms.Button rub_btn;
        private System.Windows.Forms.Button cny_btn;
        private System.Windows.Forms.Button eur_btn;
        private System.Windows.Forms.Button usd_btn;
        private System.Windows.Forms.Button first_btn;
        private System.Windows.Forms.Panel second_panel;
        private System.Windows.Forms.Button kzt1_btn;
        private System.Windows.Forms.Button byn1_btn;
        private System.Windows.Forms.Button rub1_btn;
        private System.Windows.Forms.Button cny1_btn;
        private System.Windows.Forms.Button eur1_btn;
        private System.Windows.Forms.Button usd1_btn;
        private System.Windows.Forms.Button second_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Label imperian_label;
        private System.Windows.Forms.Label metric_label;
        private System.Windows.Forms.TextBox Write_Box;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel ControlBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp1.RoundBtn minimize_btn;
        private WindowsFormsApp1.RoundBtn exit_btn;
        private WindowsFormsApp1.RoundBtn convert_btn;
        private System.Windows.Forms.Timer animation_currency0;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer animation_currency1;
    }
}

