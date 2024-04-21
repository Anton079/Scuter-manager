using Scuter_manager;

internal class Program
{
    private static void Main(string[] args)
    {
        UserService userService = new UserService();

        User userTest = new User(1, "gaeg@gmail.com", "gertge", 075463354);

        userService.AddUser(userTest);

        userService.SaveData();
    }
}