using SymbolicLinkerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SymbolicLinkerApp.Core.Utils.Converters
{
    public class TargetFileTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string stringValue)
            {
                string[] parts = stringValue.Split(new char[] { ' ', '-', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    var stateType = typeof(FileProcessState);
                    var stateConverter = TypeDescriptor.GetConverter(stateType);
                    object stateValue = stateConverter.ConvertFromInvariantString(parts[0]);
                    return new TargetFile { Name = parts[1], State = (FileProcessState)stateValue };
                }
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                if (value is TargetFile targetFile)
                {
                    var stateConverter = TypeDescriptor.GetConverter(targetFile.State);
                    string stateDescription = (string)stateConverter.ConvertTo(targetFile.State, typeof(string));
                    return targetFile.State == FileProcessState.Error ?
                        $"[{stateDescription} : {targetFile.ErrorMessage}] - {targetFile.Name}" : 
                        $"[{stateDescription}] - {targetFile.Name}";
                }
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
