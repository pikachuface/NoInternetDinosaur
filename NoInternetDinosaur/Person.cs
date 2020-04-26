namespace NoInternetDinosaur
{
    public class Person
    {
        public string Name { get; private set; }
        public int Score { get; private set; }

        public Person(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }
    }
}
