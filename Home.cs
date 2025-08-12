using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csharp_Students_Management.Students_Components;
namespace Csharp_Students_Management
{
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            //Initial validations
            if(namebox.Text == "")
            {
                nameprob.SetError(namebox, "Please enter your name");
            }
            if(surnamebox.Text == "")
            {
                surnameprob.SetError(surnamebox, "Please enter your surname");
            }
            if(agecombo.Text == "")
            {
                ageprob.SetError(agecombo, "Please select your age");
            }
            if(emailbox.Text == "")
            {
                mailprob.SetError(emailbox, "Please enter your email");
            }
            if(passwordbox.Text == "")
            {
                passwordprob.SetError(passwordbox, "Please enter your password");
            }
            if(citycombo.Text == "")
            {
                cityprob.SetError(citycombo, "Please select your city");
            }
            if(addressbox.Text == "")
            {
                addressprob.SetError(addressbox, "Please enter your address");
            }
            if (monthCalendar1.Text == null)
            {
                birthprob.SetError(monthCalendar1, "Please enter your birth date");
            }
            //If all validations are passed, proceed to the password validation

            if (!emailbox.Text.Contains("@"))
            {
                mailprob.SetError(emailbox, "Please enter a valid email address with @");
            }
            if (!((passwordbox.Text.Length < 6) && (passwordbox.Text.Length>50)))
            {
                passwordprob.SetError(passwordbox, "Password must be at least 6 characters long");
            }
            int numberCount = 0;
            int upperCount = 0;
            int punctuationCount = 0;
            foreach (char caracter in passwordbox.Text)
            {
                if(char.IsDigit(caracter))
                {
                    numberCount++;
                }
                if (char.IsUpper(caracter))
                {
                    upperCount++;
                }
                if(char.IsPunctuation(caracter))
                {
                    punctuationCount++;
                }
                if(char.IsSymbol(caracter))
                {
                    passwordprob.SetError(passwordbox, "Password must not contain symbols");
                }
            }

            if(numberCount < 1)
            {
                passwordprob.SetError(passwordbox, "Password must contain at least one number");
            }
            if(upperCount < 1)
            {
                passwordprob.SetError(passwordbox, "Password must contain at least one uppercase letter");
            }
            if(punctuationCount < 1)
            {
                passwordprob.SetError(passwordbox, "Password must contain at least one special character(ex: ! @ # )");
            }

            // If all validations are passed, proceed to the phone validations
            if (phonebox.Text.Length != 10)
            {
                phoneprob.SetError(phonebox, "Romanian phone number invalid");
            }

            if(!(((addressbox.Text).Contains("Str")||(addressbox.Text.Contains("Strada")))))
            {
                addressprob.SetError(addressbox, "Address must not contain Strada");
            }
            if (!((addressbox.Text.Contains("Bl") || (addressbox.Text.Contains("Bloc")))))
            {
                addressprob.SetError(addressbox, "Address must not contain Strada");
            }
            if (!((addressbox.Text.Contains("Ap") || (addressbox.Text.Contains("Apartament")))))
            {
                addressprob.SetError(addressbox, "Address must not contain Apartament");
            }

            Console.WriteLine("All validations passed, proceeding to the next form...");
        }
    }
}
