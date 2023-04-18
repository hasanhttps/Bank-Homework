using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.models {
    public class Bank {
        static public Client currentClient;
        // Private Fields

        private Client[] clients = new Client[5];
        public static int index = 0;

        // Constructor

        public Bank() { 

            Guid pan1 = Guid.NewGuid();
            Guid pan2 = Guid.NewGuid();
            Guid pan3 = Guid.NewGuid();
            Guid pan4 = Guid.NewGuid();
            Guid pan5 = Guid.NewGuid();
            BankCard card1 = new BankCard("Kapital", "Hesen Abdullazade", pan1.ToString(), "2000", "264", "06/15", 3000);
            BankCard card2 = new BankCard("LeoBank", "Rustem Hesenli", pan2.ToString(), "1645", "363", "01/11", 1000);
            BankCard card3 = new BankCard("UniBank", "Kamal Ibrahimov", pan3.ToString(), "2937", "192", "04/29", 2000);
            BankCard card4 = new BankCard("PashaBank", "Ibrahim Ibrahimov", pan4.ToString(), "3244", "856", "09/16", 2000);
            BankCard card5 = new BankCard("AtaBank", "Mehemmed Ibrahimov", pan5.ToString(), "8266", "523", "05/06", 4000);
            clients[index++] = new Client(1, "Hesen", "Abdullazade", 14, 4500, card1);
            clients[index++] = new Client(2, "Rustem", "Hesenli", 16, 5500, card2);
            clients[index++] = new Client(3, "Kamal", "Ibrahimov", 23, 2000, card3);
            clients[index++] = new Client(4, "Ibrahim", "Ibrahimov", 19, 6000, card4);
            clients[index++] = new Client(5, "Mehemmed", "Ibrahimov", 26, 9000, card5);

        }

        public Bank(Client[] clients) {
            this.clients = clients;
        }

        // Functions

        public void addClient(Client newClient){
            clients[index++] = newClient;
        }

        public int showCardBalance(BankCard bankCard) {
            return bankCard.Balans;
        }

        public void showClients() {
            foreach (Client client in clients) { 
                client.show();
            }
        }

        public bool checkExsist(string pin) {
            foreach (Client client in clients) {
                if (client.BankAccount.Pin == pin) {
                    currentClient = client;
                    return true;
                }
            }return false;
        }
    }
}
