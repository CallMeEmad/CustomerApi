namespace CustomerApi.BusinessLayer.ExceptionManagment.Exception
{
    public class InvalidNameException : ExceptionBase
    {
        public InvalidNameException() : base("نام را وارد کنید")
        {
        }
        public InvalidNameException(string message) : base(message)
        {
        }
        public override void OnExceptionThrow()
        {
           // do somethng . . . 
        }
    }
     
}
