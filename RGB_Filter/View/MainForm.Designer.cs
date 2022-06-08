namespace RGB_Filter.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas_pictureBox = new System.Windows.Forms.PictureBox();
            this.main_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SetSimpleCanvas_button = new System.Windows.Forms.Button();
            this.SetFiltredCanvas_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.GetFromFile_ButtonCanvas = new System.Windows.Forms.Button();
            this.TakeScreenshot_ButtonCanvas = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.drawFrame_checkBoxCanvas = new System.Windows.Forms.CheckBox();
            this.cutPicture_buttonCanvas = new System.Windows.Forms.Button();
            this.Size_X_textBoxCanvas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Start_Y_textBoxCanvas = new System.Windows.Forms.TextBox();
            this.Start_X_textBoxCanvas = new System.Windows.Forms.TextBox();
            this.Size_Y_textBoxCanvas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cutPicture_pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Rmax_textBox = new System.Windows.Forms.TextBox();
            this.Bmax_increment_button = new System.Windows.Forms.Button();
            this.Gmax_textBox = new System.Windows.Forms.TextBox();
            this.Rmin_textBox = new System.Windows.Forms.TextBox();
            this.Bmax_textBox = new System.Windows.Forms.TextBox();
            this.Gmax_increment_button = new System.Windows.Forms.Button();
            this.Gmin_textBox = new System.Windows.Forms.TextBox();
            this.Rmax_increment_button = new System.Windows.Forms.Button();
            this.Bmin_textBox = new System.Windows.Forms.TextBox();
            this.Bmax_decrement_button = new System.Windows.Forms.Button();
            this.Gmax_decrement_button = new System.Windows.Forms.Button();
            this.Rmax_decrement_button = new System.Windows.Forms.Button();
            this.Bmin_increment_button = new System.Windows.Forms.Button();
            this.Gmin_increment_button = new System.Windows.Forms.Button();
            this.Rmin_increment_button = new System.Windows.Forms.Button();
            this.Bmin_decrement_button = new System.Windows.Forms.Button();
            this.Gmin_decrement_button = new System.Windows.Forms.Button();
            this.searchB_checkBox = new System.Windows.Forms.CheckBox();
            this.searchG_checkBox = new System.Windows.Forms.CheckBox();
            this.searchR_checkBox = new System.Windows.Forms.CheckBox();
            this.Rmin_decrement_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rightPixelColor_button = new System.Windows.Forms.Button();
            this.wrongPixelColor_button = new System.Windows.Forms.Button();
            this.Apply_button = new System.Windows.Forms.Button();
            this.GetPicture_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rightPixelColor_colorDialog = new System.Windows.Forms.ColorDialog();
            this.wrongPixelColor_colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.canvas_pictureBox)).BeginInit();
            this.main_tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutPicture_pictureBoxCanvas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas_pictureBox
            // 
            this.canvas_pictureBox.Location = new System.Drawing.Point(301, 12);
            this.canvas_pictureBox.Name = "canvas_pictureBox";
            this.canvas_pictureBox.Size = new System.Drawing.Size(1000, 580);
            this.canvas_pictureBox.TabIndex = 2;
            this.canvas_pictureBox.TabStop = false;
            // 
            // main_tabControl
            // 
            this.main_tabControl.Controls.Add(this.tabPage1);
            this.main_tabControl.Controls.Add(this.tabPage2);
            this.main_tabControl.Location = new System.Drawing.Point(12, 12);
            this.main_tabControl.Name = "main_tabControl";
            this.main_tabControl.SelectedIndex = 0;
            this.main_tabControl.Size = new System.Drawing.Size(283, 525);
            this.main_tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(275, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Canvas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Apply_button);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(275, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SetSimpleCanvas_button
            // 
            this.SetSimpleCanvas_button.Location = new System.Drawing.Point(12, 543);
            this.SetSimpleCanvas_button.Name = "SetSimpleCanvas_button";
            this.SetSimpleCanvas_button.Size = new System.Drawing.Size(120, 50);
            this.SetSimpleCanvas_button.TabIndex = 4;
            this.SetSimpleCanvas_button.Text = "SetSimpleCanvas";
            this.SetSimpleCanvas_button.UseVisualStyleBackColor = true;
            this.SetSimpleCanvas_button.Click += new System.EventHandler(this.SetSimpleCanvas_button_Click);
            // 
            // SetFiltredCanvas_button
            // 
            this.SetFiltredCanvas_button.Location = new System.Drawing.Point(166, 542);
            this.SetFiltredCanvas_button.Name = "SetFiltredCanvas_button";
            this.SetFiltredCanvas_button.Size = new System.Drawing.Size(120, 50);
            this.SetFiltredCanvas_button.TabIndex = 5;
            this.SetFiltredCanvas_button.Text = "SetFiltredCanvas";
            this.SetFiltredCanvas_button.UseVisualStyleBackColor = true;
            this.SetFiltredCanvas_button.Click += new System.EventHandler(this.SetFiltredCanvas_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.GetFromFile_ButtonCanvas);
            this.groupBox1.Controls.Add(this.TakeScreenshot_ButtonCanvas);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 118);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get canvas";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(189, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 25);
            this.button5.TabIndex = 71;
            this.button5.Text = "ldoe";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // GetFromFile_ButtonCanvas
            // 
            this.GetFromFile_ButtonCanvas.Location = new System.Drawing.Point(77, 66);
            this.GetFromFile_ButtonCanvas.Name = "GetFromFile_ButtonCanvas";
            this.GetFromFile_ButtonCanvas.Size = new System.Drawing.Size(96, 25);
            this.GetFromFile_ButtonCanvas.TabIndex = 70;
            this.GetFromFile_ButtonCanvas.Text = "Get from file";
            this.GetFromFile_ButtonCanvas.UseVisualStyleBackColor = true;
            this.GetFromFile_ButtonCanvas.Click += new System.EventHandler(this.GetFromFile_ButtonCanvas_Click);
            // 
            // TakeScreenshot_ButtonCanvas
            // 
            this.TakeScreenshot_ButtonCanvas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TakeScreenshot_ButtonCanvas.Location = new System.Drawing.Point(78, 35);
            this.TakeScreenshot_ButtonCanvas.Name = "TakeScreenshot_ButtonCanvas";
            this.TakeScreenshot_ButtonCanvas.Size = new System.Drawing.Size(95, 25);
            this.TakeScreenshot_ButtonCanvas.TabIndex = 70;
            this.TakeScreenshot_ButtonCanvas.Text = "Screenshot";
            this.TakeScreenshot_ButtonCanvas.UseVisualStyleBackColor = true;
            this.TakeScreenshot_ButtonCanvas.Click += new System.EventHandler(this.TakeScreenshot_ButtonCanvas_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.drawFrame_checkBoxCanvas);
            this.groupBox5.Controls.Add(this.cutPicture_pictureBoxCanvas);
            this.groupBox5.Controls.Add(this.cutPicture_buttonCanvas);
            this.groupBox5.Controls.Add(this.Size_X_textBoxCanvas);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.Start_Y_textBoxCanvas);
            this.groupBox5.Controls.Add(this.Start_X_textBoxCanvas);
            this.groupBox5.Controls.Add(this.Size_Y_textBoxCanvas);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 121);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 373);
            this.groupBox5.TabIndex = 87;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cut canvas";
            // 
            // drawFrame_checkBoxCanvas
            // 
            this.drawFrame_checkBoxCanvas.AutoSize = true;
            this.drawFrame_checkBoxCanvas.Checked = true;
            this.drawFrame_checkBoxCanvas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawFrame_checkBoxCanvas.Location = new System.Drawing.Point(83, 106);
            this.drawFrame_checkBoxCanvas.Name = "drawFrame_checkBoxCanvas";
            this.drawFrame_checkBoxCanvas.Size = new System.Drawing.Size(87, 19);
            this.drawFrame_checkBoxCanvas.TabIndex = 123;
            this.drawFrame_checkBoxCanvas.Text = "Draw frame";
            this.drawFrame_checkBoxCanvas.UseVisualStyleBackColor = true;
            // 
            // cutPicture_buttonCanvas
            // 
            this.cutPicture_buttonCanvas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cutPicture_buttonCanvas.Location = new System.Drawing.Point(83, 131);
            this.cutPicture_buttonCanvas.Name = "cutPicture_buttonCanvas";
            this.cutPicture_buttonCanvas.Size = new System.Drawing.Size(90, 25);
            this.cutPicture_buttonCanvas.TabIndex = 71;
            this.cutPicture_buttonCanvas.Text = "Cut";
            this.cutPicture_buttonCanvas.UseVisualStyleBackColor = true;
            this.cutPicture_buttonCanvas.Click += new System.EventHandler(this.cutPicture_buttonCanvas_Click);
            // 
            // Size_X_textBoxCanvas
            // 
            this.Size_X_textBoxCanvas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size_X_textBoxCanvas.Location = new System.Drawing.Point(137, 50);
            this.Size_X_textBoxCanvas.Name = "Size_X_textBoxCanvas";
            this.Size_X_textBoxCanvas.Size = new System.Drawing.Size(48, 22);
            this.Size_X_textBoxCanvas.TabIndex = 102;
            this.Size_X_textBoxCanvas.TextChanged += new System.EventHandler(this.cutPicture_DataChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 15);
            this.label7.TabIndex = 107;
            this.label7.Text = "X";
            // 
            // Start_Y_textBoxCanvas
            // 
            this.Start_Y_textBoxCanvas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start_Y_textBoxCanvas.Location = new System.Drawing.Point(74, 78);
            this.Start_Y_textBoxCanvas.Name = "Start_Y_textBoxCanvas";
            this.Start_Y_textBoxCanvas.Size = new System.Drawing.Size(48, 22);
            this.Start_Y_textBoxCanvas.TabIndex = 101;
            this.Start_Y_textBoxCanvas.TextChanged += new System.EventHandler(this.cutPicture_DataChanged);
            // 
            // Start_X_textBoxCanvas
            // 
            this.Start_X_textBoxCanvas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start_X_textBoxCanvas.Location = new System.Drawing.Point(74, 50);
            this.Start_X_textBoxCanvas.Name = "Start_X_textBoxCanvas";
            this.Start_X_textBoxCanvas.Size = new System.Drawing.Size(48, 22);
            this.Start_X_textBoxCanvas.TabIndex = 100;
            this.Start_X_textBoxCanvas.TextChanged += new System.EventHandler(this.cutPicture_DataChanged);
            // 
            // Size_Y_textBoxCanvas
            // 
            this.Size_Y_textBoxCanvas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size_Y_textBoxCanvas.Location = new System.Drawing.Point(137, 78);
            this.Size_Y_textBoxCanvas.Name = "Size_Y_textBoxCanvas";
            this.Size_Y_textBoxCanvas.Size = new System.Drawing.Size(48, 22);
            this.Size_Y_textBoxCanvas.TabIndex = 103;
            this.Size_Y_textBoxCanvas.TextChanged += new System.EventHandler(this.cutPicture_DataChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 106;
            this.label3.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 107;
            this.label5.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 105;
            this.label2.Text = "Start";
            // 
            // cutPicture_pictureBoxCanvas
            // 
            this.cutPicture_pictureBoxCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.cutPicture_pictureBoxCanvas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cutPicture_pictureBoxCanvas.Location = new System.Drawing.Point(3, 227);
            this.cutPicture_pictureBoxCanvas.Name = "cutPicture_pictureBoxCanvas";
            this.cutPicture_pictureBoxCanvas.Size = new System.Drawing.Size(263, 143);
            this.cutPicture_pictureBoxCanvas.TabIndex = 108;
            this.cutPicture_pictureBoxCanvas.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Rmax_textBox);
            this.groupBox4.Controls.Add(this.Bmax_increment_button);
            this.groupBox4.Controls.Add(this.Gmax_textBox);
            this.groupBox4.Controls.Add(this.Rmin_textBox);
            this.groupBox4.Controls.Add(this.Bmax_textBox);
            this.groupBox4.Controls.Add(this.Gmax_increment_button);
            this.groupBox4.Controls.Add(this.Gmin_textBox);
            this.groupBox4.Controls.Add(this.Rmax_increment_button);
            this.groupBox4.Controls.Add(this.Bmin_textBox);
            this.groupBox4.Controls.Add(this.Bmax_decrement_button);
            this.groupBox4.Controls.Add(this.Gmax_decrement_button);
            this.groupBox4.Controls.Add(this.Rmax_decrement_button);
            this.groupBox4.Controls.Add(this.Bmin_increment_button);
            this.groupBox4.Controls.Add(this.Gmin_increment_button);
            this.groupBox4.Controls.Add(this.Rmin_increment_button);
            this.groupBox4.Controls.Add(this.Bmin_decrement_button);
            this.groupBox4.Controls.Add(this.Gmin_decrement_button);
            this.groupBox4.Controls.Add(this.searchB_checkBox);
            this.groupBox4.Controls.Add(this.searchG_checkBox);
            this.groupBox4.Controls.Add(this.searchR_checkBox);
            this.groupBox4.Controls.Add(this.Rmin_decrement_button);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 126);
            this.groupBox4.TabIndex = 112;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search settings";
            // 
            // Rmax_textBox
            // 
            this.Rmax_textBox.Location = new System.Drawing.Point(190, 37);
            this.Rmax_textBox.Name = "Rmax_textBox";
            this.Rmax_textBox.Size = new System.Drawing.Size(48, 23);
            this.Rmax_textBox.TabIndex = 86;
            this.Rmax_textBox.TextChanged += new System.EventHandler(this.FilterCanvas_DataChanged);
            // 
            // Bmax_increment_button
            // 
            this.Bmax_increment_button.Location = new System.Drawing.Point(244, 95);
            this.Bmax_increment_button.Name = "Bmax_increment_button";
            this.Bmax_increment_button.Size = new System.Drawing.Size(15, 23);
            this.Bmax_increment_button.TabIndex = 95;
            this.Bmax_increment_button.Text = ">";
            this.Bmax_increment_button.UseVisualStyleBackColor = true;
            // 
            // Gmax_textBox
            // 
            this.Gmax_textBox.Location = new System.Drawing.Point(190, 66);
            this.Gmax_textBox.Name = "Gmax_textBox";
            this.Gmax_textBox.Size = new System.Drawing.Size(48, 23);
            this.Gmax_textBox.TabIndex = 87;
            this.Gmax_textBox.TextChanged += new System.EventHandler(this.FilterCanvas_DataChanged);
            // 
            // Rmin_textBox
            // 
            this.Rmin_textBox.Location = new System.Drawing.Point(62, 37);
            this.Rmin_textBox.Name = "Rmin_textBox";
            this.Rmin_textBox.Size = new System.Drawing.Size(48, 23);
            this.Rmin_textBox.TabIndex = 83;
            this.Rmin_textBox.TextChanged += new System.EventHandler(this.FilterCanvas_DataChanged);
            // 
            // Bmax_textBox
            // 
            this.Bmax_textBox.Location = new System.Drawing.Point(190, 95);
            this.Bmax_textBox.Name = "Bmax_textBox";
            this.Bmax_textBox.Size = new System.Drawing.Size(48, 23);
            this.Bmax_textBox.TabIndex = 88;
            this.Bmax_textBox.TextChanged += new System.EventHandler(this.FilterCanvas_DataChanged);
            // 
            // Gmax_increment_button
            // 
            this.Gmax_increment_button.Location = new System.Drawing.Point(244, 66);
            this.Gmax_increment_button.Name = "Gmax_increment_button";
            this.Gmax_increment_button.Size = new System.Drawing.Size(15, 23);
            this.Gmax_increment_button.TabIndex = 94;
            this.Gmax_increment_button.Text = ">";
            this.Gmax_increment_button.UseVisualStyleBackColor = true;
            // 
            // Gmin_textBox
            // 
            this.Gmin_textBox.Location = new System.Drawing.Point(62, 66);
            this.Gmin_textBox.Name = "Gmin_textBox";
            this.Gmin_textBox.Size = new System.Drawing.Size(48, 23);
            this.Gmin_textBox.TabIndex = 84;
            this.Gmin_textBox.TextChanged += new System.EventHandler(this.FilterCanvas_DataChanged);
            // 
            // Rmax_increment_button
            // 
            this.Rmax_increment_button.Location = new System.Drawing.Point(244, 37);
            this.Rmax_increment_button.Name = "Rmax_increment_button";
            this.Rmax_increment_button.Size = new System.Drawing.Size(15, 23);
            this.Rmax_increment_button.TabIndex = 93;
            this.Rmax_increment_button.Text = ">";
            this.Rmax_increment_button.UseVisualStyleBackColor = true;
            // 
            // Bmin_textBox
            // 
            this.Bmin_textBox.Location = new System.Drawing.Point(62, 95);
            this.Bmin_textBox.Name = "Bmin_textBox";
            this.Bmin_textBox.Size = new System.Drawing.Size(48, 23);
            this.Bmin_textBox.TabIndex = 85;
            this.Bmin_textBox.TextChanged += new System.EventHandler(this.FilterCanvas_DataChanged);
            // 
            // Bmax_decrement_button
            // 
            this.Bmax_decrement_button.Location = new System.Drawing.Point(169, 95);
            this.Bmax_decrement_button.Name = "Bmax_decrement_button";
            this.Bmax_decrement_button.Size = new System.Drawing.Size(15, 23);
            this.Bmax_decrement_button.TabIndex = 92;
            this.Bmax_decrement_button.Text = "<";
            this.Bmax_decrement_button.UseVisualStyleBackColor = true;
            // 
            // Gmax_decrement_button
            // 
            this.Gmax_decrement_button.Location = new System.Drawing.Point(169, 66);
            this.Gmax_decrement_button.Name = "Gmax_decrement_button";
            this.Gmax_decrement_button.Size = new System.Drawing.Size(15, 23);
            this.Gmax_decrement_button.TabIndex = 91;
            this.Gmax_decrement_button.Text = "<";
            this.Gmax_decrement_button.UseVisualStyleBackColor = true;
            // 
            // Rmax_decrement_button
            // 
            this.Rmax_decrement_button.Location = new System.Drawing.Point(169, 37);
            this.Rmax_decrement_button.Name = "Rmax_decrement_button";
            this.Rmax_decrement_button.Size = new System.Drawing.Size(15, 23);
            this.Rmax_decrement_button.TabIndex = 90;
            this.Rmax_decrement_button.Text = "<";
            this.Rmax_decrement_button.UseVisualStyleBackColor = true;
            // 
            // Bmin_increment_button
            // 
            this.Bmin_increment_button.Location = new System.Drawing.Point(116, 95);
            this.Bmin_increment_button.Name = "Bmin_increment_button";
            this.Bmin_increment_button.Size = new System.Drawing.Size(15, 23);
            this.Bmin_increment_button.TabIndex = 89;
            this.Bmin_increment_button.Text = ">";
            this.Bmin_increment_button.UseVisualStyleBackColor = true;
            // 
            // Gmin_increment_button
            // 
            this.Gmin_increment_button.Location = new System.Drawing.Point(116, 66);
            this.Gmin_increment_button.Name = "Gmin_increment_button";
            this.Gmin_increment_button.Size = new System.Drawing.Size(15, 23);
            this.Gmin_increment_button.TabIndex = 88;
            this.Gmin_increment_button.Text = ">";
            this.Gmin_increment_button.UseVisualStyleBackColor = true;
            // 
            // Rmin_increment_button
            // 
            this.Rmin_increment_button.Location = new System.Drawing.Point(116, 37);
            this.Rmin_increment_button.Name = "Rmin_increment_button";
            this.Rmin_increment_button.Size = new System.Drawing.Size(15, 23);
            this.Rmin_increment_button.TabIndex = 87;
            this.Rmin_increment_button.Text = ">";
            this.Rmin_increment_button.UseVisualStyleBackColor = true;
            // 
            // Bmin_decrement_button
            // 
            this.Bmin_decrement_button.Location = new System.Drawing.Point(41, 95);
            this.Bmin_decrement_button.Name = "Bmin_decrement_button";
            this.Bmin_decrement_button.Size = new System.Drawing.Size(15, 23);
            this.Bmin_decrement_button.TabIndex = 86;
            this.Bmin_decrement_button.Text = "<";
            this.Bmin_decrement_button.UseVisualStyleBackColor = true;
            // 
            // Gmin_decrement_button
            // 
            this.Gmin_decrement_button.Location = new System.Drawing.Point(41, 66);
            this.Gmin_decrement_button.Name = "Gmin_decrement_button";
            this.Gmin_decrement_button.Size = new System.Drawing.Size(15, 23);
            this.Gmin_decrement_button.TabIndex = 85;
            this.Gmin_decrement_button.Text = "<";
            this.Gmin_decrement_button.UseVisualStyleBackColor = true;
            // 
            // searchB_checkBox
            // 
            this.searchB_checkBox.AutoSize = true;
            this.searchB_checkBox.Checked = true;
            this.searchB_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchB_checkBox.Location = new System.Drawing.Point(22, 99);
            this.searchB_checkBox.Name = "searchB_checkBox";
            this.searchB_checkBox.Size = new System.Drawing.Size(15, 14);
            this.searchB_checkBox.TabIndex = 79;
            this.searchB_checkBox.UseVisualStyleBackColor = true;
            // 
            // searchG_checkBox
            // 
            this.searchG_checkBox.AutoSize = true;
            this.searchG_checkBox.Checked = true;
            this.searchG_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchG_checkBox.Location = new System.Drawing.Point(22, 70);
            this.searchG_checkBox.Name = "searchG_checkBox";
            this.searchG_checkBox.Size = new System.Drawing.Size(15, 14);
            this.searchG_checkBox.TabIndex = 78;
            this.searchG_checkBox.UseVisualStyleBackColor = true;
            // 
            // searchR_checkBox
            // 
            this.searchR_checkBox.AutoSize = true;
            this.searchR_checkBox.Checked = true;
            this.searchR_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.searchR_checkBox.Location = new System.Drawing.Point(22, 41);
            this.searchR_checkBox.Name = "searchR_checkBox";
            this.searchR_checkBox.Size = new System.Drawing.Size(15, 14);
            this.searchR_checkBox.TabIndex = 77;
            this.searchR_checkBox.UseVisualStyleBackColor = true;
            // 
            // Rmin_decrement_button
            // 
            this.Rmin_decrement_button.Location = new System.Drawing.Point(41, 37);
            this.Rmin_decrement_button.Name = "Rmin_decrement_button";
            this.Rmin_decrement_button.Size = new System.Drawing.Size(15, 23);
            this.Rmin_decrement_button.TabIndex = 76;
            this.Rmin_decrement_button.Text = "<";
            this.Rmin_decrement_button.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "R";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "G";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "B";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(71, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "min";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(199, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "max";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rightPixelColor_button);
            this.groupBox3.Controls.Add(this.wrongPixelColor_button);
            this.groupBox3.Location = new System.Drawing.Point(46, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 83);
            this.groupBox3.TabIndex = 117;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pixels display";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 89;
            this.label1.Text = "Wrong pixel color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 88;
            this.label6.Text = "Right pixel color";
            // 
            // rightPixelColor_button
            // 
            this.rightPixelColor_button.BackColor = System.Drawing.Color.Black;
            this.rightPixelColor_button.Location = new System.Drawing.Point(149, 23);
            this.rightPixelColor_button.Name = "rightPixelColor_button";
            this.rightPixelColor_button.Size = new System.Drawing.Size(25, 25);
            this.rightPixelColor_button.TabIndex = 86;
            this.rightPixelColor_button.UseVisualStyleBackColor = false;
            this.rightPixelColor_button.Click += new System.EventHandler(this.rightPixelColor_button_Click);
            // 
            // wrongPixelColor_button
            // 
            this.wrongPixelColor_button.BackColor = System.Drawing.Color.White;
            this.wrongPixelColor_button.Location = new System.Drawing.Point(149, 52);
            this.wrongPixelColor_button.Name = "wrongPixelColor_button";
            this.wrongPixelColor_button.Size = new System.Drawing.Size(25, 25);
            this.wrongPixelColor_button.TabIndex = 87;
            this.wrongPixelColor_button.UseVisualStyleBackColor = false;
            this.wrongPixelColor_button.Click += new System.EventHandler(this.wrongPixelColor_button_Click);
            // 
            // Apply_button
            // 
            this.Apply_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Apply_button.Location = new System.Drawing.Point(74, 236);
            this.Apply_button.Name = "Apply_button";
            this.Apply_button.Size = new System.Drawing.Size(127, 24);
            this.Apply_button.TabIndex = 118;
            this.Apply_button.Text = "Apply";
            this.Apply_button.UseVisualStyleBackColor = true;
            this.Apply_button.Click += new System.EventHandler(this.Apply_button_Click);
            // 
            // GetPicture_openFileDialog
            // 
            this.GetPicture_openFileDialog.Filter = "Images|*.bmp;*.png;*.jpg;*.jpeg";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 605);
            this.Controls.Add(this.SetFiltredCanvas_button);
            this.Controls.Add(this.SetSimpleCanvas_button);
            this.Controls.Add(this.main_tabControl);
            this.Controls.Add(this.canvas_pictureBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas_pictureBox)).EndInit();
            this.main_tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutPicture_pictureBoxCanvas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox canvas_pictureBox;
        private TabControl main_tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button SetSimpleCanvas_button;
        private Button SetFiltredCanvas_button;
        private GroupBox groupBox5;
        private CheckBox drawFrame_checkBoxCanvas;
        private PictureBox cutPicture_pictureBoxCanvas;
        private Button cutPicture_buttonCanvas;
        private TextBox Size_X_textBoxCanvas;
        private Label label7;
        private TextBox Start_Y_textBoxCanvas;
        private TextBox Start_X_textBoxCanvas;
        private TextBox Size_Y_textBoxCanvas;
        private Label label3;
        private Label label5;
        private Label label2;
        private GroupBox groupBox1;
        private Button button5;
        private Button GetFromFile_ButtonCanvas;
        private Button TakeScreenshot_ButtonCanvas;
        private Button Apply_button;
        private GroupBox groupBox3;
        private Label label1;
        private Label label6;
        private Button rightPixelColor_button;
        private Button wrongPixelColor_button;
        private GroupBox groupBox4;
        private TextBox Rmax_textBox;
        private Button Bmax_increment_button;
        private TextBox Gmax_textBox;
        private TextBox Rmin_textBox;
        private TextBox Bmax_textBox;
        private Button Gmax_increment_button;
        private TextBox Gmin_textBox;
        private Button Rmax_increment_button;
        private TextBox Bmin_textBox;
        private Button Bmax_decrement_button;
        private Button Gmax_decrement_button;
        private Button Rmax_decrement_button;
        private Button Bmin_increment_button;
        private Button Gmin_increment_button;
        private Button Rmin_increment_button;
        private Button Bmin_decrement_button;
        private Button Gmin_decrement_button;
        private CheckBox searchB_checkBox;
        private CheckBox searchG_checkBox;
        private CheckBox searchR_checkBox;
        private Button Rmin_decrement_button;
        private Label label4;
        private Label label10;
        private Label label14;
        private Label label15;
        private Label label16;
        private OpenFileDialog GetPicture_openFileDialog;
        private ColorDialog rightPixelColor_colorDialog;
        private ColorDialog wrongPixelColor_colorDialog;
    }
}