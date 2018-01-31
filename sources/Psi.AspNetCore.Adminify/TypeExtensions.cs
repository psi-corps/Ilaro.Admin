using System;

namespace Psi.AspNetCore.Adminify
{
    public static class TypeExtensions
    {
        public static bool IsBoolean(this Type @this) => @this == typeof(bool) || @this == typeof(bool?);
    }
}