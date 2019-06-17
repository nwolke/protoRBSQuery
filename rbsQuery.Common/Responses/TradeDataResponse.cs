using System.Text;

namespace rbsQuery.Common.Responses
{
    public class TradeDataResponse
    {
        public bool IsSuccess { get; set; }
        public AccountResponse[] Accounts { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Success" + IsSuccess.ToString());
            if (!IsSuccess)
            {
                sb.AppendLine("Message: " + Message);
            }
            else
            {
                foreach (var account in Accounts)
                {
                    sb.AppendLine("Account: " + account.ToString());
                }
            }
            return sb.ToString();
        }
    }
}