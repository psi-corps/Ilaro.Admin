namespace Psi.AspNetCore.Adminify.History
{
    /// <summary>
    /// Object change type.
    /// </summary>
    public enum ChangeType : byte
    {
        /// <summary>
        /// Object creation.
        /// </summary>
        Create = 1,
        
        /// <summary>
        /// Saving existing object.
        /// </summary>
        Update,
        
        /// <summary>
        /// Deleting object.
        /// </summary>
        Delete
    }
}