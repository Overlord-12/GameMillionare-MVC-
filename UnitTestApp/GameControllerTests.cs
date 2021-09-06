using GameMillionare_MVC_.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Xunit;

namespace UnitTestApp
{
    public class GameControllerTests
    {
        [Fact]
        public void IndexViewResultNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void ProcessGameNotNull()
        {
            // Arrange
            GameController controller = new GameController();
            // Act
            ViewResult result = controller.EndGame() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }
    }
}
