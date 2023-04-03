using System;

namespace KarimiApp.Exceptions
{
    public class ValidateException : Exception
    {
        public ValidateException() { }
        public ValidateException(string[] parameters) : base("فیلدهای :\n" + parameters.ArrayToString() + "" + "الزامی است") { }
        public ValidateException(string[] parameters, Exception inner) : base("مقادیر :\n" + parameters.ArrayToString() + "\n" + "الزامی است", inner)
        {

        }
        protected ValidateException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
