using Microsoft.EntityFrameworkCore;
using System.Linq;
using Webpet.Models;


namespace Webpet.DataLogic;

public class EFPetRepository : IPetRepository
{
    private readonly DataContext _context;

    public EFPetRepository(DataContext context)
    {
        _context = context;
    }


    public IEnumerable<Pet> Pets => _context.Pets;
    public void UpdatePet(Pet pet)
    {
        Pet petToBeUpdated = _context.Pets.FirstOrDefault(p => p.PetId == pet.PetId);
        if (petToBeUpdated != null)
        {
            petToBeUpdated.Name = pet.Name ?? petToBeUpdated.Name;
            petToBeUpdated.Age = pet.Age;
            petToBeUpdated.Type = pet.Type ?? petToBeUpdated.Type;
            petToBeUpdated.Breed = pet.Breed ?? petToBeUpdated.Breed;
            petToBeUpdated.Description = pet.Description ?? petToBeUpdated.Description;
            petToBeUpdated.Image = pet.Image ?? petToBeUpdated.Image;
            petToBeUpdated.NeedBeAdopted = pet.NeedBeAdopted;
            petToBeUpdated.NeedPetSitted = pet.NeedPetSitted;
            _context.SaveChanges();
        }   
        _context.SaveChanges();
    }

    public void CreatePet(Pet pet)
    {
        _context.Pets.Add(pet);
        _context.SaveChanges();
    }
    public void DeletePet(int petId)
    {
        Pet petToBeDeleted = _context.Pets.FirstOrDefault(p => p.PetId == petId);
        if (petToBeDeleted != null)
        {
            _context.Pets.Remove(petToBeDeleted);
            _context.SaveChanges();
        }
    }
}

public class EFAccountRepository : IAccountRepository
{
    private DataContext _context;

    public EFAccountRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<Account> Accounts => _context.Accounts;
    public void UpdateAccount(Account account)
    {
        Account accountToBeUpdated = _context.Accounts.FirstOrDefault(a => a.AccountId == account.AccountId);
        if (accountToBeUpdated != null)
        {
            accountToBeUpdated.UserName = account.UserName ?? accountToBeUpdated.UserName;
            accountToBeUpdated.FirstName = account.FirstName ?? accountToBeUpdated.FirstName;
            accountToBeUpdated.LastName = account.LastName ?? accountToBeUpdated.LastName;
            accountToBeUpdated.Email = account.Email ?? accountToBeUpdated.Email;
            accountToBeUpdated.Phone = account.Phone ?? accountToBeUpdated.Phone;
            accountToBeUpdated.Address = account.Address ?? accountToBeUpdated.Address;
            accountToBeUpdated.City = account.City ?? accountToBeUpdated.City;
            accountToBeUpdated.State = account.State ?? accountToBeUpdated.State;
            accountToBeUpdated.Zip = account.Zip ?? accountToBeUpdated.Zip;
            accountToBeUpdated.Password = account.Password ?? accountToBeUpdated.Password;
            accountToBeUpdated.Country = account.Country ?? accountToBeUpdated.Country;
            _context.SaveChanges();
        }
    }

    public void CreateAccount(Account account)
    {
        _context.Accounts.Add(account);
        _context.SaveChanges();
    }
    public void DeleteAccount(int accountId)
    {
        Account accountToBeDeleted = _context.Accounts.FirstOrDefault(a => a.AccountId == accountId);
        if (accountToBeDeleted != null)
        {
            _context.Accounts.Remove(accountToBeDeleted);
            _context.SaveChanges();
        }
    }
}

public class EFMessageRepository : IMessageRepository
{
    private DataContext _context;

    public EFMessageRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<Message> Messages => _context.Messages;
    
    public void CreateMessage(Message message)
    {
        _context.Messages.Add(message);
        _context.SaveChanges();
    }
   
}

public class EFPetWaitingListRepository : IPetWaitingListRepository
{
    private DataContext _context;

    public EFPetWaitingListRepository(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<PetWaitingList> PetWaitingLists => _context.PetWaitingLists;
    public void CreatePetWaitingList(PetWaitingList petWaitingList)
    {
        _context.PetWaitingLists.Add(petWaitingList);
        _context.SaveChanges();
    }
    public void DeletePetWaitingList(int petWaitingListId)
    {
        PetWaitingList petWaitingListToBeDeleted = _context.PetWaitingLists.FirstOrDefault(p => p.PetWaitingListId == petWaitingListId);
        if (petWaitingListToBeDeleted != null)
        {
            _context.PetWaitingLists.Remove(petWaitingListToBeDeleted);
            _context.SaveChanges();
        }
    }
}
    