﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context.Models;

namespace DALTest.ModelsTest
{
    [TestFixture]
   public class CompanyTest
    {
        ///<summary>
        /// Test getters and setters
        /// </summary>

        [Test]
        public void Getters_And_Setters_Test()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp1 = new Employee()
            {
                Id = 1,
                Name = "First Employee",
                 
            };
            Employee emp2 = new Employee()
            {
                Id = 1,
                Name = "First Employee",
                
            };
            employees.Add(emp1);
            employees.Add(emp2); 


            Company comp = new Company() {
                Id = 1,
                Name = "Big Company",
                Zipcode =6700,
                Address = "Test Street 7",
                Email= "something@gmail.com",
                PhoneNr = "12345678",
                Employees = employees,
                Active = true,

            };

            Assert.AreEqual(comp.Id, 1);
            Assert.AreEqual(comp.Name, "Big Company");
            Assert.AreEqual(comp.Zipcode, 6700);
            Assert.AreEqual(comp.Address, "Test Street 7");
            Assert.AreEqual(comp.Email,"something@gmail.com");
            Assert.AreEqual(comp.PhoneNr, "12345678");
            Assert.AreEqual(comp.Employees, employees);
            Assert.AreEqual(comp.Active,true);
        }

        [Test]

        public void Company_With_The_Same_Id_Should_Be_Equal_Test()
        {
            Company comp1 = new Company { Id = 1};
            Company comp2 = new Company {Id =1};

            Assert.AreEqual(comp1,comp2);
            Assert.AreEqual(comp1.GetHashCode(),comp2.GetHashCode());
        }

        [Test]
        public void Company_With_Different_Id_Should_Be_Unequal_And_Have_Different_HashCode_Test()
        {
            Company comp1 = new Company { Id = 1 };
            Company comp2 = new Company { Id = 2 };
            Assert.AreNotEqual(comp1,comp2);
            Assert.AreNotEqual(comp1.GetHashCode(),comp2.GetHashCode());
        }



    }
 
}
