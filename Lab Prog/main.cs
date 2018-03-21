using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lab_Prog
{
    public partial class main : Form
    {

        List<TextBox> texts = new List<TextBox>();
        List<Label> labels = new List<Label>();
        Database database;
        DataTable users;
        DataTable docs;
        DataTable logs;

        DataTable find_logs;

        DateTime date;

        int left = 100;
        int height = 200;
        string filepath = "";

        Microsoft.Office.Interop.Word.Application win_word;
        Microsoft.Office.Interop.Word.Document document;
        SortedList<Int32, Microsoft.Office.Interop.Word.Bookmark> bookmarks;


        public main()
        {
            InitializeComponent();
            string source = Properties.Settings.Default.database;
            database = new Database(source);


            win_word = new Microsoft.Office.Interop.Word.Application();

            users = database.request("select * from users;");
            docs = database.request("select * from docs;");
            logs = database.request("select * from logs;");
            find_logs = logs;

            refresh_combobox();

            datagrid.DataSource = find_logs;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public void refresh_combobox()
        {
            users = database.request("select * from users;");
            docs = database.request("select * from docs;");
            logs = database.request("select * from logs;");
            find_logs = logs;

            refresh_users();
            refresh_research();
        }
        public void refresh_users()
        {
            find_name.Items.Clear();
            name_textbox.Items.Clear();
            users = database.request("select distinct name from logs;");
            foreach (DataRow dr in users.Rows)
            {
                find_name.Items.Add(dr["name"].ToString());
                name_textbox.Items.Add(dr["name"].ToString());
            }
        }
        public void refresh_research()
        {
            docs_combobox.Items.Clear();
            stat_doc.Items.Clear();
            stat_doc.Items.Add("");
            foreach (DataRow dr in docs.Rows)
            {
                docs_combobox.Items.Add(dr["name"].ToString());
                stat_doc.Items.Add(dr["name"].ToString());
            }
        }
        private void a_add_research_button_Click(object sender, EventArgs e)
        {
            string name = a_research_name_textbox.Text;
            filepath = "";
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "doc files (*.doc)|*.doc|All files (*.*)|*.*";
            openfile.FilterIndex = 1;
            openfile.RestoreDirectory = true;

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                filepath = openfile.FileName;
                database.exec(String.Format("insert into docs(name, filepath) values('{0}','{1}');",name,filepath));
                MessageBox.Show("Новый анализ добавлен");
            }

            refresh_combobox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string create_fileloc = saveFileDialog1.FileName;

                database.connection_close();
                database = new Database(create_fileloc);

                database.fill_empty();

                Properties.Settings.Default.database = create_fileloc;
                Properties.Settings.Default.Save();
                refresh_combobox();
                MessageBox.Show("База данных успешно создана");
            }
            refresh_combobox();
            refresh_datagrid();
        }
        public void clear_field()
        {
            foreach (TextBox textbox in texts)
            {
                this.Controls.Remove(textbox);
                textbox.Dispose();
            }
            texts = new List<TextBox>();
            foreach (Label label in labels)
            {
                this.Controls.Remove(label);
                label.Dispose();
            }
            labels = new List<Label>();
        }
        private void docs_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {


            filepath = "";

            foreach (DataRow dr in docs.Rows)
            {
                if (dr["name"].ToString() == docs_combobox.Text)
                {
                    filepath = dr["filepath"].ToString();
                }
            }
            open_file(filepath);
        }
        public void open_file(string file_path){
            clear_field();

            height = 150;
            left = 0;

            object missing = System.Reflection.Missing.Value;
            try
            {
                document = win_word.Documents.Add(file_path, false, ref missing, ref missing);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            bookmarks = new SortedList<Int32,Microsoft.Office.Interop.Word.Bookmark>();
            foreach (Microsoft.Office.Interop.Word.Bookmark bookmark in document.Bookmarks)
            {
                bookmarks.Add(bookmark.Start, bookmark);

            }
            for (int i = 0; i < bookmarks.Count; i++)
            {
                new_text(bookmarks.Values[i].Name,bookmarks.Values[i].Range.Text);
            }

            autofill_name();
            document.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges, ref missing, ref missing);
            document = null;


            date = DateTime.Now;
        }
        public void coord_shift()
        {
            left += 550;
            height = 150;
        }
        public void autofill_date(TextBox text_box, String text)
        {
            if (text == "Дата_день")
            {
                text_box.Text = DateTime.Now.Day.ToString();
            }
            if (text == "Дата_месяц")
            {
                text_box.Text = DateTime.Now.Month.ToString();
            }
            if (text == "Дата_год")
            {
                text_box.Text = DateTime.Now.Year.ToString();
            }
        }
        public void autofill_name()
        {
            if (docs_combobox.SelectedIndex >=0)
            {
                for (int i = 0; i < labels.Count; i++)
                {
                    if (labels[i].Text == "ФИО")
                    {
                        texts[i].Text = name_textbox.Text;
                    }
                    if (labels[i].Text == "Дата_рождения")
                    {
                        texts[i].Text = bd_textbox.Text;
                    }
                }
            }
        }
        public void add_event_listener(Control field, string name)
        {
            if(name == "ФИО")
            {
                field.TextChanged += new System.EventHandler(change_name);
            }
            if (name == "Дата_рождения")
            {
                field.TextChanged += new System.EventHandler(change_date);
            }
        }
        public void change_name(object sender, EventArgs e)
        {
            TextBox textfield = sender as TextBox;
            name_textbox.Text = textfield.Text;
        }
        public void change_date(object sender, EventArgs e)
        {
            TextBox textfield = sender as TextBox;
            bd_textbox.Text = textfield.Text;
        }
        public void new_text(string name,string text)
        {
            if (((labels.Count % 20) == 0) & (labels.Count > 0))
            {
                coord_shift();
            }
            TextBox new_text = new TextBox();
            new_text.Location = new System.Drawing.Point(left + 10, height);
            new_text.Text = text;
            add_event_listener(new_text, name);
            autofill_date(new_text,name);

            texts.Add(new_text);

            main_tab.Controls.Add(new_text);

            Label new_label = new Label();
            new_label.Location = new System.Drawing.Point(left + 130, height);
            new_label.Text = name;
            new_label.AutoSize = true;



            labels.Add(new_label);
            main_tab.Controls.Add(new_label);


            height += 30;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            object missing = System.Reflection.Missing.Value;
            document = win_word.Documents.Add(filepath, false, ref missing, ref missing);

            for (int i = 0; i < labels.Count; i++)
            {
                string book_name = labels[i].Text;
                string book_value = texts[i].Text;

                document.Bookmarks[book_name].Select();
                win_word.Selection.TypeText(book_value);
            }

            object copies = "1";
            object pages = "";
            object range = Microsoft.Office.Interop.Word.WdPrintOutRange.wdPrintAllDocument;
            object items = Microsoft.Office.Interop.Word.WdPrintOutItem.wdPrintDocumentContent;
            object pageType = Microsoft.Office.Interop.Word.WdPrintOutPages.wdPrintAllPages;
            object oTrue = true;
            object oFalse = false;

            document.PrintOut(ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);

            document.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges, ref missing, ref missing);
            document = null;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            try { win_word.Quit(); } catch { }
            win_word = null;
            Application.Exit();
        }
        private void fill_date()
        {
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;
            for (int i = 0; i< labels.Count; i++)
            {
                if (labels[i].Text == "Дата_день")
                {
                    day = Convert.ToInt32(texts[i].Text);
                }
                if (labels[i].Text == "Дата_месяц")
                {
                    month = Convert.ToInt32(texts[i].Text);
                }
                if (labels[i].Text == "Дата_год")
                {
                    year = Convert.ToInt32(texts[i].Text);
                }
            }
            date = new DateTime(year, month, day);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string name = name_textbox.Text.ToUpperInvariant();
            string bd = bd_textbox.Text;
            string result = "";
            fill_date();
            foreach(TextBox text in texts)
            {
                result += text.Text;
                result += "|";
            }
            database.exec(String.Format("insert into logs(date,bd,name,type,result) values('{0}','{1}','{2}','{3}','{4}');",date.ToShortDateString(),bd,name,docs_combobox.Text,result));
            refresh_datagrid();
            refresh_combobox();
            MessageBox.Show("Запись добавлена");
        }

        private void advanced_tab_Click(object sender, EventArgs e)
        {

        }
        public void refresh_datagrid()
        {
            string name = find_name.Text;
            string bd = find_bd.Text;
            string doc = stat_doc.Text;
            find_logs.Clear();
            if (doc == "")
            {
               
                find_logs = database.request(String.Format("select * from logs where name like '%{0}%' and bd like '%{1}%';", name.ToUpperInvariant(), bd));
                datagrid.DataSource = find_logs;

            }
            else
            {
                find_logs= database.request(String.Format("select * from logs where name like '%{0}%' and bd like '%{1}%' and type like '%{2}%';", name.ToUpperInvariant(), bd,doc));
                DataTable data = new DataTable();
                DataColumn column;
                DataRow row;

                filepath = "";
                foreach (DataRow dr in docs.Rows)
                {
                    if (dr["name"].ToString() == doc)
                    {
                        filepath = dr["filepath"].ToString();
                    }
                }

                column = new DataColumn();
                column.ColumnName = "id";
                data.Columns.Add(column);

                column = new DataColumn();
                column.ColumnName = "Дата";
                data.Columns.Add(column);

                object missing = System.Reflection.Missing.Value;
                try
                {
                    document = win_word.Documents.Add(filepath, false, ref missing, ref missing);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                bookmarks = new SortedList<Int32, Microsoft.Office.Interop.Word.Bookmark>();
                foreach (Microsoft.Office.Interop.Word.Bookmark bookmark in document.Bookmarks)
                {
                    bookmarks.Add(bookmark.Start, bookmark);
                }
                for (int i = 0; i < bookmarks.Count; i++)
                {
                    column = new DataColumn();
                    column.ColumnName = bookmarks.Values[i].Name;
                    data.Columns.Add(column);
                }
                int k = 0;
                foreach (DataRow dr in find_logs.Rows)
                {
                    row = data.NewRow();
                    string date_str = dr["date"].ToString();
                    DateTime date = Convert.ToDateTime(date_str);
                    
                    string result = dr["result"].ToString();
                    string[] values = result.Split('|');
                    row[0] = k;
                    k++;
                    row[1] = date.ToString("yyyy.MM.dd");
                    for (int i = 0; i < values.Length-1; i++)
                    {
                        row[i+2] = values[i];
                    }
                    data.Rows.Add(row);

                    
                }

                datagrid.DataSource = data;
                datagrid.Columns[0].Visible = false;
            }

            datagrid.Refresh();
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void find_name_TextChanged(object sender, EventArgs e)
        {
            refresh_datagrid();
        }

        private void find_bd_TextChanged(object sender, EventArgs e)
        {
            refresh_datagrid();
        }

        private void open_report_Click(object sender, EventArgs e)
        {
            int ind = 0;
            if (stat_doc.Text != "")
            {
                ind = Convert.ToInt32(datagrid.CurrentRow.Cells[0].Value);
            }
            else
            {
                ind = datagrid.CurrentCell.RowIndex;
            }
            string result = find_logs.Rows[ind]["result"].ToString();
            string type = find_logs.Rows[ind]["type"].ToString();
            filepath = "";
            foreach (DataRow dr in docs.Rows)
            {
                if (dr["name"].ToString()==type)
                {
                    filepath = dr["filepath"].ToString();
                }
            }
            open_file(filepath);
            tabControl1.SelectedIndex = 0;
            string[] values = result.Split('|');
            for(int i = 0; i < texts.Count; i++)
            {
                texts[i].Text = values[i];
            }
        }
        
        private void bd_textbox_TextChanged(object sender, EventArgs e)
        {
            autofill_name();
        }

        private void name_textbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            autofill_name();
        }

        private void find_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void stat_doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_datagrid();
        }
    }
}
