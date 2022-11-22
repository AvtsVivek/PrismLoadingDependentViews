using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrismShell.Core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DependentViewAttribute : Attribute
    {
        public Type Type { get; set; }
        public string TargetRegionName { get; set; }

        public DependentViewAttribute(Type viewType, string targetRegionName)
        {
            Type = viewType;
            TargetRegionName = targetRegionName;
        }
    }
}
