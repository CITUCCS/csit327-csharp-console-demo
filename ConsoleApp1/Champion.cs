using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Champion : GameAsset, IChampion
    {
        // camelCase
        // PascalCase
        // ROAD_KILL_CASE

        public string? Name { get; set; }
        public int Level { get; set; }
        
        protected Role Role; // PascalCase
        
        private string _stats; // Add _ prefix if field is private
        private bool _isAlive = false;
        
        public Champion(Role role)
        {
            Role = role;
            _stats = string.Empty;
        }
        
        public string GetStats() 
        {
            return _stats;
        }

        public void UpdateStats(string statInfo)
        {
            var statInfoTemp = "temp";
            statInfoTemp = statInfo + "yey";

            _stats = statInfoTemp;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Champion:");
            sb.AppendLine($"Name : {Name} | Role: {Role} | Level: {Level} | Stats: {_stats}");
            
            return sb.ToString();
        }
    }
}
