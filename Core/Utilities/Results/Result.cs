﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {


        public Result(bool success, string message) : this(success) // çift parametreyle alttaki constructor da çalışacak mesaj gönderilise 1. ve 2. , gönderilmezse sadece 2. çalışacak.
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
