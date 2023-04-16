using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{

    public static class UserCRUD
    {
        static UserCRUD()
        {
        }

        public static string CreateUser(User user)
        {
            if (!Session.CanAddUsers)
                throw new UnauthorizedAccessException("Missing privilege to add users");
            
            string result = null;
            UserValidator validator = new UserValidator();
            var results = validator.Validate(user);
            if (results.IsValid == false)
            {
                string errorMessage = "";
                foreach (var error in results.Errors)
                {
                    errorMessage += error.ErrorMessage + "\n";
                }
                result = errorMessage;
            }
            else
            {
                if (UserCRUD.FindUsers("email", user.Email).Count == 0)
                {
                    user.Salt = Credentials.GenerateSalt();
                    user.Password = Credentials.EncryptPassword(user.Password, user.Salt);
                    DatabaseGateway.InsertDocument("users", user);
                }
                else
                {
                    result = "Istnieje użytkownik o podanym emailu";
                }
            }

            return result;

        }

        public static string UpdateUser(User user)
        {
            if (!Session.CanEditUsers)
                throw new UnauthorizedAccessException("Missing privilege to edit users");

            string result = null;
            UserValidator validator = new UserValidator();
            var results = validator.Validate(user);
            if (results.IsValid == false)
            {
                string errorMessage = "";
                foreach (var error in results.Errors)
                {
                    errorMessage += error.ErrorMessage + "\n";
                }
                result = errorMessage;
            }
            else
            {
                if (UserCRUD.FindUsers("email", user.Email).Count == 0)
                {
                    DatabaseGateway.UpdateDocument("users", user.Id, user);
                }
                else
                {
                    result = "Istnieje użytkownik o podanym emailu";
                }
            }

            return result;
        }

        internal static bool UpdateUser<T>(ObjectId id, string field, T value)
        {
            return DatabaseGateway.UpdateDocumentField<T>("users", id, field, value);
        }

        public static bool ChangePassword(string password)
        {
            if(password.Length > 6)
            {
                byte[] salt = Credentials.GenerateSalt();
                string encryptedPassword = Credentials.EncryptPassword(password, salt);
                UpdateUser(Session.ActiveUser.Id, nameof(User.Password), encryptedPassword);
                UpdateUser(Session.ActiveUser.Id, nameof(User.Salt), salt);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string DeleteUser(User user)
        {
            if (Session.CheckUserPrivilege(user))
            {
                List<Borrowing> foundBorrowings = BorrowingCRUD.FindBorrowingsById("UserId", user.Id);
                if (foundBorrowings.Count == 0)
                {
                    DatabaseGateway.DeleteDocument<User>("users", user.Id);
                    return null;
                }
                else
                {
                    Debug.WriteLine($"User still has {foundBorrowings.Count} borrowings");
                    return $"Użytkownik ma {foundBorrowings.Count} aktywnych wypożyczeń.";
                }
            }
            else
            {
                return "Niewystarczające uprawienia.";
            }
        }

        public static User FindUserById(string column, ObjectId id)
        {
            User result = DatabaseGateway.FindDocumentById<User>("users", column, id);
            try
            {
                result.Role = LibraryRoleCRUD.FindRoleById(result.RoleId);
            }
            catch(Exception e)
            {

            }
            return result;
        }

        public static List<User> FindUsers()
        {
            List<User> result = DatabaseGateway.FindDocuments<User>("users");
            for (int i = 0; i < result.Count; i++)
            {
                result[i].Role = LibraryRoleCRUD.FindRoleById(result[i].RoleId);
            }
            return result;
        }

        public static List<User> FindUsers(string column, string value)
        {
            List<User> result = DatabaseGateway.FindDocuments<User>("users", column, value);
            for (int i = 0; i < result.Count; i++)
            {
                result[i].Role = LibraryRoleCRUD.FindRoleById(result[i].RoleId);
            }
            return result;
        }

        public static List<User> FindUsers(string collection, string column, string value)
        {
            List<User> result = DatabaseGateway.FindDocuments<User>(collection, column, value);
            for(int i = 0; i < result.Count; i++)
            {
                result[i].Role = LibraryRoleCRUD.FindRoleById(result[i].RoleId);
            }
            return result;
        }

             
    }
}
