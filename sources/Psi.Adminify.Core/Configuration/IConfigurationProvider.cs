namespace Psi.Adminify.Core.Configuration
{
    /// <summary>
    /// An interface to the configuration provider.
    /// </summary>
    public interface IConfigurationProvider
    {
        /// <summary>
        /// Gets the string value of setting <paramref name="key"/>.
        /// </summary>
        /// <param name="key">The setting key.</param>
        /// <param name="default">The default value. It will be used if no setting is found.</param>
        /// <returns>
        /// String representation of the setting if it is found or <paramref name="default" /> or null 
        /// if the default value is not passed. 
        /// </returns>
        string Get(string key, string @default = null);
        
        /// <summary>
        /// Checks that setting <paramref name="key"/> is presented.
        /// </summary>
        /// <param name="key">The settings key.</param>
        /// <returns>
        /// True if setting is found itherwise false.
        /// </returns>
        bool HasSetting(string key);
    }
}
