namespace _01BasicOOP
{
    public class Person
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string FullName()
        {
           return FirstName + " " + LastName;
        }
    }
}
