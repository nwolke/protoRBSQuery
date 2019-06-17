namespace rbsQuery.Common.Requests
{
    public class ClientRequest
    {
        public int ClientId { get; private set; }

        public ClientRequest(int clientId)
        {
            ClientId = clientId;
        }
    }
}