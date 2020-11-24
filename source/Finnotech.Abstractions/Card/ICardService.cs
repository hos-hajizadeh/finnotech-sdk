using Finnotech.Abstractions.Card.Models;
using Finnotech.Abstractions.Core;
using Refit;
using System.Threading.Tasks;

namespace Finnotech.Abstractions.Card
{
    /// <summary>
    /// سرویس‌های مبتنی بر کارت
    /// </summary>
    public interface ICardService
    {
        /// <summary>
        /// <b>استعلام شماره کارت</b>
        /// <br/>
        /// شرح: برای استعلام شماره کارت های عضو شتاب از این سرویس استفاده کنید.
        /// <a href="https://devbeta.finnotech.ir/card-information.html?sandbox=undefined">see</a>
        /// </summary>
        [Get("/mpg/v2/clients/{clientId}/cards/{card}?trackId={trackId}")]
        Task<Response<CardInformationResult>> CardInformationAsync(string trackId, string card, string clientId, [Header("Authorization")] string authorization);
    }
}
