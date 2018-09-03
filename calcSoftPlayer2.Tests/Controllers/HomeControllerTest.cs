using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calcSoftPlayer2;
using calcSoftPlayer2.Controllers;
using calcSoftPlayer2.Models;

namespace calcSoftPlayer2.Tests.Controllers
{
  [TestClass]
  public class HomeControllerTest
  {
    HomeController controller;

    [TestInitialize]
    public void TestInitialize()
    {
      controller = new HomeController()
    }

    [TestMethod]
    public void Index()
    {
      ViewResult result = controller.Index() as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    [TestMethod]
    public void About()
    {
    
      // Act
      ViewResult result = controller.About() as ViewResult;

      // Assert
      Assert.AreEqual("Your application description page.", result.ViewBag.Message);
    }

    [TestMethod]
    public void Contact()
    {
      // Act
      ViewResult result = controller.Contact() as ViewResult;

      // Assert
      Assert.IsNotNull(result);
    }

    /// <summary>
    /// Teste unitário para validar quando o valor for 100 e o tempo for 5, retornar 105,01 em decimal.
    /// </summary>
    [TestMethod]
    public void TestaCalculoJuros_QuandoInforma100Valor5Tempo_Retorna10501()
    {
      Calculo novoCalculo = new Calculo();

      decimal result = novoCalculo.calculaJuros(100, 5, 2);

      Assert.AreEqual(result, 105.01);
    }

  }
}
