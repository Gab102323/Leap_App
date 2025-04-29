using Leap_App.Services;
using System.Threading.Tasks;
using SQLite;

namespace Leap_App.Services
{
    public class AccountService
    {
        private readonly SQLiteAsyncConnection _database;

        public AccountService()
        {
            _database = new SQLiteAsyncConnection("accounts.db");
            _database.CreateTableAsync<Account>().Wait();
        }

        public async Task<bool> CreateAccountAsync(string username, string password)
        {
            var existingAccount = await _database.Table<Account>().FirstOrDefaultAsync(a => a.Username == username);
            if (existingAccount != null)
                return false;

            var account = new Account { Username = username, Password = password, Progress = 0 };
            await _database.InsertAsync(account);
            return true;
        }

        public async Task<bool> ValidateAccountAsync(string username, string password)
        {
            var account = await _database.Table<Account>().FirstOrDefaultAsync(a => a.Username == username && a.Password == password);
            return account != null;
        }

        public async Task<int> GetProgressAsync(string username)
        {
            var account = await _database.Table<Account>().FirstOrDefaultAsync(a => a.Username == username);
            return account?.Progress ?? 0;
        }
    }

    public class Account
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Progress { get; set; }
    }
}