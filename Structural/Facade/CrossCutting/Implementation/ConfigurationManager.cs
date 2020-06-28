using System;
using System.Linq;
using Facade.CrossCutting.Interface;

namespace Facade.CrossCutting.Implementation
{
    public class ConfigurationManager : IConfigurationManager
    {
        public ConfigurationManager()
        {
        }

        public string GetApiKey()
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

        public string GetEncriptionKey()
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
