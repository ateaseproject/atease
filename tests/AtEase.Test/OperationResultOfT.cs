using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace AtEase.Test
{
    public class OperationResultOfTTests
    {
        [Fact]
        public void OperationResult_should_be_success_and_have_data_when_created_with_success_method()
        {

            OperationResult<int> operationResult = OperationResult<int>.Succeed(1);

            operationResult.SucceedData.Should().Be(1);
            operationResult.Errors.Should().BeEmpty();
            operationResult.Succeeded.Should().BeTrue();

        }

        [Fact]
        public void OperationResult_should_be_not_succeeded_and_dont_have_data_and_error_must_not_be_empty_when_created_with_fail_method()
        {

            string error = "the error";
            OperationResult<int> operationResult = OperationResult<int>.Failed(error);

            operationResult.SucceedData.Should().Be(default(int));
            operationResult.Errors.Should().Contain(error);
            operationResult.Succeeded.Should().BeFalse();
        }



    }
}