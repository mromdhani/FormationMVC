using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProduitsApp.DataAccess.Repository;

namespace ProduitsApp.DataAccess.Tests
{
    [TestClass]
    public class UnitTestProuitsRepositoryImpl
    {
        [TestMethod]
        public void TestFindById()
        {
            // Arrange
            var underTest = new ProduitsRepositoryImpl();
            var id = "P100";
            var libelle = "Cafe";

            // Act
            var actual = underTest.FindById(id);
            Console.WriteLine("Produit : "+id + " Libelle: "+actual.Libelle+ " Prix: "+actual.PrixUnitaire);
          
            // Assert
            Assert.AreEqual(libelle, actual.Libelle);
        }
    }
}
