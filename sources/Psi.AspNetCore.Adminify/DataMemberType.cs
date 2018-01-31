namespace Psi.AspNetCore.Adminify
{
    public enum DataMemberType : byte
    {
        Text = 1,
        Password,
        Numeric,
        Bool,
        Enum,
        DateTime,
        File,
        Image,
        Binary        
    }
}