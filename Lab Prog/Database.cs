using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Lab_Prog
{
    class Database
    {

        string data_source = "";
        SQLiteConnection connection;
        string create_fileloc = "";
        public Database(string source)
        {

            data_source = source;

            if (source == "new")
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    create_fileloc = saveFileDialog1.FileName;
                }
                data_source = create_fileloc;
                Properties.Settings.Default.database = create_fileloc;
                Properties.Settings.Default.Save();
                fill_empty();
                MessageBox.Show("База данных успешно создана");
            }
            this.connection_open();
        }

        public void connection_open()
        {
            try
            {
                connection = new SQLiteConnection(String.Format("Data Source={0};", data_source));
                connection.Open();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void connection_close()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public DataTable request(string request_message)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(request_message, connection);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                cmd.CommandType = CommandType.Text;
                da.Fill(dt);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            return dt;
        }

        public void exec(string request_message)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(request_message, connection);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void fill_empty()
        {
            this.exec("create table if not exists users (name text, bd text);");
            this.exec("create table if not exists docs (name text, filepath text);");
            this.exec("create table if not exists logs (date text, name text, bd text, type text, result text);");
        }
    }
}
