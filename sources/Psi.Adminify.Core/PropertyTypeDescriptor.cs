using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace Psi.Adminify.Core
{
    public class PropertyTypeDescriptor
    {
        public PropertyTypeDescriptor(Type type)
        {
            OriginalType = type;
        }
        
        //public DataMemberType DataMemberType { get; }

        //public bool IsSystemType { get; }
        
        //public bool IsCollection { get; }

        public bool IsBoolean => SystemTypeCode == TypeCode.Boolean;

        public bool IsInteger => IsIntegerType(OriginalType) || IsIntegerType(UnderlyingType);

        public bool IsFloatingPoint => IsFloatingPointType(OriginalType) || IsFloatingPointType(UnderlyingType);

        public bool IsNumeric => IsInteger || IsFloatingPoint;

        public bool IsBool => SystemTypeCode == TypeCode.Boolean;

        public bool IsGuid => NotNullableType == typeof(Guid);

        //public bool IsAvailableForSearch
        //{
        //    get { return TypeInfo.IsAvailableForSearch(OriginalType); }
        //}

        public bool IsEnum => OriginalType.IsEnum;

        public bool IsNullable => OriginalType.IsNullableValueType();

        public bool IsString => OriginalType == typeof(string);

        //public bool IsFileStoredInDb => IsFile && IsString == false;

        //public bool IsImage
        //{
        //    get { return DataType == DataType.Image; }
        //}

        //public bool IsFile
        //{
        //    get { return DataType == DataType.Image || DataType == DataType.File; }
        //}
        
        
        public Type OriginalType { get; }

        public Type UnderlyingType => Nullable.GetUnderlyingType(OriginalType);

        public Type NotNullableType => UnderlyingType ?? OriginalType;

        //public SystemDataType SourceDataType { get; internal set; }

        public Type EnumType { get; internal set; }

        public TypeCode SystemTypeCode => Type.GetTypeCode(OriginalType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsIntegerType(Type type)
        {
            var typeCode = Type.GetTypeCode(type);

            return typeCode == TypeCode.Byte || typeCode == TypeCode.SByte
                   || typeCode == TypeCode.Int16 || typeCode == TypeCode.UInt16
                   || typeCode == TypeCode.Int32 || typeCode == TypeCode.UInt32
                   || typeCode == TypeCode.Int64 || typeCode == TypeCode.UInt64;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsFloatingPointType(Type type)
        {
            var typeCode = Type.GetTypeCode(type);
            return typeCode == TypeCode.Single || typeCode == TypeCode.Double || typeCode == TypeCode.Decimal;
        }
    }
}

/*
        public PropertyTypeInfo(Type type)
        {
            OriginalType = type;
            DeterminePropertyInfo();
            SetDataType();
        }

        public Type GetPropertyType()
        {
            return DataType == DataType.Enum ?
                EnumType :
                NotNullableType;
        }

        private void DeterminePropertyInfo()
        {
            // for example for string PropertyType.GetInterface("IEnumerable`1") 
            // is not null, so we must check if type has sub type 
            IsCollection =
                OriginalType.GetInterface("IEnumerable`1") != null &&
                OriginalType.GetGenericArguments().Any();
            if (IsCollection)
            {
                var subType = OriginalType.GetGenericArguments().Single();
                OriginalType = subType;
            }

            IsSystemType = OriginalType.Namespace.StartsWith("System");
        }

        private void SetDataType()
        {
            if (OriginalType.IsEnum)
            {
                DataType = DataType.Enum;
                EnumType = OriginalType;
            }
            else if (TypeInfo.IsNumber(OriginalType))
            {
                DataType = DataType.Numeric;
            }
            else if (OriginalType.In(typeof(DateTime), typeof(DateTime?)))
            {
                DataType = DataType.DateTime;
            }
            else if (OriginalType.In(typeof(bool), typeof(bool?)))
            {
                DataType = DataType.Bool;
            }
            else if (OriginalType == typeof(byte[]))
            {
                DataType = DataType.File;
            }
            else
            {
                DataType = DataType.Text;
            }
        }
*/