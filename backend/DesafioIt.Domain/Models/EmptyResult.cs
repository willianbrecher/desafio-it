using System;
namespace DesafioIt.Domain.Models
{
    public class EmptyResult
    {
        public static EmptyResult New => new EmptyResult();

        public static Task<EmptyResult> NewTask => Task.FromResult(new EmptyResult());
    }
}

