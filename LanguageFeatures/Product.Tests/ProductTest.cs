using System;
using Xunit;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Controllers;

namespace Product.Tests
{
    public class ProductTests
    {
        [Fact]
        public void CanChangeProductname()
        {
            //Arrange
            var p = new Product { Name = "Hat", Price = 9.99M };

            //Act
            p.Name = "Shoe";

            //Assert
            Assert.Equal("Shoe", p.Name);

        }
    }
}

