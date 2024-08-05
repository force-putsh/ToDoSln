namespace ToDoApI.Entities
{
    /// <summary>
    /// Represents a user.
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ToDo> ToDos { get; set; }
    }
}
