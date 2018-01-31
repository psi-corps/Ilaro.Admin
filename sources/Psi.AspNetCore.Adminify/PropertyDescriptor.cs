namespace Psi.AspNetCore.Adminify
{
    using System.Reflection;
    using static System.String;

    
    public class PropertyDescriptor
    {
        private string _column;
        
        
        
        public string Name { get; }

        public EntityDescriptor Owner { get; }

        public PropertyInfo Info { get; }
        
        public PropertyTypeDescriptor Type { get; }        

        
        
        public string Column
        {
            get => _column;
            set => _column = value.StartsWith("[") && value.EndsWith("]") ? value : $"[{value}]";
        }        
        
        
        
        public string Display { get; }

        public string Group { get; }

        public string Description { get; }

        public string Prompt { get; }

        public string Format { get; }         
        
        
        
        public bool IsVisible { get; }

        public bool IsSearchable { get; }

        public bool IsRequired { get; }



        public bool IsKey { get; }


        
        public bool IsForeignKey { get; }
        
        public EntityDescriptor ForeignEntity { get; }

        public string ForeignKeyName { get; }

        public string ForeignEntityName { get; }

        public PropertyDescriptor ReferenceProperty { get; }

        public string ReferencePropertyName { get; }



        public bool IsAutoKey => IsKey && Type.DataMemberType != DataMemberType.Text
            && Type.DataMemberType != DataMemberType.Password && !(IsForeignKey || Type.IsCollection); 



    }
    
    
//    public class Property
//    {
//        public CascadeOption CascadeOption { get; internal set; }
//        public FileOptions FileOptions { get; internal set; } = new FileOptions();
//        public PropertyTemplate Template { get; internal set; } = new PropertyTemplate();
//
//        public IList<ValidationAttribute> Validators { get; internal set; } = new List<ValidationAttribute>();
//
//        public IDictionary<string, object> ControlsAttributes { get; set; }
//        public string ForeignKeyName { get; private set; }
//        public object OnCreateDefaultValue { get; internal set; }
//        public object OnUpdateDefaultValue { get; internal set; }
//        public object OnDeleteDefaultValue { get; internal set; }
//
//        public bool IsCreatable { get; internal set; } = true;
//        public bool IsTimestamp { get; internal set; }
//        public bool IsConcurrencyCheck { get; internal set; }
//        public OrderType? DefaultOrder { get; internal set; }
//        public object DefaultFilter { get; internal set; }
//        public bool IsFilterable { get; internal set; }
//        public bool IsManyToMany { get; internal set; }
//
//        public Property(EntityDescriptor entity, PropertyInfo property)
//        {
//            if (property == null)
//                throw new ArgumentNullException(nameof(property));
//            if (entity == null)
//                throw new ArgumentNullException(nameof(entity));
//
//            Entity = entity;
//            PropertyInfo = property;
//
//            Name = property.Name;
//            Column = property.Name;
//            ControlsAttributes = new Dictionary<string, object>();
//
//            TypeInfo = new PropertyTypeInfo(property.PropertyType);
//
//            if (TypeInfo.DataType == DataMemberType.Numeric)
//            {
//                if (TypeInfo.IsFloatingPoint)
//                {
//                    ControlsAttributes.Add("data-number-number-of-decimals", "4");
//                }
//                if (TypeInfo.IsNullable)
//                {
//                    ControlsAttributes.Add("data-number-value", "");
//                }
//            }
//
//            SetForeignKey();
//
//            Display = Name.SplitCamelCase();
//        }
//
//        internal void SetForeignKey(string foreignKeyName)
//        {
//            ForeignKeyName = foreignKeyName;
//            if (ForeignKeyName.IsNullOrEmpty() == false)
//            {
//                IsForeignKey = true;
//
//                if (TypeInfo.IsSystemType)
//                {
//                    ForeignEntityName = ForeignKeyName;
//                }
//                else
//                {
//                    ReferencePropertyName = Column = ForeignKeyName;
//                    ForeignEntityName = TypeInfo.OriginalType.Name;
//                }
//            }
//        }
//
//        private void SetForeignKey()
//        {
//            if (TypeInfo.IsSystemType || TypeInfo.IsEnum)
//            {
//                IsForeignKey = false;
//            }
//            else
//            {
//                IsForeignKey = true;
//                ForeignEntityName = TypeInfo.OriginalType.Name;
//            }
//        }
//    }
}