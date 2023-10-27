using System;
using DesafioIt.Domain.Enums;

namespace DesafioIt.Domain.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class AutoMapAttribute : Attribute
    {
        public AutoMapAttribute(Type t, AutoMapperDirections direction = AutoMapperDirections.To)
        {
            T = t;
            Direction = direction;
        }

        public Type T { get; }

        public AutoMapperDirections Direction { get; }
    }
}

