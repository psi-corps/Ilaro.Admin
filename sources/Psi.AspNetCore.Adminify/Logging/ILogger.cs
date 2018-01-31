namespace Psi.AspNetCore.Adminify.Logging
{
    using System;
    using System.Threading.Tasks;
    
    
    /// <summary>
    /// An interface to the logger.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="severity"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<Guid> Log(Severity severity, Func<object> message);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="severity"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task<Guid> Log(Severity severity, object message);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="severity"></param>
        /// <param name="template"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<Guid> Log(Severity severity, string template, object model);
    }
}