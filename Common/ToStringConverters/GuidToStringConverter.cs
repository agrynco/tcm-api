namespace Common.ToStringConverters;

public class GuidToStringConverter : BaseToStringConverter<Guid>
{
    public override string Convert(Guid value)
    {
        return string.Format("'{0}'", value);
    }
}