using SystemException = System.Exception;

namespace CustomerApi.BusinessLayer.ExceptionManagment.Exception
{
    public abstract class ExceptionBase : SystemException
    {
        public ExceptionBase()
        {

        }
        public ExceptionBase(string message) : base(message)
        {

        }

        public abstract void OnExceptionThrow();
    }
}
