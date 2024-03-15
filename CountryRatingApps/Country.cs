namespace CountryRatingApps
{
    public class Country
    {
        private List<int> point = new List<int>();
        public Country(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
        public int Result
        {
            get
            {
                return this.point.Sum();
            }
        }

        public void AddPoint(int score)
        {
            this.point.Add(score);
        }
    }
}
