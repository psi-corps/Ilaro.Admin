using System;

namespace Psi.Adminify.Core
{
    public static class TypeExtensions
    {
        public static bool IsBoolean(this Type @this) => @this == typeof(bool) || @this == typeof(bool?);

        public static bool IsNullAllowed(this Type @this) => !@this.IsValueType || @this.IsNullableValueType();

        public static bool IsNullableValueType(this Type @this) => Nullable.GetUnderlyingType(@this) != null;
    }
}
