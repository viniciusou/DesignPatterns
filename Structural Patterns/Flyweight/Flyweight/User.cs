namespace Flyweight
{
    public class User
    {
        private string fullName;

        public User(string fullName)
        {
            this.fullName = fullName;
        }

        public override string ToString() => fullName;
    }
}
