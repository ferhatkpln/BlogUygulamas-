using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyBlog.Shared.Utilities.Results.Abstract;
using UdemyBlog.Shared.Utilities.Results.ComplexTypes;

namespace UdemyBlog.Shared.Utilities.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(ResultStatus resultStatus,T data)
        {
            resultStatus = ResultStatus;
            data = Data;
        }
        public DataResult(ResultStatus resultStatus,string message, T data)
        {
            resultStatus = ResultStatus;
            message = Message;
            data = Data;
        }
        public DataResult(ResultStatus resultStatus, string message, T data,Exception exception)
        {
            resultStatus = ResultStatus;
            message = Message;
            data = Data;
            exception = Exception;
        }
        public T Data => throw new NotImplementedException();

        public ResultStatus ResultStatus => throw new NotImplementedException();

        public string Message => throw new NotImplementedException();

        public Exception Exception => throw new NotImplementedException();
    }
}
