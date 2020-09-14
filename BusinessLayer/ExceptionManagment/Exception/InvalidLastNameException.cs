namespace CustomerApi.BusinessLayer.ExceptionManagment.Exception
{
    public class InvalidLastNameException : ExceptionBase
    {
        public InvalidLastNameException() : base("نام خانوادگی وارد نشده است")
        {
        }
        public InvalidLastNameException(string message) : base(message)
        {
        }

        public override void OnExceptionThrow()
        {
            // do somethng . . . 
        }
    }
     
}
