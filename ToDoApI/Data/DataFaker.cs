using ToDoApI.Entities;

namespace ToDoApI.Data
{
    public abstract class DataFaker
    {

        User user = new User();

        private static List<User> Users { get; } = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "John Doe",
                ToDos = new List<ToDo>
                {
                    new ToDo { Id=1, Title = "Buy milk" },
                    new ToDo {Id = 2,  Title = "Clean the house" }
                }
            },
            new User
            {
                Id = 2,
                Name = "Jane Doe",
                ToDos = new List<ToDo>
                {
                    new ToDo {Id = 3,  Title = "Walk the dog" },
                    new ToDo {Id = 4,  Title = "Do the laundry" }
                }
            }
        };

        public static List<User> GetUsers() => Users;

        public static bool DeleteUser(string name)
        {
            var user = Users.FirstOrDefault(u => u.Name == name);
            if (user != null)
            {
                return Users.Remove(user);
            }
            return false;
        }

        public static User UpdateUser(int useId, string newUserName)
        {
            var index = Users.FindIndex(u => u.Id == useId);
            if (index != -1)
            {
                Users[index].Name = newUserName;
                return Users[index];
            }
            return null;
        }
    }
}
