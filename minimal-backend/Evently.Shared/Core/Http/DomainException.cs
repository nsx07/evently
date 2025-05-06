using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evently.Shared.Core.Http
{
    public class DomainException : Exception
    {
        public string? ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }
        public List<string>? Errors { get; set; }

        public DomainException(string? errorCode, string? errorMessage, List<string>? errors = null)
            : base(errorMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            Errors = errors;
        }

        public DomainException(string? errorMessage, List<string>? errors = null)
            : base(errorMessage)
        {
            ErrorMessage = errorMessage;
            Errors = errors;
        }

        public DomainException(string? errorMessage)
            : base(errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
