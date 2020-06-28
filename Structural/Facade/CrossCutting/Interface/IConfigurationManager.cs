using System;
namespace Facade.CrossCutting.Interface
{
    public interface IConfigurationManager
    {
        string GetApiKey();
        string GetEncriptionKey();
    }
}
