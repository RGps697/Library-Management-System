using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTests
{
    internal class LibraryRoleTests
    {
        [SetUp]
        public void Setup()
        {

        }

        //[Test]
        //public void LibraryRoleSet()
        //{
        //    LibraryRole role = new LibraryRole();
        //    string test = " ";
        //    role. = test;
        //    Assert.That(role., Is.EqualTo(test));
        //}

        [Test]
        public void LibraryRoleSetName()
        {
            LibraryRole role = new LibraryRole();
            string testName = "Test Name";
            role.Name = testName;
            Assert.That(role.Name, Is.EqualTo(testName));
        }

        [TestCase(LibraryRole.RolePrivilege.Patron, 1)]
        [TestCase(LibraryRole.RolePrivilege.Librarian, 2)]
        [TestCase(LibraryRole.RolePrivilege.Examiner, 2)]
        [TestCase(LibraryRole.RolePrivilege.Manager, 3)]
        [TestCase(LibraryRole.RolePrivilege.Administrator, 4)]
        [TestCase(LibraryRole.RolePrivilege.Root, 5)]
        public void LibraryRoleSetPrivilege(LibraryRole.RolePrivilege rolePriv, int expected)
        {
            LibraryRole role = new LibraryRole();
            role.Privilege = rolePriv;
            Assert.That((int)role.Privilege, Is.EqualTo(expected));
        }
    }
}
