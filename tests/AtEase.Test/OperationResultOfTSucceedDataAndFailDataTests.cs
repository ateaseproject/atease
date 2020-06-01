using FluentAssertions;
using Xunit;

namespace AtEase.Test
{
    public class OperationResultOfTSucceedDataAndFailDataTests
    {
        [Fact]
        public void OperationResult_should_be_success_and_have__succeed_data_when_created_with_success_method()
        {

            OperationResult<int,int> operationResult = OperationResult<int,int>.Succeed(1);

            operationResult.SucceedData.Should().Be(1);
            operationResult.Errors.Should().BeEmpty();
            operationResult.Succeeded.Should().BeTrue();
            operationResult.FailedData.Should().Be(default(int));

        }

        [Fact]
        public void OperationResult_should_be_not_succeeded_and_dont_have_succeed_data_and_error_and_failed_data_must_not_be_empty_when_created_with_fail_method()
        {

            string error = "the error";
            OperationResult<int, int> operationResult = OperationResult<int, int>.Failed(1,error);

            operationResult.SucceedData.Should().Be(default(int));
            operationResult.Errors.Should().Contain(error);
            operationResult.Succeeded.Should().BeFalse();
            operationResult.FailedData.Should().Be(1);
        }


        [Fact]
        public void OperationResult_should_be_not_succeeded_and_dont_have_succeed_data_and_failed_data_must_not_be_empty_when_created_with_fail_method()
        {

            
            OperationResult<int, int> operationResult = OperationResult<int, int>.Failed(1);

            operationResult.SucceedData.Should().Be(default(int));
            operationResult.Errors.Should().BeEmpty();
            operationResult.Succeeded.Should().BeFalse();
            operationResult.FailedData.Should().Be(1);
        }

    }
}