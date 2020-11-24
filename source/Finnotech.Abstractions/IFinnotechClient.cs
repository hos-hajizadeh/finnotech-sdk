using Finnotech.Abstractions.Card;
using Finnotech.Abstractions.Facility;
using Finnotech.Abstractions.Oak;

namespace Finnotech.Abstractions
{
    public interface IFinnotechClient
    {
        ICardService CardService { get; }

        IFacilityService FacilityService { get; }

        IOakService OakService { get; }
    }
}