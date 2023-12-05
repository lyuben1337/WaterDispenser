using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Models
{
    public static class LogFileManager
    {
        public static void SaveLogs(LinkedList<Log> logs, string filePath)
        {
            string json = JsonSerializer.Serialize(logs);
            File.WriteAllText(filePath, json);
        }
    }
}
