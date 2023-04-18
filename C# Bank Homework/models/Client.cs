using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.models {
    public class Client {

        // Private Fields

        private int _id;
        private string _name;
        private string _surname;
        private int _age;
        private int _salary;
        private BankCard bankAccount;

        // Acsessors

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public int Salary { get { return _salary; } set { _salary = value; } }
        public BankCard BankAccount { get {  return bankAccount; } set {  bankAccount = value; } }

        // Constructor
        public Client(int id, string name, string surname, int age, int salary, BankCard bankCard) { 
            _id = id;
            _name = name;
            _surname= surname;
            _age = age;
            _salary = salary;
            bankAccount = bankCard;
        }

        // Function

        public void show() {
            Console.WriteLine($"Id : {_id}\nName : {_name}\nSurname : {_surname}\nAge : {_age}\nSalary : {_salary}\n\nBank Info\n");
            bankAccount.show();
        }
    }
}

