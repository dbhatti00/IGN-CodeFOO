using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace IGN
{
    public partial class SearchForm : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public SearchForm()
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
            BranchesList("select * from ID");
        }

        private void BranchesList(string command)
        /*Populates list view with branch information*/
        {
            myCommand.CommandText = "select * from CSVInfo";
            try
            {
                myReader = myCommand.ExecuteReader();
                listView1.Items.Clear();


                while (myReader.Read())
                {
                    ListViewItem item = new ListViewItem(myReader["ID"].ToString());
                    item.SubItems.Add(myReader["MediaType"].ToString());
                    item.SubItems.Add(myReader["Name"].ToString());
                    item.SubItems.Add(myReader["ShortName"].ToString());
                    item.SubItems.Add(myReader["LongDes"].ToString());
                    item.SubItems.Add(myReader["ShortDes"].ToString());
                    item.SubItems.Add(myReader["CreatedAt"].ToString());
                    item.SubItems.Add(myReader["UpdatedAt"].ToString());
                    item.SubItems.Add(myReader["ReviewURL"].ToString());
                    item.SubItems.Add(myReader["ReviewScore"].ToString());
                    item.SubItems.Add(myReader["Slug"].ToString());
                    item.SubItems.Add(myReader["Genres"].ToString());
                    item.SubItems.Add(myReader["CreatedBy"].ToString());
                    item.SubItems.Add(myReader["PublishedBy"].ToString());
                    item.SubItems.Add(myReader["Franchises"].ToString());
                    item.SubItems.Add(myReader["Regions"].ToString());
                    listView1.Items.Add(item);

                }
                myReader.Close();
            }
            catch (Exception e6)
            {
                MessageBox.Show(e6.ToString(), "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                BranchesList("select * from ID");
            }
            else
            {
                if (comboBox1.SelectedItem.ToString() == null)
                {
                    return;
                }
                else if (comboBox1.SelectedItem.ToString() == "ID")
                {
                    int parsedValue;
                    if (!int.TryParse(textBox1.Text, out parsedValue))
                    {
                        MessageBox.Show("ERROR: Please Enter a Number");
                        return;
                    }
                    else
                    {
                        myCommand.CommandText = "select * from CSVInfo where ID ='" + textBox1.Text + "'";

                        try
                        {
                            myReader = myCommand.ExecuteReader();
                            listView1.Items.Clear();


                            while (myReader.Read())
                            {
                                ListViewItem item = new ListViewItem(myReader["ID"].ToString());
                                item.SubItems.Add(myReader["MediaType"].ToString());
                                item.SubItems.Add(myReader["Name"].ToString());
                                item.SubItems.Add(myReader["ShortName"].ToString());
                                item.SubItems.Add(myReader["LongDes"].ToString());
                                item.SubItems.Add(myReader["ShortDes"].ToString());
                                item.SubItems.Add(myReader["CreatedAt"].ToString());
                                item.SubItems.Add(myReader["UpdatedAt"].ToString());
                                item.SubItems.Add(myReader["ReviewURL"].ToString());
                                item.SubItems.Add(myReader["ReviewScore"].ToString());
                                item.SubItems.Add(myReader["Slug"].ToString());
                                item.SubItems.Add(myReader["Genres"].ToString());
                                item.SubItems.Add(myReader["CreatedBy"].ToString());
                                item.SubItems.Add(myReader["PublishedBy"].ToString());
                                item.SubItems.Add(myReader["Franchises"].ToString());
                                item.SubItems.Add(myReader["Regions"].ToString());
                                listView1.Items.Add(item);

                            }
                            myReader.Close();
                        }
                        catch (Exception e6)

                        {
                            MessageBox.Show(e6.ToString(), "Error");
                        }
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "Media Type")
                {
                    myCommand.CommandText = "select * from CSVInfo where MediaType ='" + textBox1.Text + "'";

                    try
                    {
                        myReader = myCommand.ExecuteReader();

                        listView1.Items.Clear();


                        while (myReader.Read())
                        {
                            ListViewItem item = new ListViewItem(myReader["ID"].ToString());
                            item.SubItems.Add(myReader["MediaType"].ToString());
                            item.SubItems.Add(myReader["Name"].ToString());
                            item.SubItems.Add(myReader["ShortName"].ToString());
                            item.SubItems.Add(myReader["LongDes"].ToString());
                            item.SubItems.Add(myReader["ShortDes"].ToString());
                            item.SubItems.Add(myReader["CreatedAt"].ToString());
                            item.SubItems.Add(myReader["UpdatedAt"].ToString());
                            item.SubItems.Add(myReader["ReviewURL"].ToString());
                            item.SubItems.Add(myReader["ReviewScore"].ToString());
                            item.SubItems.Add(myReader["Slug"].ToString());
                            item.SubItems.Add(myReader["Genres"].ToString());
                            item.SubItems.Add(myReader["CreatedBy"].ToString());
                            item.SubItems.Add(myReader["PublishedBy"].ToString());
                            item.SubItems.Add(myReader["Franchises"].ToString());
                            item.SubItems.Add(myReader["Regions"].ToString());
                            listView1.Items.Add(item);

                        }
                        myReader.Close();
                    }
                    catch (Exception e6)
                    {
                        MessageBox.Show(e6.ToString(), "Error");
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "Name")
                {
                    myCommand.CommandText = "select * from CSVInfo where Name ='" + textBox1.Text + "'";

                    try
                    {
                        myReader = myCommand.ExecuteReader();

                        listView1.Items.Clear();


                        while (myReader.Read())
                        {
                            ListViewItem item = new ListViewItem(myReader["ID"].ToString());
                            item.SubItems.Add(myReader["MediaType"].ToString());
                            item.SubItems.Add(myReader["Name"].ToString());
                            item.SubItems.Add(myReader["ShortName"].ToString());
                            item.SubItems.Add(myReader["LongDes"].ToString());
                            item.SubItems.Add(myReader["ShortDes"].ToString());
                            item.SubItems.Add(myReader["CreatedAt"].ToString());
                            item.SubItems.Add(myReader["UpdatedAt"].ToString());
                            item.SubItems.Add(myReader["ReviewURL"].ToString());
                            item.SubItems.Add(myReader["ReviewScore"].ToString());
                            item.SubItems.Add(myReader["Slug"].ToString());
                            item.SubItems.Add(myReader["Genres"].ToString());
                            item.SubItems.Add(myReader["CreatedBy"].ToString());
                            item.SubItems.Add(myReader["PublishedBy"].ToString());
                            item.SubItems.Add(myReader["Franchises"].ToString());
                            item.SubItems.Add(myReader["Regions"].ToString());
                            listView1.Items.Add(item);

                        }
                        myReader.Close();
                    }
                    catch (Exception e6)
                    {
                        MessageBox.Show(e6.ToString(), "Error");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                BranchesList("select * from ID");
            }
            else
            {
                if (comboBox2.SelectedItem.ToString() == null)
                {
                    return;
                }
                else if (comboBox2.SelectedItem.ToString() == "Show Entries with Scores Higher Than")
                {
                    int parsedValue;
                    if (!int.TryParse(textBox2.Text, out parsedValue))
                    {
                        MessageBox.Show("ERROR: Please Enter a Number");
                        return;
                    }
                    else
                    {
                        myCommand.CommandText = "select * from CSVInfo where ReviewScore >'" + textBox2.Text + "'";

                        try
                        {
                            myReader = myCommand.ExecuteReader();
                            listView1.Items.Clear();


                            while (myReader.Read())
                            {
                                ListViewItem item = new ListViewItem(myReader["ID"].ToString());
                                item.SubItems.Add(myReader["MediaType"].ToString());
                                item.SubItems.Add(myReader["Name"].ToString());
                                item.SubItems.Add(myReader["ShortName"].ToString());
                                item.SubItems.Add(myReader["LongDes"].ToString());
                                item.SubItems.Add(myReader["ShortDes"].ToString());
                                item.SubItems.Add(myReader["CreatedAt"].ToString());
                                item.SubItems.Add(myReader["UpdatedAt"].ToString());
                                item.SubItems.Add(myReader["ReviewURL"].ToString());
                                item.SubItems.Add(myReader["ReviewScore"].ToString());
                                item.SubItems.Add(myReader["Slug"].ToString());
                                item.SubItems.Add(myReader["Genres"].ToString());
                                item.SubItems.Add(myReader["CreatedBy"].ToString());
                                item.SubItems.Add(myReader["PublishedBy"].ToString());
                                item.SubItems.Add(myReader["Franchises"].ToString());
                                item.SubItems.Add(myReader["Regions"].ToString());
                                listView1.Items.Add(item);

                            }
                            myReader.Close();
                        }
                        catch (Exception e6)

                        {
                            MessageBox.Show(e6.ToString(), "Error");
                        }
                    }
                }
                else if (comboBox2.SelectedItem.ToString() == "Show Entries with Scores Lower Than")
                {
                    int parsedValue;
                    if (!int.TryParse(textBox2.Text, out parsedValue))
                    {
                        MessageBox.Show("ERROR: Please Enter a Number");
                        return;
                    }
                    else
                    {
                        myCommand.CommandText = "select * from CSVInfo where ReviewScore <'" + textBox2.Text + "'";

                        try
                        {
                            myReader = myCommand.ExecuteReader();
                            listView1.Items.Clear();


                            while (myReader.Read())
                            {
                                ListViewItem item = new ListViewItem(myReader["ID"].ToString());
                                item.SubItems.Add(myReader["MediaType"].ToString());
                                item.SubItems.Add(myReader["Name"].ToString());
                                item.SubItems.Add(myReader["ShortName"].ToString());
                                item.SubItems.Add(myReader["LongDes"].ToString());
                                item.SubItems.Add(myReader["ShortDes"].ToString());
                                item.SubItems.Add(myReader["CreatedAt"].ToString());
                                item.SubItems.Add(myReader["UpdatedAt"].ToString());
                                item.SubItems.Add(myReader["ReviewURL"].ToString());
                                item.SubItems.Add(myReader["ReviewScore"].ToString());
                                item.SubItems.Add(myReader["Slug"].ToString());
                                item.SubItems.Add(myReader["Genres"].ToString());
                                item.SubItems.Add(myReader["CreatedBy"].ToString());
                                item.SubItems.Add(myReader["PublishedBy"].ToString());
                                item.SubItems.Add(myReader["Franchises"].ToString());
                                item.SubItems.Add(myReader["Regions"].ToString());
                                listView1.Items.Add(item);

                            }
                            myReader.Close();
                        }
                        catch (Exception e6)

                        {
                            MessageBox.Show(e6.ToString(), "Error");
                        }
                    }
                }
            }
        }
    }
}