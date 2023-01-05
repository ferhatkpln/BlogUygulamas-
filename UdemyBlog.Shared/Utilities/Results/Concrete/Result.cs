using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyBlog.Shared.Utilities.Results.Abstract;
using UdemyBlog.Shared.Utilities.Results.ComplexTypes;

namespace UdemyBlog.Shared.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(ResultStatus resultStatus)
        {
            resultStatus = ResultStatus;
        }
        public Result(ResultStatus resultStatus, string message)
        {
            resultStatus = ResultStatus;
            message = Message;
        }
        public Result(ResultStatus resultStatus, string message, Exception exception)
        {
            resultStatus = ResultStatus;
            message = Message;
            exception = Exception;
        }
        public ResultStatus ResultStatus => throw new NotImplementedException();

        public string Message => throw new NotImplementedException();

        public Exception Exception => throw new NotImplementedException();
        //new Result(ResultStatus.Error,exception.message,exception)
    }
}
