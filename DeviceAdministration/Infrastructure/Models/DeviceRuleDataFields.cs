using System.Collections.Generic;

namespace Microsoft.Azure.Devices.Applications.RemoteMonitoring.DeviceAdmin.Infrastructure.Models
{
    public static class DeviceRuleDataFields
    {
        public static string Temperature
        { 
            get 
            { 
                return "Temperature"; 
            } 
        }

        public static string WaterLevel
        {
            get
            {
                return "WaterLevel";
            }
        }

        private static List<string> _availableDataFields = new List<string>
        {
            Temperature, WaterLevel
        };

        public static List<string> GetListOfAvailableDataFields()
        {
            return _availableDataFields;
        }
    }
}
