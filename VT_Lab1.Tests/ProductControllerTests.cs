using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VT_Lab1.Controllers;
using VT_Lab1.DAL.Data;
using VT_Lab1.DAL.Entities;
using Xunit;


namespace VT_Lab1.Tests
{
    public class ProductControllerTests
    {
       /* DbContextOptions<ApplicationDbContext> _options;
        public ProductControllerTests()
        {
            _options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "testDb")
            .Options;
        }

        [Theory]
        [MemberData(nameof(TestData.Params), MemberType = typeof(TestData))]
        public void ControllerGetsProperPage(int page, int qty, int id)
        {
            // Arrange 
            // Контекст контроллера
            var controllerContext = new ControllerContext();
            // Макет HttpContext
            var moqHttpContext = new Mock<HttpContext>();
            moqHttpContext.Setup(c => c.Request.Headers)
            .Returns(new HeaderDictionary());

            controllerContext.HttpContext = moqHttpContext.Object; 
            //заполнить DB данными
            using (var context = new ApplicationDbContext(_options))
            {
                TestData.FillContext(context);
            }
            using (var context = new ApplicationDbContext(_options))
            {
                // создать объект класса контроллера
                var controller = new ProductController(context)
                { ControllerContext = controllerContext };
                // Act
                var result = controller.Index(group: null, pageNo:
               page) as ViewResult;
                var model = result?.Model as List<Tile>;
                // Assert
                Assert.NotNull(model);
                Assert.Equal(qty, model.Count);
                Assert.Equal(id, model[0].TileId);
            }
            // удалить базу данных из памяти
            using (var context = new ApplicationDbContext(_options))
            {
                context.Database.EnsureDeleted();
            }
        }
        [Fact]
        public void ControllerSelectsGroup()
        {
            // arrange
            // Контекст контроллера
            var controllerContext = new ControllerContext();
            // Макет HttpContext
            var moqHttpContext = new Mock<HttpContext>();
            moqHttpContext.Setup(c => c.Request.Headers)
            .Returns(new HeaderDictionary());
            controllerContext.HttpContext = moqHttpContext.Object;
            //заполнить DB данными
            using (var context = new ApplicationDbContext(_options))
            {
                TestData.FillContext(context);
            }
            using (var context = new ApplicationDbContext(_options))
            {
                var controller = new ProductController(context)
                { ControllerContext = controllerContext };

                var comparer = Comparer<Tile>.GetComparer((d1, d2) =>
               d1.TileId.Equals(d2.TileId));
                // act
                var result = controller.Index(2) as ViewResult;
                var model = result.Model as List<Tile>;
                // assert
                Assert.Equal(2, model.Count);
                Assert.Equal(context.Tilees
                .ToArrayAsync()
               .GetAwaiter()
               .GetResult()[2], model[0], comparer);
            }
        }
    }
}*/
        /*
        [Theory]
        [InlineData(1, 3, 1)] // 1-я страница, кол. объектов 3, id первого  объекта 1
        [InlineData(2, 2, 4)] // 2-я страница, кол. объектов 2, id первого  объекта 4
        public void ControllerGetsProperPage(int page, int qty, int id)
        {
            // Arrange 
            var controller = new ProductController();
            controller._tiles = new List<Tile>
                     {
                    new Tile{ TileId=1},
                    new Tile{ TileId=2},
                    new Tile{ TileId=3},
                    new Tile{ TileId=4},
                    new Tile{ TileId=5}
                    };
            // Act
            var result = controller.Index(page) as ViewResult;
            var model = result?.Model as List<Tile>;
            // Assert
            Assert.NotNull(model);
            Assert.Equal(qty, model.Count);
            Assert.Equal(id, model[0].TileId);
        }*/
    }
}
