﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results
{
    public class Result : IResult
    {
        
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool succes)
        {
            Success = succes;
        }

        public bool Success { get; }

        public string Message { get; }

       
    }
}
