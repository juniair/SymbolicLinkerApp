using SymbolicLinkerApp.Core.Utils.Attributes;
using SymbolicLinkerApp.Core.Utils.Converters;
using System.ComponentModel;

namespace SymbolicLinkerApp.Core.Models
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum FileProcessState
    {
        [LocalizedDescription("Wait", typeof(Properties.Resources))]
        Wait,
        [LocalizedDescription("Progress", typeof(Properties.Resources))]
        Progress,
        [LocalizedDescription("Complete", typeof(Properties.Resources))]
        Complete,
        [LocalizedDescription("Duplicate", typeof(Properties.Resources))]
        Duplicate,
        [LocalizedDescription("Error", typeof(Properties.Resources))]
        Error
    }

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum SymbolicLinkType
    {
        [LocalizedDescription("Relative", typeof(Properties.Resources))]
        Relative,
        [LocalizedDescription("Absolute", typeof(Properties.Resources))]
        Absolute
    }
}
