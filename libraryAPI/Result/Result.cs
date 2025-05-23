﻿namespace libraryAPI.Result
{
    public class Result<T>
    {
        public T? Value { get; }
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public Error Error { get; }

        private Result(T? value, bool isSuccess, Error error)
        {
            Value = value;
            IsSuccess = isSuccess;
            Error = error;
        }

        public static Result<T> Success(T? value) => new(value, true, Error.None);
        public static Result<T> Failure(Error error) => new(default, false, error);
    }
}
