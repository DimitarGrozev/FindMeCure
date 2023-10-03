﻿namespace ECommerce.Contracts
{
    public class Response<T>
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public T Value { get; set; }
    }
}
