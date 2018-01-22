using ShopOnline.Data.Enums;

namespace ShopOnline.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}