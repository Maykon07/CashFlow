using Bogus;
using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;

namespace CommonTestUtilities.Requests
{
    public class RequestsRegisterExpensesJsonBilder
    {
        public RequestsRegisterExpensesJson Build()
        {
            //var faker = new Faker();
            //var request = new RequestsRegisterExpensesJson
            //{
            //    Title = faker.Commerce.ProductName(),
            //    Description = faker.Lorem.Sentence(),
            //    Date = faker.Date.Past(),
            //    Amount = faker.Random.Decimal(1, 1000),
            //    PaymentType = faker.PickRandom<CashFlow.Communication.Enums.PaymentType>()
            //};

            return new Faker<RequestsRegisterExpensesJson>()
                .RuleFor(r => r.Title, f => f.Commerce.ProductName())
                .RuleFor(r => r.Description, f => f.Commerce.ProductDescription())
                .RuleFor(r => r.Date, f => f.Date.Past())
                .RuleFor(r => r.Amount, f => f.Random.Decimal(1, 1000))
                .RuleFor(r => r.PaymentType, f => f.PickRandom<PaymentType>());
        }
    }
}
