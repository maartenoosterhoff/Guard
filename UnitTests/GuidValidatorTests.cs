using System;
using NUnit.Framework;

namespace Seterlund.CodeGuard.UnitTests
{
    [TestFixture]
    public class GuidValidatorTests : BaseTests
    {
        #region ----- Fixture setup -----

        /// <summary>
        /// Called once before first test is executed
        /// </summary>
        [TestFixtureSetUp]
        public void Init()
        {
            // Init tests
        }

        /// <summary>
        /// Called once after last test is executed
        /// </summary>
        [TestFixtureTearDown]
        public void Cleanup()
        {
            // Cleanup tests
        }

        #endregion

        #region ------ Test setup -----

        /// <summary>
        /// Called before each test
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Setup test
        }

        /// <summary>
        /// Called before each test
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            // Cleanup after test       
        }

        #endregion

        [Test]
        public void IsNotEmpty_ArgumentValidGuid_DoesNotThrow()
        {
            // Arrange
            var arg = Guid.NewGuid();

            // Act/Assert
            Assert.DoesNotThrow(() => Guard.That(() => arg).IsNotEmpty());
        }

        [Test]
        public void IsNotEmpty_ArgumentIsEmpty_Throws()
        {
            // Arrange
            var arg = Guid.Empty;

            // Act/Assert
            Assert.Throws<ArgumentException>(() => Guard.That(() => arg).IsNotEmpty());
        }
    }
}
