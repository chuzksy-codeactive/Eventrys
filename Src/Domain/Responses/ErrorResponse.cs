using System.Collections.Generic;

namespace Eventrys.Src.Domain.Responses
{
    public class ErrorResponse
    {
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
    }
}