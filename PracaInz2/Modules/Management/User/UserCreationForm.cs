using UserInterfaceLibrary.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLibrary
{
    public partial class UserCreationForm : Form
    {
        List<KeyValuePair<string, LibraryRole>> RolesDropDown { get; set; }
        internal User User { get; set; }
        private bool UserEdit { get; set; } = false;

        public UserCreationForm()
        {
            if(!Session.CanAddUsers) throw new UnauthorizedAccessException("Missing privilege to add new users");
            
            InitializeComponent();
            User = new User();

            InitializeFields();
        }

        internal UserCreationForm(User user)
        {
            if(!Session.CanEditUsers) throw new UnauthorizedAccessException("Missing privilege to edit existing users");
            if (!Session.CheckUserPrivilege(user))
            {
                MessageBox.Show("Nie wystarczające uprawnienia by edytować tego użytkownika");
                Close();
            }
            else
            {
                UserEdit = true;
                InitializeComponent();
                InitializeFields();
                User = user;
                inputEmail.Enabled = false;
                FillFormFields(user);
            }
        }

        private void InitializeFields()
        {
            List<LibraryRole> assignableRoles = LibraryRoleCRUD.GetAssignableRoles();

            RolesDropDown = new List<KeyValuePair<string, LibraryRole>>();
            for (int i = 0; i < assignableRoles.Count; i++)
            {
                RolesDropDown.Add(new KeyValuePair<string, LibraryRole>(assignableRoles[i].Name, assignableRoles[i]));
            }

            BindingSource bindingSrc = new BindingSource();
            bindingSrc.DataSource = RolesDropDown;

            cbRole.DataSource = RolesDropDown;
            cbRole.ValueMember = "value";
            cbRole.DisplayMember = "key";
        }

        private void FillFormFields(User user)
        {
            Console.WriteLine($"name: {user.FirstName}");
            inputFirstName.Text = user.FirstName;
            inputSurname.Text = user.Surname;
            inputEmail.Text = user.Email;
            inputPhoneNumber.Text = user.PhoneNumber;
            for(int i = 0; i < RolesDropDown.Count; i++)
            {
                Console.WriteLine($"user roleid: {user.RoleId}, dropdown val: {RolesDropDown[i].Value.Id}, dropdown val name: {RolesDropDown[i].Value.Name}");
                if (user.RoleId == RolesDropDown[i].Value.Id)
                {
                    cbRole.SelectedIndex = i;
                }
            }
        }

        private User InsertDataToUser(User user)
        {
            user.FirstName = inputFirstName.Text;
            user.Surname = inputSurname.Text;
            if(!UserEdit)
                user.Email = inputEmail.Text;
            user.PhoneNumber = inputPhoneNumber.Text;
            user.RoleId = RolesDropDown[cbRole.SelectedIndex].Value.Id;
            user.Role = RolesDropDown[cbRole.SelectedIndex].Value;
            Console.WriteLine($"rola: {user.Role}");
            return user;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            User = InsertDataToUser(User);

            string password = "";
            string result;
            if (UserEdit)
            {
                 result = UserCRUD.UpdateUser(User);
            }
            else
            {
                password = Credentials.GeneratePassword();
                User.Password = password;
                result = UserCRUD.CreateUser(User);
            }

            if (result == null)
            {
                if (!string.IsNullOrEmpty(password))
                {
                    MessageBox.Show($"Hasło tymczasowe: {password}", "Użytkownik dodany");
                    password = "";
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(result);
            }
        }
    }
}
