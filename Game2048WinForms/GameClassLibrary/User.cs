namespace GameClassLibrary
{
    public class User
    {
        public string Name;
        public int Scores;

        public User(string name)
        {
            Name = name;
        }
        public User Clone()
        {
            User newUser = new(Name);
            newUser.Scores = Scores;

            return newUser;
        }
    }
}
