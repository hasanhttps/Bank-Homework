using Bank.models;

namespace Bank {
    internal class Program {
        static void Main() {
            // GUI


            Bank.models.Bank bank = new Bank.models.Bank();

            Console.SetCursorPosition(40, 13);
            Console.Write("Please enter the 4 digit Pin code : ");
            string? pin = Console.ReadLine();
            if (bank.checkExsist(pin!)) {
                while (true) {
                    Console.Clear();
                    Console.WriteLine($"{Bank.models.Bank.currentClient.Name} {Bank.models.Bank.currentClient.Surname} Xos geldiniz zehmet olmasa asagidakilardan birini secin \n\n\n");
                    Console.Write("\t\t\t1. Balans\n\t\t\t2. Nagd Pul\n\t\t\t3. Islemler\n\t\t4. Kartdan-Karta Kocurme\n\nZehmet olmasa secimi daxil edin : ");
                    int choose = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (choose == 1) {
                        Console.WriteLine($"Your balance is {Bank.models.Bank.currentClient.BankAccount.Balans}$.");
                        Console.Write("Please enter any key to continue ...");
                        dynamic a = Console.ReadKey();
                    }else if (choose == 2) {
                        Console.WriteLine($"Your balance is {Bank.models.Bank.currentClient.BankAccount.Balans}$.");
                        Console.WriteLine("        1. 10 AZN\r\n        2. 20 AZN\r\n        3. 30 AZN\r\n        4. 40 AZN\r\n        5. Diger \n\n");
                        Console.Write("Please enter choose : ");
                        int opt = Convert.ToInt32(Console.ReadLine());
                        if (opt == 5) {
                            Console.Write("Please enter any amount : ");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            if (Bank.models.Bank.currentClient.BankAccount.Balans - amount >= 0) {
                                Bank.models.Bank.currentClient.BankAccount.Balans -= amount;
                                Bank.models.Bank.currentClient.BankAccount.operations[Bank.models.Bank.currentClient.BankAccount.index++] = $"{amount}$ had taken from this account in {DateTime.Now}.";
                            }
                            else {
                                try {
                                    throw new Exception("You don't have enough many in card !");
                                }catch(Exception e) {
                                    Console.WriteLine(e.Message);
                                    Console.Write("Please enter any key to continue ...");
                                    dynamic a = Console.ReadKey();
                                    continue;
                                }
                            }
                        } else if (opt < 5 && opt > 0) {
                            if (Bank.models.Bank.currentClient.BankAccount.Balans - opt * 10 >= 0) {
                                Bank.models.Bank.currentClient.BankAccount.Balans -= opt * 10;
                                Bank.models.Bank.currentClient.BankAccount.operations[Bank.models.Bank.currentClient.BankAccount.index++] = $"{opt * 10}$ had taken from this account in {DateTime.Now}.";
                            }
                            else {
                                try {
                                    throw new Exception("You don't have enough many in card !");
                                }catch(Exception e) {
                                    Console.WriteLine(e.Message);
                                    Console.Write("Please enter any key to continue ...");
                                    dynamic a = Console.ReadKey();
                                    continue;
                                }
                            }
                        }
                        else {
                            try {
                                throw new Exception("Not valid choose !");
                            }catch(Exception e) {
                                Console.WriteLine(e.Message);
                                Console.Write("Please enter any key to continue ...");
                                dynamic a = Console.ReadKey();
                                continue;
                            }
                        }

                        Console.Write("Here your money take it . . .");
                        dynamic b = Console.ReadKey();
                    }else if (choose == 3) {
                        string[] operations = Bank.models.Bank.currentClient.BankAccount.operations;
                        for (int i = 0; i < Bank.models.Bank.currentClient.BankAccount.index + 1; i++) {
                            Console.WriteLine(operations[i]);
                        }
                        Console.Write("\n\nPlease enter any key to continue ...");
                        dynamic a = Console.ReadKey();

                    }else if (choose == 4) {
                        bool istrue = true;
                        Client? other = null;
                        while(istrue) { 
                            Console.Write("Please enter the pin code : ");
                            string pincode = Console.ReadLine();
                            Client[] clients = bank.clients;
                            foreach (Client client in clients) {
                                if (client.BankAccount.Pin == pincode) {
                                    istrue = false;
                                    other = client;
                                    break;
                                }else istrue = true;
                            }
                            if (istrue) {
                                Console.WriteLine("Please enter valid pin code !");
                                Console.Write("Please enter any key to continue ...");
                                dynamic a = Console.ReadKey();
                            }
                        }
                        Console.Write("Please enter the money amount : ");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        Bank.models.Bank.currentClient.BankAccount.Balans -= amount;
                        other!.BankAccount.Balans -= amount;
                        Bank.models.Bank.currentClient.BankAccount.operations[Bank.models.Bank.currentClient.BankAccount.index++] = $"{amount}$ had sent from {Bank.models.Bank.currentClient.BankAccount.FullName} to {other.BankAccount.FullName}.";
                    }
                }
            }
            else {
                try {
                    throw new Exception("Not Valid Pin !");
                }catch(Exception e) {
                    Console.WriteLine(e.Message);
                    Console.Write("Please enter any key to continue ...");
                    dynamic a = Console.ReadKey();
                }
            }

        }
    }
}