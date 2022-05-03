using MathOperationService.Controllers;
using MathOperationService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MathOperationsServiceTester
{
    public class NumericalDecompositionControllerTests
    {
        [Fact]
        public void Get_All_Numerical_Decomposition_And_Validate_If_It_Is_Correct()
        {
            //Arrange
            var controller = new NumericalDecompositionController();

            //Act
            var actionResult =  controller.GetAllNumericalDecomposition(45);

            //Assert
            var ret = actionResult.Result as OkObjectResult;
            var result = ret.Value as NumericalDecomposition;

            Assert.Equal(ret.StatusCode.Value, Convert.ToChar(200));
            Assert.Equal(result.Number, Convert.ToDecimal(45));
            Assert.Equal(result.PrimeNumbers, new decimal[] { 1, 3, 5 });
            Assert.Equal(result.DivisorsNumbers, new decimal[] { 1, 3, 5, 9, 15, 45 });
        }

        [Fact]
        public void Get_All_Numerical_Decomposition_Passing_Invalid_Number()
        {
            //Arrange
            var controller = new NumericalDecompositionController();

            //Act
            var actionResult = controller.GetAllNumericalDecomposition(Convert.ToInt64("1234567891234567891"));

            //Assert
            var ret = actionResult.Result as BadRequestObjectResult;
            Assert.Equal(ret.StatusCode.Value, Convert.ToChar(400));
        }

    }
}
