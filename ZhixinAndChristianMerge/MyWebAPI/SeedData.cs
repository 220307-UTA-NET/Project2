namespace WebData.Models;

public static class SeedData
{

    public static void InitializeAccount(IAccountRepository repository)
    {
        List<Account> accounts = new List<Account>();

        Account a1 = new Account();
        a1.AccountId = 1;
        a1.UserName = "zhixin";
        a1.FirstName = "Zhixin";
        a1.LastName = "H";
        a1.Password = "123456";
        a1.Email = "zhixin@email.com";
        a1.Phone = "123-456-7890";
        a1.Address = "12350 Carmel Mountain Rd, San Diego, CA 92128";
        a1.City = "San Diego";
        a1.State = "CA";
        a1.Zip = "92128";
        a1.Country = "USA";
        accounts.Add(a1);
        Account a2 = new Account();
        a2.AccountId = 2;
        a2.UserName = "bruk";
        a2.FirstName = "Bruk";
        a2.LastName = "Bruk";
        a2.Password = "123456";
        a2.Email = "bruk@email.com";
        a2.Phone = "234-567-8901";
        a2.Address = "801 S Pavilion Center Dr, Las Vegas, NV 89144";
        a2.City = "Las Vegas";
        a2.State = "NV";
        a2.Zip = "89144";
        a2.Country = "USA";
        accounts.Add(a2);
        Account a3 = new Account();
        a3.AccountId = 3;
        a3.UserName = "tahereh";
        a3.FirstName = "Tahereh";
        a3.LastName = "R";
        a3.Password = "123456";
        a3.Email = "tahereh@email.com";
        a3.Phone = "345-678-9012";
        a3.Address = "2901 Los Feliz Blvd, Los Angeles, CA 90039";
        a3.City = "Los Angeles";
        a3.State = "CA";
        a3.Zip = "90039";
        a3.Country = "USA";
        accounts.Add(a3);
        Account a4 = new Account();
        a4.AccountId = 4;
        a4.UserName = "kelly";
        a4.FirstName = "Kelly";
        a4.LastName = "K";
        a4.Password = "123456";
        a4.Email = "kelly@email.com";
        a4.Phone = "456-789-0123";
        a4.Address = "4900 Panama Ln, Bakersfield, CA 93313";
        a4.City = "Bakersfield";
        a4.State = "CA";
        a4.Zip = "93313";
        a4.Country = "USA";
        accounts.Add(a4);
        Account a5 = new Account();
        a5.AccountId = 5;
        a5.UserName = "christian";
        a5.FirstName = "Christian";
        a5.LastName = "C";
        a5.Password = "123456";
        a5.Email = "christian@email.com";
        a5.Phone = "567-890-1234";
        a5.Address = "8055 Churchill Way, Dallas, TX 75251";
        a5.City = "Dallas";
        a5.State = "TX";
        a5.Zip = "75251";
        a5.Country = "USA";
        accounts.Add(a5);

        if (repository.Accounts.Count() == 0)
        {
            repository.CreateAccount(a1);
            repository.CreateAccount(a2);
            repository.CreateAccount(a3);
            repository.CreateAccount(a4);
            repository.CreateAccount(a5);
        }
    }
    public static void InitializePet(IPetRepository repository)
    {
        Pet p1 = new Pet() { PetId = 0, Name = "Zion", Type = "Zebra", Age = 1, Breed = "African", AccountId = 1, Description = "Zion is a very good pet.", Image = "not available", DateAdded = DateTime.Now, NeedBeAdopted = false, NeedPetSitted = false };
        Pet p2 = new Pet() { PetId = 0, Name = "Bush", Type = "Bunny", Age = 2, Breed = "Dutch Rabbit", AccountId = 2, Description = "Bush is a very good pet.", Image = "not available", DateAdded = DateTime.Now, NeedBeAdopted = false, NeedPetSitted = false };
        Pet p3 = new Pet() { PetId = 0, Name = "Teddy", Type = "Bear", Age = 3, Breed = "Polar Bear", AccountId = 3, Description = "Teddy is a very good pet.", Image = "not available", DateAdded = DateTime.Now, NeedBeAdopted = false, NeedPetSitted = false };
        Pet p4 = new Pet() { PetId = 0, Name = "Kitty", Type = "Cat", Age = 4, Breed = "British Shorthair", AccountId = 4, Description = "Kitty is a very good pet.", Image = "not available", DateAdded = DateTime.Now, NeedBeAdopted = false, NeedPetSitted = false };
        Pet p5 = new Pet() { PetId = 0, Name = "Captain", Type = "C", Age = 5, Breed = "American Alligator", AccountId = 5, Description = "Captain is a very good pet.", Image = "not available", DateAdded = DateTime.Now, NeedBeAdopted = false, NeedPetSitted = false };
        if (repository.Pets.Count() == 0)
        {
            repository.CreatePet(p1);
            repository.CreatePet(p2);
            repository.CreatePet(p3);
            repository.CreatePet(p4);
            repository.CreatePet(p5);
        }
    }
    public static void InitializeMessage(IMessageRepository repository)
    {
        Message m1 = new Message() { MessageId = 0, MessageTopic = "on Zion", MessageText = "I like Zion. He is cool.", CreatedTime = DateTime.Now, FromAccountId = 4, OnPetId = 1 };

        Message m2 = new Message() { MessageId = 0, MessageTopic = "on Bush", MessageText = "I like Bush. He is cool.", CreatedTime = DateTime.Now, FromAccountId = 5, ToAccountId = 2, OnPetId = 2 };

        if (repository.Messages.Count() == 0)
        {
            repository.CreateMessage(m1);
            repository.CreateMessage(m2);

        }
    }
}