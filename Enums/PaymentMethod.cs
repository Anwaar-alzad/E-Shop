using System.ComponentModel.DataAnnotations;

namespace E_shopSystem;

public enum PaymentMethod
{
    [Display(Name = "Cash")]
    Cash,

    [Display(Name = "Credit Card")]
    CreditCard,

    [Display(Name = "Debit Card")]
    DebitCard,

    [Display(Name = "PayPal")]
    PayPal,

    [Display(Name = "Apple Pay")]
    ApplePay,

    [Display(Name = "Google Pay")]
    GooglePay,

    [Display(Name = "Bank Transfer")]
    BankTransfer
}
