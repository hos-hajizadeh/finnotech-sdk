using Finnotech.Abstractions.Core;
using Finnotech.Abstractions.Facility.Models;
using Refit;
using System.Threading.Tasks;

namespace Finnotech.Abstractions.Facility
{
    public interface IFacilityService
    {
        /// <summary>
        /// <b>تبدیل کارت به شبا</b>
        /// <br/>
        /// شرح: سرویس اطلاعات شبا
        /// <a href="https://devbeta.finnotech.ir/facility-card-to-iban.html?sandbox=undefined">see Doc</a>
        /// </summary>
        [Get("/facility/v2/clients/{clientId}/cardToIban?trackId={trackId}&card={card}")]
        Task<Response<CardToIbanResult>> CardToIbanAsync(string trackId, string card, string clientId, [Header("Authorization")] string authorization);

        /// <summary>
        /// <b>احراز هویت با کد ملی</b>
        /// <br/>
        /// شرح: احراز هویت با کد ملی، این سرویس کد ملی، تاریخ تولد و جنسیت و نام را دریافت میکند و شباهت موارد ارسال شده را با موارد واقعی صاحب کد ملی برمیگرداند. نام را هم به صورت یک فیلد و هم به صورت نام و نام خانوادگی جدا میتوانید بفرستید. این سرویس از ساعت ۲۳:۰۰ تا ساعت ۷:۰۰ غیر فعال است . در صورتی که در این بازه سرویس را فراخوانی کنید با خطای 'شما در بازه زمانی تعریف شده قرار ندارید' مواجه خواهید شد .
        /// <a href="https://devbeta.finnotech.ir/facility-nid-verification-sms.html?sandbox=undefined">see Doc</a>
        /// </summary>
        [Get("/facility/v2/clients/{clientId}/users/{nid}/sms/nidVerification?trackId={trackId}&birthDate={birthDate}&gender={gender}&fullName={fullName}&firstName={firstName}&lastName={lastName}&fatherName={fatherName}")]
        Task<Response<NidVerificationResult>> NidVerificationAsync(string trackId, string nid, string birthDate, string gender, string fullName, string firstName, string lastName, string fatherName, string clientId, [Header("Authorization")] string authorization);

        /// <summary>
        /// <b>انطباق کد ملی وشماره حساب</b>
        /// <br/>
        /// شرح: انطباق کد ملی وشماره حساب, این سرویس جهت تطبیق کدملی با امضادار شماره حساب ورودی به کار می رود
        /// <a href="https://devbeta.finnotech.ir/facility-deposit-owner-verification.html?sandbox=undefined">see Doc</a>
        /// </summary>
        [Get("/facility/v2/clients/{clientId}/depositOwnerVerification?trackId={trackId}&deposit={deposit}&bank={bank}&nationalCode={nid}")]
        Task<Response<DepositOwnerVerificationResult>> DepositOwnerVerificationAsync(string trackId, string deposit, string bank, string nid, string clientId, [Header("Authorization")] string authorization);
    }
}