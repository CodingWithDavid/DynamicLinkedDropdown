namespace UserSelection.Data
{
    public class Cities
    {
        public List<string> City { get; set; } = new List<string>();

        public Cities()
        {
            City.Add("Olathe");
            City.Add("Kansas City");
            City.Add("Essex");
            City.Add("Reno");
            City.Add("Iowa City");
        }
    }
}
