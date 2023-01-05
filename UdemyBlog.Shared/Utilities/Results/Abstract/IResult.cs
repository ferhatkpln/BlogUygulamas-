﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyBlog.Shared.Utilities.Results.ComplexTypes;

namespace UdemyBlog.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get;} // ResultStatus.Success // ResultStatus.Error
        public string Message { get;}
        public Exception Exception { get;}
    }
}
