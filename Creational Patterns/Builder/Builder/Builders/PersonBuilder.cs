namespace Builder.Builders
{
    public class PersonBuilder //facade
    {
        //reference. might not work with value types
        protected Person person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(person);

        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

        public static implicit operator Person(PersonBuilder personBuilder)
        {
            return personBuilder.person;
        }
    }
}
