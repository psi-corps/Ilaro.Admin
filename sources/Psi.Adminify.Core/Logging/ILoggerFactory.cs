namespace Psi.Adminify.Core.Logging
{
    /// <summary>
    /// An interface to the logger factory.
    /// </summary>
    public interface ILoggerFactory
    {
        /// <summary>
        /// Gets the logger by <paramref name="key"/>.
        /// </summary>
        /// <param name="key">The logger key,</param>
        /// <returns>
        /// An instance of the <see cref="ILogger"/> implementation.
        /// </returns>
        ILogger Get(object key);
    }
}