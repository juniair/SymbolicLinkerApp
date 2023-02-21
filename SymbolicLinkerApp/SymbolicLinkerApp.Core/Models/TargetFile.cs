using SymbolicLinkerApp.Core.Utils.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolicLinkerApp.Core.Models
{
    [TypeConverter(typeof(TargetFileTypeConverter))]
    public class TargetFile
    {
        public string Name { get; set; }
        public FileProcessState State { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
