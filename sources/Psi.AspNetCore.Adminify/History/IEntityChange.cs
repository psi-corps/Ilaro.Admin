namespace Psi.AspNetCore.Adminify.History
{
    using System;    
    
    /// <summary>
    /// An interface to the entity history provider.
    /// </summary>
    public interface IEntityChange
    {
        /// <summary>
        /// Gets or sets the change id.
        /// </summary>
        Guid ID { get; set; }

        /// <summary>
        /// Gets or sets entity name.
        /// </summary>
        string EntityName { get; set; }

        /// <summary>
        /// Gets or sets entity key.
        /// </summary>
        object EntityKey { get; set; }
        
        /// <summary>
        /// Gets or sets the change type.
        /// </summary>
        ChangeType ChangeType { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets change date.
        /// </summary>
        DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or sets the performer of the action.
        /// </summary>
        object Performer { get; set; }
    }
}