namespace Lab_Prog
{
    partial class main
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
            this.advanced_tab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a_add_research_button = new System.Windows.Forms.Button();
            this.a_research_name_textbox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stat_doc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.open_report = new System.Windows.Forms.Button();
            this.find_bd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.find_name = new System.Windows.Forms.ComboBox();
            this.main_tab = new System.Windows.Forms.TabPage();
            this.name_textbox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bd_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.docs_combobox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.advanced_tab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.main_tab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // advanced_tab
            // 
            this.advanced_tab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.advanced_tab.Controls.Add(this.groupBox2);
            this.advanced_tab.Controls.Add(this.groupBox1);
            this.advanced_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advanced_tab.Location = new System.Drawing.Point(4, 38);
            this.advanced_tab.Margin = new System.Windows.Forms.Padding(2);
            this.advanced_tab.Name = "advanced_tab";
            this.advanced_tab.Padding = new System.Windows.Forms.Padding(2);
            this.advanced_tab.Size = new System.Drawing.Size(1315, 642);
            this.advanced_tab.TabIndex = 1;
            this.advanced_tab.Text = "Настройки";
            this.advanced_tab.Click += new System.EventHandler(this.advanced_tab_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(7, 201);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(431, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "новая база";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Новая база данных";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 67);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.a_add_research_button);
            this.groupBox1.Controls.Add(this.a_research_name_textbox);
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(431, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новый анализ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название анализа";
            // 
            // a_add_research_button
            // 
            this.a_add_research_button.Location = new System.Drawing.Point(27, 112);
            this.a_add_research_button.Margin = new System.Windows.Forms.Padding(2);
            this.a_add_research_button.Name = "a_add_research_button";
            this.a_add_research_button.Size = new System.Drawing.Size(148, 50);
            this.a_add_research_button.TabIndex = 0;
            this.a_add_research_button.Text = "Добавить";
            this.a_add_research_button.UseVisualStyleBackColor = true;
            this.a_add_research_button.Click += new System.EventHandler(this.a_add_research_button_Click);
            // 
            // a_research_name_textbox
            // 
            this.a_research_name_textbox.Location = new System.Drawing.Point(27, 70);
            this.a_research_name_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.a_research_name_textbox.Name = "a_research_name_textbox";
            this.a_research_name_textbox.Size = new System.Drawing.Size(371, 31);
            this.a_research_name_textbox.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.stat_doc);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.open_report);
            this.tabPage1.Controls.Add(this.find_bd);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.datagrid);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.find_name);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1315, 642);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Открыть анализ";
            // 
            // stat_doc
            // 
            this.stat_doc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stat_doc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stat_doc.FormattingEnabled = true;
            this.stat_doc.Location = new System.Drawing.Point(8, 245);
            this.stat_doc.Name = "stat_doc";
            this.stat_doc.Size = new System.Drawing.Size(256, 37);
            this.stat_doc.TabIndex = 8;
            this.stat_doc.SelectedIndexChanged += new System.EventHandler(this.stat_doc_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Анализ";
            // 
            // open_report
            // 
            this.open_report.Location = new System.Drawing.Point(14, 540);
            this.open_report.Name = "open_report";
            this.open_report.Size = new System.Drawing.Size(256, 59);
            this.open_report.TabIndex = 5;
            this.open_report.Text = "Открыть анализ";
            this.open_report.UseVisualStyleBackColor = true;
            this.open_report.Click += new System.EventHandler(this.open_report_Click);
            // 
            // find_bd
            // 
            this.find_bd.Location = new System.Drawing.Point(8, 138);
            this.find_bd.Name = "find_bd";
            this.find_bd.Size = new System.Drawing.Size(256, 35);
            this.find_bd.TabIndex = 4;
            this.find_bd.TextChanged += new System.EventHandler(this.find_bd_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Дата рождения";
            // 
            // datagrid
            // 
            this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(286, 18);
            this.datagrid.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(1021, 581);
            this.datagrid.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "ФИО пациента";
            // 
            // find_name
            // 
            this.find_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.find_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.find_name.FormattingEnabled = true;
            this.find_name.Location = new System.Drawing.Point(8, 50);
            this.find_name.Name = "find_name";
            this.find_name.Size = new System.Drawing.Size(256, 37);
            this.find_name.TabIndex = 0;
            this.find_name.SelectedIndexChanged += new System.EventHandler(this.find_name_SelectedIndexChanged);
            this.find_name.TextChanged += new System.EventHandler(this.find_name_TextChanged);
            // 
            // main_tab
            // 
            this.main_tab.BackColor = System.Drawing.Color.PaleTurquoise;
            this.main_tab.Controls.Add(this.name_textbox);
            this.main_tab.Controls.Add(this.button3);
            this.main_tab.Controls.Add(this.label4);
            this.main_tab.Controls.Add(this.label3);
            this.main_tab.Controls.Add(this.label2);
            this.main_tab.Controls.Add(this.bd_textbox);
            this.main_tab.Controls.Add(this.button1);
            this.main_tab.Controls.Add(this.docs_combobox);
            this.main_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_tab.Location = new System.Drawing.Point(4, 38);
            this.main_tab.Margin = new System.Windows.Forms.Padding(2);
            this.main_tab.Name = "main_tab";
            this.main_tab.Padding = new System.Windows.Forms.Padding(2);
            this.main_tab.Size = new System.Drawing.Size(1315, 642);
            this.main_tab.TabIndex = 0;
            this.main_tab.Text = "Анализы";
            // 
            // name_textbox
            // 
            this.name_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.name_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.name_textbox.FormattingEnabled = true;
            this.name_textbox.Location = new System.Drawing.Point(313, 38);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(206, 33);
            this.name_textbox.TabIndex = 8;
            this.name_textbox.SelectedIndexChanged += new System.EventHandler(this.name_textbox_SelectedIndexChanged);
            this.name_textbox.TextChanged += new System.EventHandler(this.name_textbox_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(905, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 61);
            this.button3.TabIndex = 7;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Анализ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ФИО пациента";
            // 
            // bd_textbox
            // 
            this.bd_textbox.Location = new System.Drawing.Point(550, 38);
            this.bd_textbox.Name = "bd_textbox";
            this.bd_textbox.Size = new System.Drawing.Size(133, 31);
            this.bd_textbox.TabIndex = 3;
            this.bd_textbox.TextChanged += new System.EventHandler(this.bd_textbox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Location = new System.Drawing.Point(749, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Печать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // docs_combobox
            // 
            this.docs_combobox.FormattingEnabled = true;
            this.docs_combobox.Location = new System.Drawing.Point(18, 36);
            this.docs_combobox.Name = "docs_combobox";
            this.docs_combobox.Size = new System.Drawing.Size(279, 33);
            this.docs_combobox.TabIndex = 0;
            this.docs_combobox.SelectedIndexChanged += new System.EventHandler(this.docs_combobox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.main_tab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.advanced_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1323, 684);
            this.tabControl1.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 684);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main";
            this.Text = "main";
            this.advanced_tab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.main_tab.ResumeLayout(false);
            this.main_tab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage advanced_tab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button a_add_research_button;
        private System.Windows.Forms.TextBox a_research_name_textbox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button open_report;
        private System.Windows.Forms.TextBox find_bd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox find_name;
        private System.Windows.Forms.TabPage main_tab;
        private System.Windows.Forms.ComboBox name_textbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bd_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox docs_combobox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox stat_doc;
    }
}