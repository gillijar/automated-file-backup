namespace file_duplicator_to_cloud.Models
{
    public class Date : IDate
    {
        public string FormattedDate { get; private set; }

        public Date()
        {
            FormattedDate = Get();
        }

        public string Get()
        {
            string date = DateTime.Now.ToString("yyyyMMdd");
            date = date.Insert(0, "_");
            return date;
        }
    }
}
