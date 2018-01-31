namespace Ilaro.Admin.Core
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;    

    using Customization.Customizers;    
    
    public interface IAdminify
    {
        IReadOnlyList<EntityDescriptor> Entities { get; }
        
        EntityDescriptor ChangeEntity { get; }
        bool IsChangingEnabled { get; }

        IAuthorizationFilter Authorize { get; }
        string ConnectionString { get; }
        string RoutePrefix { get; }

        void RegisterEntity(Type entityType);
        EntityCustomizer<TEntity> RegisterEntity<TEntity>() where TEntity : class;        
        void RegisterEntityWithAtributes(Type entityType);
        EntityCustomizer<TEntity> RegisterEntityWithAttributes<TEntity>() where TEntity : class;

        EntityDescriptor GetEntity(string name);
        EntityDescriptor GetEntity(Type type);
        EntityDescriptor GetEntity<TEntity>();
    }
}