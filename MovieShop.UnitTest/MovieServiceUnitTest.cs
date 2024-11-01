using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Services;
using Moq;
using System.Linq.Expressions;

namespace MovieShop.UnitTest
{
    [TestClass]
    public class MovieServiceUnitTest
    {
        private MovieServiceAsync _sut;
        private Mock<IMovieRepositoryAsync> _mockMovieRepositoryAsync;

        [ClassInitialize]
        public void OneTimeSetup()
        {

        }

        [TestInitialize]
        public void Setup()
        {
            _mockMovieRepositoryAsync = new Mock<IMovieRepositoryAsync>();
            _sut = new MovieServiceAsync(_mockMovieRepositoryAsync.Object);
        }

        [TestMethod]
        public async Task TestOf_GetAll_Movie_Returns_Movies()
        {
            var movies = await _sut.GetAll();
            Assert.IsNotNull(movies);
        }
    }

   
}