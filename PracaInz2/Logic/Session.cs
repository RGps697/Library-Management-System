using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public static class Session
    {
        internal static User ActiveUser { get; private set; }

        public static MongoDB.Bson.ObjectId ActiveUserId
        {
            get
            {
                return ActiveUser.Id;
            }
        }


        public static bool CheckIfDatabaseEmpty()
        {
            if(UserCRUD.FindUsers().Count == 0)
            {
                
                return true;
            }
            return false;
        }

        public static string CreateRootAdmin(User user)
        {
            ActiveUser = new User()
            {
                Role = new LibraryRole()
                {
                    IsAdministrator = true
                }
            };
            string result = UserCRUD.CreateUser(user);
            ActiveUser = null;
            if(result == null)
            {
                return null;
            }
            return result;
        }

        public static bool LogIn(string email, string password)
        {
            User foundUser = UserCRUD.FindUsers("Email", email).FirstOrDefault();
            if (foundUser != null)
            {
                Debug.WriteLine($"Logged as {foundUser.FirstName}, {foundUser.Surname}, {foundUser.Email}");
                string inputPassword = Credentials.EncryptPassword(password, foundUser.Salt);
                if (inputPassword == foundUser.Password)
                {
                    ActiveUser = foundUser;
                    Debug.WriteLine(ActiveUser.Role);

                    return true;
                }
            }

            return false;
        }

        public static bool LogOut()
        {
            ActiveUser = null;
            return true;
        }

        public static bool CanEditClientSettings
        {
            get
            {
                if(ActiveUser.Role.Privilege == LibraryRole.RolePrivilege.Root)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool CanBrowseBookCatalog
        {
            get
            {
                if (ActiveUser.Role.IsPatron)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool CanBorrowEbooksByself
        {
            get
            {
                if (ActiveUser.Role.Rights.CanBorrowEbooksByself)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool CanAccessManagementModule
        {
            get
            {
                if (ActiveUser.Role.IsLibrarian || ActiveUser.Role.IsManager || ActiveUser.Role.IsAdministrator)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool CanOpenUserManagement
        {
            get
            {
                if (ActiveUser.Role.IsLibrarian || ActiveUser.Role.IsManager || ActiveUser.Role.IsAdministrator)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool CanAddBooks
        {
            get
            {
                if (ActiveUser.Role.Rights.CanAddBook)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool CanEditBooks
        {
            get
            {
                if (ActiveUser.Role.Rights.CanEditBook)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool CanRemoveBooks
        {
            get
            {
                if (ActiveUser.Role.Rights.CanRemoveBook)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool CanAddUsers
        {
            get
            {
                if(ActiveUser.Role.Rights.CanAddPatron || ActiveUser.Role.IsManager || ActiveUser.Role.IsAdministrator)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool CanEditUsers
        {
            get
            {
                if (ActiveUser.Role.Rights.CanEditPatron || ActiveUser.Role.IsManager || ActiveUser.Role.IsAdministrator)
                {
                    return true;
                }
                return false; 
            }
        }
        public static bool CanRemoveUsers
        {
            get
            {
                if(ActiveUser.Role.Rights.CanRemovePatron || ActiveUser.Role.IsManager || ActiveUser.Role.IsAdministrator)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool CheckUserPrivilege(User user)
        {
            Debug.WriteLine($"user: {ActiveUser.Role.Privilege} {user.Role.Privilege}");
            if ((ActiveUser.Role.Privilege > user.Role.Privilege) || ActiveUser.Role.Rights.CanAddAdministrator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CanOpenBookManagement
        {
            get
            {
                if (ActiveUser.Role.IsLibrarian)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool CanOpenBorrowingsManagement
        {
            get
            {
                if (ActiveUser.Role.IsLibrarian)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool CanIssueBooks
        {
            get
            {
                if (ActiveUser.Role.IsLibrarian)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool CanReturnBooks
        {
            get
            {
                if (ActiveUser.Role.IsLibrarian)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool CanOpenRoleManagement
        {
            get
            {
                if (ActiveUser.Role.IsAdministrator)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool CanCreateRole
        {
            get
            {
                if (ActiveUser.Role.IsAdministrator)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool CanEditRole
        {
            get
            {
                if (ActiveUser.Role.IsAdministrator)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool CanDeleteRole
        {
            get
            {
                if (ActiveUser.Role.IsAdministrator)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool CanAccessExamModule
        {
            get
            {
                if (ActiveUser.Role.Rights.CanAttemptExams || ActiveUser.Role.IsExaminer)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool CanBrowseExams
        {
            get
            {
                if (ActiveUser.Role.Rights.CanAttemptExams || ActiveUser.Role.IsExaminer)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool CanCreateExams
        {
            get
            {
                if (ActiveUser.Role.Rights.CanCreateExam)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool CanViewExamResults
        {
            get
            {
                if (ActiveUser.Role.IsExaminer)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool CanViewAllExamResults
        {
            get
            {
                if (ActiveUser.Role.Rights.CanViewAllExamResults)
                {
                    return true;
                }
                return false;
            }
        }
        public static bool CanAddAdministrators
        {
            get
            {
                if (ActiveUser.Role.Rights.CanAddAdministrator)
                {
                    return true;
                }
                return false;
            }
        }
    }
}

