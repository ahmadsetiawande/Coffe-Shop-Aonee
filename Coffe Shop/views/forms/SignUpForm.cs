using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coffe_Shop.Models;
using Coffe_Shop.Repo;
using Coffe_Shop.Repos;
using Coffe_Shop.Utilty;

namespace Coffe_Shop.views.forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var validation = new Validation();
                validation.isValidTexts(textUsername.Text, textPassword.Text);
                validation.isMatchText(textPassword.Text, textConfirmPassword.Text);


            var memberRepo = new MemberRepo();
                var member = new Member
                {
                    FullName = textName.Text,
                    Email = textEmail.Text,
                    Password = textPassword.Text,
                    Phone = textPhone.Text,
                    Username = textUsername.Text,
                    IsDeleted = "0",
                    LastUpdate = DateTime.Now,
                    Code = "MBR-" + Guid.NewGuid().ToString("N").Substring(0, 8)
                };

                var id = await memberRepo.CreateAsync(member);
                if (id > 0)
                {
                    MessageBox.Show("Sign up sucess");
                    this.Hide();
                    var form1 = new Form1();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Sign up failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
