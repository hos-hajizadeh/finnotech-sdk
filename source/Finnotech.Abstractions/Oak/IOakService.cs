using Finnotech.Abstractions.Core;
using Finnotech.Abstractions.Oak.Models;
using Refit;
using System.Threading.Tasks;

namespace Finnotech.Abstractions.Oak
{
    public interface IOakService
    {
        /// <summary>
        /// <b>استعلام شماره شبا</b>
        /// <br/>
        /// شرح: سرویس اطلاعات شبا
        /// <a href="https://devbeta.finnotech.ir/oak-ibanInquiry.html?sandbox=undefined">see Doc</a>
        /// </summary>
        [Get("/oak/v2/clients/{clientId}/ibanInquiry?trackId={trackId}&iban={iban}")]
        Task<Response<IbanInquiryResult>> IbanInquiryAsync(string trackId, string iban, string clientId, [Header("Authorization")] string authorization);

        /// <summary>
        /// <b>واریز به حساب دیگری</b>
        /// <br/>
        /// شرح: ‫ سرویس انتفال وجه (داخلی، پایا و ساتنا) از حساب کلاینت به حساب دیگران،
        /// <br/>
        /// با استفاده از این سرویس می‌‌توانید از حساب خود در بانک به شماره شبا سایر بانک‌ها و شماره حساب‌ بانک آینده پول واریز کنید
        /// <a href="https://devbeta.finnotech.ir/oak-transferTo-deposit.html?sandbox=undefined">see Doc</a>
        /// </summary>
        [Post("/oak/v2/clients/{clientId}/transferTo?trackId={trackId}")]
        Task<Response<TransferToResult>> TransferToAsync(string trackId, string clientId, [Header("Authorization")] string authorization, [Body] TransferToRequest request);


        /// <summary>
        /// <b>استعلام تراکنش داخلی</b>
        /// <br/>
        /// شرح: ‫ این سرویس با دریافت trackId که همراه درخواست انتقال وجه ارسال کرده‌اید وضعیت تراکنش را استعلام می‌کند.
        /// <a href="https://devbeta.finnotech.ir/oak-transferInquiry.html">see Doc</a>
        /// </summary>
        [Get("/oak/v2/clients/{clientId}/transferInquiry?trackId={trackId}&inquiryTrackId={inquiryTrackId}")]
        Task<Response<TransferToResult>> TransferInquiryAsync(string trackId, string inquiryTrackId, string clientId, [Header("Authorization")] string authorization);

        /// <summary>
        /// <b>گزارش پایا</b>
        /// <br/>
        /// شرح: سرویس دریافت گزارش پایا حساب
        /// <a href="https://devbeta.finnotech.ir/oak-payas.html">see Doc</a>
        /// </summary>
        [Get("/oak/v2/clients/{clientId}/deposits/{deposits}/payas?trackId={trackId}&fromDate={fromDate}&toDate={toDate}&offset={offset}&length={length}")]
        Task<Response<TransferToResult>> PayasAsync(string trackId, string deposits, string fromDate, string toDate, string offset, int length, string clientId, [Header("Authorization")] string authorization);
    }
}
