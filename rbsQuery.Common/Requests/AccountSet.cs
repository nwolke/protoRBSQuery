namespace rbsQuery.Common.Requests
{
    public class AccountSet
    {
        public int[] AccountIds { get; private set; }
        public bool includeAccountProperties { get; private set; }

        public AccountSet(int[] accountids)
        {
            AccountIds = accountids;
        }

        public AccountSet IncludeAccountProperties()
        {
            includeAccountProperties = true;
            return this;
        }
    }
}