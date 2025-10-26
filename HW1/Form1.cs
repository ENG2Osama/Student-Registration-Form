using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate Name 
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required!", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // Validate Email (Basic Email Format Check) 
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid email address!", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Validate Password (Min 6 characters) 
            if (txtPassword.Text.Length < 6)
            {
                
                MessageBox.Show("Password must be at least 6 characters!",
"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Validate Gender Selection 
            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("Please select a gender!", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Country Selection 
            if (cmbCountry.SelectedItem == null)
            {
                MessageBox.Show("Please select a country!", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCountry.Focus();
                return;
            }

            // Validate Favorite Color Selection 
            if (lblSelectColor.Text == "No Color Selected")
            {
                MessageBox.Show("Please select your favorite color!"); 
                return;
            }

            // All validations passed → Proceed with displaying data 
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            
string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ?
"Female" : "Other";
            string birthdate = dtpBirthate.Value.ToShortDateString();
            string country = cmbCountry.SelectedItem.ToString();
            string color = lblSelectColor.Text.Replace("Selected Color: ", ""); 


  string result= $"Name: {name}\nEmail: {email}\nGender: {gender}\n" +
$"Birthdate: {birthdate}\nCountry: {country}\nFavorite Color:{ color}";
            btnReset.Text = result;
            MessageBox.Show(result);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Collecting input values 
            string name = lblName.Text;
            string email = lblEmail.Text;
            string password =lblPassword.Text;
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ?
        "Female" : "Other";
            string Martil = rdoMarried.Checked ? "Male" : rdosingle.Checked ?
      "Female" : "Other";
            string birthdate = dtpBirthate.Value.ToShortDateString();
            string country = cmbCountry.SelectedItem?.ToString() ?? "Not Selected";
            string color = lblSelectColor.Text.Replace("Selected Color: ", ""); // 

            // Display result 
            btnReset.Text = $"Name: {name}\nEmail: {email}\nGender: {gender}\n" +
                             $"Birthdate: {birthdate}\nCountry: {country}\nFavorite Color: {color}\n Marital Status: {Martil}" ;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lblSelectColor.Text = colorDialog.Color.Name;
            }

        }
       
        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
          
txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
          
            rdoMale.Checked = false;
            
    rdoFemale.Checked = false;
        

        
            cmbCountry.SelectedIndex = -1;
 
            dtpBirthate.Value = DateTime.Now;
          
            
            lblSelectColor.Text = "No Color Selected";

         

        
            txtName.Focus();
        }
    }
}