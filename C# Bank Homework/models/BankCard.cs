using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.models {
    public class BankCard {
        // Private Fields

        private string bankName;
        private string fullName;
        private string pan;
        private string pin;
        private string cvc;
        private string expireDate;
        private int balans;
        public string[] operations = new string[100];
        public int index = 0;

        // Acsessors

        public string BankName { get { return bankName; } set { bankName = value; } }
        public string FullName { get { return fullName; } set { fullName = value; } }
        public string Pan { get { return pan; } set { pan = value; } }
        public string Pin { get { return pin; } set { pin = value; } }
        public string Cvc { get { return cvc; } set { cvc = value; } }
        public string ExpireDate { get { return expireDate; } set { expireDate = value; } }
        public int Balans { get { return balans; } set { balans = value; } }

        // Constructors

        public BankCard(string bankname, string fullname, string pan, string pin, string cvc, string expiredate, int balans) {
            bankName = bankname;
            fullName = fullname;
            this.pan = pan;
            this.pin = pin;
            this.cvc = cvc;
            expireDate = expiredate;
            this.balans = balans;
        }

        // Functions

        public void show() {
            Console.WriteLine($"Bank Name : {bankName}\nFullname : {fullName}\nPan : {pan}\nPin : {pin}\nCvc : {cvc}\nExpire Date : {expireDate}\nBalans : {balans}");
        }

    }
}
