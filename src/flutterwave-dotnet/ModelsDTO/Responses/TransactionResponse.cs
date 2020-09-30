﻿namespace Flutterwave.Net
{
    public abstract class TransactionResponse<T>
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
