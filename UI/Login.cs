using QuickBridge.Model;
using QuickBridge.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace QuickBridge
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            var loginModel = new LoginModel
            {
                Username = Username_txtbox.Text.Trim(),
                Password = Password_txtbox.Text.Trim()
            };
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(loginModel);
            bool isValid = Validator.TryValidateObject(loginModel, validationContext, validationResults, true);
            if (isValid)
            {
                DashBoard dashBoard = new DashBoard();
                dashBoard.Show();
                
            }
            else
            {
                //Show validation error
                string errorMessages = string.Join(Environment.NewLine, validationResults.Select(it => it.ErrorMessage));
                MessageBox.Show(errorMessages, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
