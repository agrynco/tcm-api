using System.Collections;
using System.Text;

namespace Common.ToStringConverters;

public class EnumerableToStringConverter : BaseToStringConverter<IEnumerable>
{
    public override string Convert(IEnumerable value)
    {
        var stringBuilder = new StringBuilder();
        foreach (object o in value)
        {
            if (stringBuilder.Length != 0)
            {
                stringBuilder.Append(", ");
            }

            stringBuilder.Append(ToStringConverter.Instance.Convert(o));
        }

        return stringBuilder.Insert(0, '(').Append(')').ToString();
    }
}