using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoInsuranceQuotes.Controllers;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoInsuranceQuotes.Models;

namespace AutoInsuranceQuotes.Tests
{
    [TestClass]
    public class ControllersTest
    {

        [TestMethod]
        public void DetailsControllerResponseNotNull()
        {
            //Arrange
            DetailsController controller = new DetailsController();

            //Act
            var response = controller.Get(998) as Task<AutoQuote>;

            //Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void FormerInsurersControllerResponseNotNull()
        {
            //Arrange
            FormerInsurersController controller = new FormerInsurersController();

            //Act
            var response = controller.Get() as Task<IEnumerable<string>>;

            //Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void QuotesControllerResponseNotNull()
        {
            //Arrange
            QuotesController controller = new QuotesController();

            //Act
            var response = controller.Get(1, "WV", "Chevrolet", "That Big Company") as Task<List<AutoQuote>>;

            //Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void StatesControllerResponseNotNull()
        {
            //Arrange
            StatesController controller = new StatesController();

            //Act
            var response = controller.Get() as Task<IEnumerable<string>>;

            //Assert
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void VehicleMakesControllerResponseNotNull()
        {
            //Arrange
            VehicleMakesController controller = new VehicleMakesController();

            //Act
            var response = controller.Get() as Task<IEnumerable<string>>;

            //Assert
            Assert.IsNotNull(response);
        }
    }
}
