namespace rbsQuery.Common.Requests
{
    public class EnterpriseRequest
    {
        public int EnterpriseId { get; private set; }

        public EnterpriseRequest(int enterpriseId)
        {
            EnterpriseId = enterpriseId;
        }

        public ClientRequest ForClient(int clientId)
        {
            return new ClientRequest(clientId);
        }
    }

}