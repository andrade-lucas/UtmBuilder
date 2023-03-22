using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core;

public class Utm
{
    /// <summaty>
    /// URL (Website link)
    /// </summaty>
    public Url Url { get; }

    /// <summaty>
    /// Campaign details
    /// </summaty>
    public Campaign Campaign { get; }

    public Utm(Url url, Campaign campaign)
    {
        Url = url;
        Campaign = campaign;
    }
}
