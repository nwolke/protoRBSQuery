namespace rbsQuery.Common.Requests
{
    public class TradeDataRequest
    {
        public EnterpriseRequest EnterpriseRequest { get; private set; }
        public ClientRequest ClientRequest { get; private set; }
        public AccountSet AccountSet { get; private set; }

        public TradeDataRequest ForEnterprise(int enterpriseId)
        {
            EnterpriseRequest = new EnterpriseRequest(enterpriseId);
            return this;
        }

        public TradeDataRequest ForClient(int clientId)
        {
            ClientRequest = new ClientRequest(clientId);
            return this;
        }

        public AccountSet ForAccounts(int[] accountids)
        {
            AccountSet = new AccountSet(accountids);
            return AccountSet;
        }
    }
}