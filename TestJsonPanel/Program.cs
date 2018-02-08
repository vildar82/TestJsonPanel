using Newtonsoft.Json;
using System;
using System.IO;
using TestJsonPanel.Data;

namespace TestJsonPanel
{
    internal static class Program
    {
        private static void Main()
        {
            const string panelFile = "3НСНг-Б1.2-419.294.42-3.json";
            var json = File.ReadAllText(panelFile);
            var panel = JsonConvert.DeserializeObject<Panel>(json);
            Console.Write(JsonConvert.SerializeObject(panel, Formatting.Indented));
            Console.Read();
        }
    }
}