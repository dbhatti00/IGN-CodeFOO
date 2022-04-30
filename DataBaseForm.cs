using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Data.SqlClient;
namespace IGN
{
    public partial class DataBaseForm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        Thread th;
        public DataBaseForm()
        {
            InitializeComponent();
           
            
            String connectionString = $"Data Source=JAZZY\\ALEX;Initial Catalog=IGNDataBase;User ID=ignlogin;Password=ign;";

            SqlConnection myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error);");
                this.Close();
            }
            

        }
        
            private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();


        }

        private void opennewform(object obj)
        {
            Application.Run(new IntroForm());

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("2");
                dt.Columns.Add("3");
                dt.Columns.Add("4");
                dt.Columns.Add("5");
                dt.Columns.Add("6");
                dt.Columns.Add("7");
                dt.Columns.Add("8");
                dt.Columns.Add("9");
                dt.Columns.Add("10");
                dt.Columns.Add("11");
                dt.Columns.Add("12");
                dt.Columns.Add("13");
                dt.Columns.Add("14");
                dt.Columns.Add("15");
                dt.Columns.Add("16");
                
                using (TextFieldParser csvReader = new TextFieldParser(openFileDialog1.FileName))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                       
                        dt.Rows.Add(fieldData);
                        
                    }
                }
                datatable.DataSource = dt;
            }
            textBox1.Clear();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "delete from CSVInfo ";
            myCommand.ExecuteNonQuery();
            try
            {
                DataTable dtItem = (DataTable)(datatable.DataSource);
                
                string ID, MediaType, Name, ShortName, LongDes, ShortDes, CreateAt, UpdatedAt, ReviewURL, ReviewScore, Slug, Genres, CreatedBy, PublishedBy, Franchises, Regions;
                string InsertItemQry = "";
                int count = 0;
                foreach (DataRow dr in dtItem.Rows)
                {
                    ID = Convert.ToString(dr["ID"]);
                    MediaType = Convert.ToString(dr["2"]);
                    Name = Convert.ToString(dr["3"]);
                    ShortName = Convert.ToString(dr["4"]);
                    LongDes = Convert.ToString(dr["5"]);
                    ShortDes = Convert.ToString(dr["6"]);
                    CreateAt = Convert.ToString(dr["7"]);
                    UpdatedAt = Convert.ToString(dr["8"]);
                    ReviewURL = Convert.ToString(dr["9"]);
                    ReviewScore = Convert.ToString(dr["10"]);
                    Slug = Convert.ToString(dr["11"]);
                    Genres = Convert.ToString(dr["12"]);
                    CreatedBy = Convert.ToString(dr["13"]);
                    PublishedBy = Convert.ToString(dr["14"]);
                    Franchises = Convert.ToString(dr["15"]);
                    Regions = Convert.ToString(dr["16"]);
                    if (ID != "" && MediaType != "" && Name != "" && ShortName != "")
                    {
                        
                        myCommand.CommandText = "Insert into CSVInfo values('" + ID.ToString() + "','" + MediaType.ToString() + "','" + Name.ToString() + "','" + "Temp" + "','" + "Temp" +
                           "','" + "temp" + "','" + CreateAt.ToString() + "','" + UpdatedAt.ToString() + "','" + "Temp" + "','" + ReviewScore.ToString() + "','" + "Temp" + "','" + Genres.ToString() + "','"
                            + CreatedBy.ToString() + "','" + PublishedBy.ToString() + "','" + Franchises.ToString() + "','" + Regions.ToString() + "')";
                        myCommand.ExecuteNonQuery();
                        

                        count++;
                    }
                }
                MessageBox.Show("CSV inputed into DataBase");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }
       
    
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchForm f2 = new SearchForm();
            f2.ShowDialog(); // Shows Form2
        }
    }
    }

