using System.Collections.Generic;

namespace GangOfFourDesignPatterns.Structural.Adapter
{
    /// <summary>
    /// ITarget interface which define a contract or expected 
    /// method to implemented in Adapter class
    /// </summary>
    public interface IEmailSystemCatalog
    {
        List<string> GetEmails();
    }
}