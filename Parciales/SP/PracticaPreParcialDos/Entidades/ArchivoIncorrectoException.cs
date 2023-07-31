using System;
using System.Runtime.Serialization;

namespace Entidades
{
    public class ArchivoIncorrectoException : Exception
    {
        public ArchivoIncorrectoException()
        {
        }

        public ArchivoIncorrectoException(string message) : base(message)
        {
        }


    }
}