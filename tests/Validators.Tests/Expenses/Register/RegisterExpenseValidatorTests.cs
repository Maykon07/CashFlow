using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Exception;
using CommonTestUtilities.Requests;
using FluentAssertions;

namespace Validators.Tests.Expenses.Register
{
    public class RegisterExpenseValidatorTests
    {
        [Fact]
        public void Success()
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestsRegisterExpensesJsonBilder.Build();
            //Act
            var result = validator.Validate(request);

            //Assert
            result.IsValid.Should().BeTrue();
        }

        [Theory]
        [InlineData("")]
        [InlineData("  ")]
        [InlineData(null)]
        public void Error_Title_Empty(string title)
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestsRegisterExpensesJsonBilder.Build();
            request.Title = string.Empty;
            //Act
            var result = validator.Validate(request);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessages.TITLE_REQUIRED));
        }
        [Fact]
        public void Error_Date_Future()
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestsRegisterExpensesJsonBilder.Build();
            request.Date = DateTime.UtcNow.AddDays(1);
            //Act
            var result = validator.Validate(request);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessages.EXPENSES_CANNOT_FOR_THE_FUTURE));
        }
        [Fact]
        public void Error_Paymente_Type_Ivalid()
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestsRegisterExpensesJsonBilder.Build();
            request.PaymentType = (PaymentType)999;
            //Act
            var result = validator.Validate(request);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessages.PAYMENT_TYPE_INVALID));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Error_Amount_Invalid(decimal amount)
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = RequestsRegisterExpensesJsonBilder.Build();
            request.Amount = amount;
            //Act
            var result = validator.Validate(request);
            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessages.AMOUNT_MUSTE_BE_GREATER_THA_ZERO));
        }
    }
   
}

