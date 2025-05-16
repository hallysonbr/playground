namespace Praticas.Interpreters.Contexts
{
    public class DateContext
    {
        public string Expression { get; set; }
        public DateTime Date { get; set; }

        public DateContext(DateTime date)
        {
            Date = date;
        }
    }
}
