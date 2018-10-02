using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatientManagement.Core
{
    public class EnumLabelConverter
    {
        public string GetLabelByEnum<E, L>(E enumValue)
        {
            var enumName = enumValue.GetType().GetEnumName(enumValue);
            var labelField = typeof(L).GetField(enumName);
            if (labelField == null)
            {
                throw new InvalidOperationException("Could not find the label field");
            }
            return (labelField.GetValue(null)) as string;
        }

        public E GetEnumByLabel<E, L>(string label)
        {
            foreach (var item in typeof(L).GetFields())
            {
                var value = (string)item.GetValue(null);
                if (value == label)
                {
                    var names = Enum.GetNames(typeof(E));
                    foreach (var enumName in names)
                    {
                        if (enumName == item.Name)
                        {
                            return (E)typeof(E).GetField(enumName).GetRawConstantValue();
                        }
                    }
                }
            }
            throw new InvalidOperationException("Could not find the value of enum");
        }
    }
}
