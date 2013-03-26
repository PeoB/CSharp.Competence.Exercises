using System;
using System.Threading.Tasks;

namespace Extensions.Code
{
    public static class TaskExtensions
    {
         public static Task<T> Catch<T, TException>(this Task<T> task, T valueOnException, Action<TException> exceptionHandler)
         {
             throw new NotImplementedException();
         }
    }
}