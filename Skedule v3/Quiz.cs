using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Skedule_v3
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =skdl.accdb");

        OleDbCommand cmd = new OleDbCommand();

        OleDbDataAdapter adapter = new OleDbDataAdapter();

        DataTable dt;

        void fill_quiz()
        {
            try
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.16.0; Data Source =skdl.accdb");

                dt = new DataTable();


                adapter = new OleDbDataAdapter("SELECT * FROM quiz_table", conn);



                conn.Open();


                adapter.Fill(dt);


                dgw_quiz.DataSource = dt;


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string _subject=subjecttext.Text;
            string _quiz_date = dateTimePicker1.Text.ToString();
            string _room= roomtext.Text;
            string _time = timetext.Text;
            string _syllabus = syllabustext.Text;

            try
            {
                string t = "INSERT INTO quiz_table (subject1,quizdate1,roomno1,time1,syllabus1) VALUES" + "(@sub,@q_date,@room,@times,@syllabuss)";

                cmd = new OleDbCommand(t, conn);

                cmd.Parameters.AddWithValue("@sub", _subject);

                cmd.Parameters.AddWithValue("@q_date", _quiz_date);

                cmd.Parameters.AddWithValue("@room", _room);

                cmd.Parameters.AddWithValue("@times", _time);

                cmd.Parameters.AddWithValue("@syllabuss", _syllabus);




                conn.Open();


                cmd.ExecuteNonQuery();


                conn.Close();


                MessageBox.Show("Quiz/Exam date is set");


                fill_quiz();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            subjecttext.Clear();
            
            roomtext.Clear();
            timetext.Clear();
            syllabustext.Clear();

         
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            fill_quiz();
        }
    }
}
