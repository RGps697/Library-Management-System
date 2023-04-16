using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public static class LibraryRoleCRUD
    {
        public static string CreateRole(LibraryRole role)
        {
            if (CheckRoleNameExistence(role))
            {
                return "Istnieje rola o takiej nazwie";
            }
            else
            {
                AdjustPrivilege(role);
                DatabaseGateway.InsertDocument("roles", role);
                return null;
            }
        }

        public static string UpdateRole(LibraryRole role)
        {
            if (CheckRoleNameExistence(role))
            {
                return "Istnieje rola o takiej nazwie";
            }
            else
            {
                AdjustPrivilege(role);
                DatabaseGateway.UpdateDocument("roles", role.Id, role);
                return null;
            }
        }

        private static void AdjustPrivilege(LibraryRole role)
        {
            if (role.IsPatron) role.Privilege = LibraryRole.RolePrivilege.Patron;
            if (role.IsLibrarian) role.Privilege = LibraryRole.RolePrivilege.Librarian;
            if (role.IsExaminer) role.Privilege = LibraryRole.RolePrivilege.Examiner;
            if (role.IsManager) role.Privilege = LibraryRole.RolePrivilege.Manager;
            if (role.IsAdministrator) role.Privilege = LibraryRole.RolePrivilege.Administrator;
            if (role.Rights.CanAddAdministrator) role.Privilege = LibraryRole.RolePrivilege.Root;
        }

        private static bool CheckRoleNameExistence(LibraryRole role)
        {
            LibraryRole foundRole = FindRoles("books", nameof(LibraryRole.Name), role.Name).FirstOrDefault();
            if (foundRole != null && !foundRole.Id.Equals(role.Id))
            {
                return true;
            }
            return false;
        }

        public static void UpsertRole(LibraryRole role)
        {
            DatabaseGateway.UpsertDocument<LibraryRole>("roles", role.Id, role);
        }

        public static List<LibraryRole> FindRoles()
        {
            List<LibraryRole> AllRoles = DatabaseGateway.FindDocuments<LibraryRole>("roles");

            return AllRoles;
        }

        public static List<LibraryRole> FindRoles(string column, string value)
        {
            List<LibraryRole> foundLibraryRoles = DatabaseGateway.FindDocuments<LibraryRole>("roles", column, value);

            return foundLibraryRoles;
        }

        public static List<LibraryRole> FindRoles(string collection, string column, string value)
        {
            List<LibraryRole> foundLibraryRoles = DatabaseGateway.FindDocuments<LibraryRole>(collection, column, value);

            return foundLibraryRoles;
        }

        internal static LibraryRole FindRoleById(ObjectId roleId)
        {
            return DatabaseGateway.FindDocumentById<LibraryRole>("roles", "Id", roleId);
        }

        public static List<LibraryRole> GetAssignableRoles()
        {
            List<LibraryRole> allRoles = FindRoles();
            List<LibraryRole> availableRoles = new List<LibraryRole>();
            for (int i = 0; i < allRoles.Count; i++)
            {
                Debug.WriteLine($"{allRoles[i].Name} {allRoles[i].Privilege}, Active: {Session.ActiveUser.Role.Privilege}");
                if ((allRoles[i].Privilege < Session.ActiveUser.Role.Privilege))
                {
                    availableRoles.Add(allRoles[i]);
                }
            }
            availableRoles = availableRoles.OrderBy(o => o.Privilege).ToList();
            return availableRoles;
        }

        public static string DeleteLibraryRole(LibraryRole role)
        {
            User result = DatabaseGateway.FindDocumentById<User>("users", nameof(User.RoleId), role.Id);
            if (result != null)
            {
                return "Istnieje użytkownik posiadający tę role";
            }
            else
            {
                DatabaseGateway.DeleteDocument<LibraryRole>("roles", role.Id);
                return null;
            }
        }
    }
}
