using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace Psi.Adminify.Core
{
    /// <summary>
    /// Describes an entity.
    /// </summary>
    public class EntityDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDescriptor"/>.
        /// </summary>
        /// <param name="type">The entity type.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="type"/> is null.</exception>
        public EntityDescriptor(Type type)
        {
            Type = type ?? throw new ArgumentNullException(nameof(type));
            //Verbose = new Verbose(Type);

            Properties = type
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Select(p => new PropertyDescriptor(p))
                .ToList();

//            if (IsChangeEntity)
//            {
//                AllowAdd = AllowEdit = AllowDelete = false;
//            }

            // check if has ToString() method
//            HasToStringMethod =
//                Type.GetMethod("ToString")
//                    .DeclaringType.Name != "Object";


            //SetTableName(Name.Pluralize());
        }

        /// <summary>
        /// Gets the entity type.
        /// </summary>
        public Type Type { get; }

        /// <summary>
        /// Gets the entity name.
        /// </summary>
        public string Name => Type.Name;

        ///// <summary>
        ///// Gets the table name.
        ///// </summary>
        //public string Table { get; }

//        /// <summary>
//        /// Gets the verbose.
//        /// </summary>
//        public Verbose Verbose { get; }

        /// <summary>
        /// Gets properties.
        /// </summary>
        public IReadOnlyList<PropertyDescriptor> Properties { get; }

//        /// <summary>
//        /// Gets grouping properties.
//        /// </summary>
//        public IReadOnlyList<GroupProperties> GroupProperties { get; } = new List<GroupProperties>();



        public bool CanAdd { get; } = true;
        public bool CanEdit { get; } = true;
        public bool CanDelete { get; } = true;


//        public Links Links { get; } = new Links();

        public string DisplayFormat { get; internal set; }

        //public bool HasToStringMethod { get; }
        public bool SoftDeleteEnabled { get; internal set; }

        public bool ConcurrencyCheckEnabled { get; internal set; }

        public PropertyDescriptor this[string name] => Properties.FirstOrDefault(p => p.Name == name);



//        internal void SetTableName(string table, string schema = null)
//        {
//            if (!schema.IsNullOrEmpty())
//            {
//                Table = "[" + schema + "].[" + table + "]";
//            }
//            else
//            {
//                Table = "[" + table + "]";
//            }
//        }

    }
}
