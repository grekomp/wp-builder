namespace Builder
{
    public class Phone
    {
        public string number { get; set; }
        public string area { get; set; }
        public string fullNumber {
            get
            {
                return area.ToString() + number.ToString();
            }
        }

    }
}