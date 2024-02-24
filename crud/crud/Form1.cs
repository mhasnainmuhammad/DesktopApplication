using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            loginform umer = new loginform();
            umer.Show();

            this.Hide();
        }

        private void connection_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=crud2212E1;User ID=sa;Password=aptech");
                connection.Open();
                MessageBox.Show("DB CONNECT");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void REG_Click(object sender, EventArgs e)
        {
            string user_enter_name = name.Text;
            string user_enter_email = USEREAMIL.Text;
            string user_enter_password = USERPASSWORD.Text;

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=crud2212E1;User ID=sa;Password=aptech");
                connection.Open();
                MessageBox.Show("chal gaya bhai");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
               

            }
            MessageBox.Show("the name is " + user_enter_name + "and email is" + user_enter_email);
        }
    }
}