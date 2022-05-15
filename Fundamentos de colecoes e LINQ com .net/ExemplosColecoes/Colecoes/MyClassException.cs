using System;
using System.Runtime.Serialization;

namespace Colecoes
{
   [System.Serializable]
    internal class MyClassException : Exception
    {
        public MyClassException()
        {
        }

        public MyClassException(string message) : base(message)
        {
        }

        public MyClassException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected MyClassException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}