using Evently.Shared.Core.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evently.Shared.Core.Assertion
{
    public class AssertionConcern
    {
        public static void AssertArgumentNotNull(object? argument, string message, string? code = null)
        {
            if (argument == null)
                throw new DomainException(code, message);
        }
        public static void AssertArgumentNotEmpty(string argument, string message, string? code = null)
        {
            if (string.IsNullOrEmpty(argument))
                throw new DomainException(code, message);
        }
        public static void AssertArgumentLength(string argument, int minLength, int maxLength, string message, string? code = null)
        {
            if (argument.Length < minLength || argument.Length > maxLength)
                throw new DomainException(code, message);
        }

        public static void AssertArgumentEqual(string argument, string expected, string message, string? code = null)
        {
            if (!argument.Equals(expected))
                throw new DomainException(code, message);
        }
    }
}
