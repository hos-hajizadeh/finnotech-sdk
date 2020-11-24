using Finnotech.Abstractions;
using Finnotech.Abstractions.Card;
using Finnotech.Abstractions.Facility;
using Finnotech.Abstractions.Oak;
using System;

namespace Finnotech
{
    public class FinnotechClient : IFinnotechClient
    {
        public FinnotechClient(ICardService cardService,
                               IFacilityService facilityService,
                               IOakService oakService)
        {
            CardService = cardService ?? throw new ArgumentNullException(nameof(cardService));
            FacilityService = facilityService ?? throw new ArgumentNullException(nameof(facilityService));
            OakService = oakService ?? throw new ArgumentNullException(nameof(oakService));
        }

        public virtual ICardService CardService { get; }

        public virtual IFacilityService FacilityService { get; }

        public virtual IOakService OakService { get; }
    }
}
