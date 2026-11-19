namespace CashFlow.Communication.Responses
{
    public class ResponseErrorJsom
    {
        public List<string> ErrorMessages { get; set; }

        public ResponseErrorJsom(string errorMessage)
        {
            ErrorMessages = new List<string> { errorMessage };
        }

        public ResponseErrorJsom(List<string> errorMessage)
        {
            ErrorMessages = errorMessage;
        }
    }
}
