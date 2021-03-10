using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")] // Organizar em categorias
        [TestMethod("Should validate Gravatar extensions")] // Nomear no MSTest
        [DataRow(null, false)] // Adicionar diversas linhas
        [DataRow("", false)] // Adicionar diversas linhas
        [DataRow(" ", false)] // Adicionar diversas linhas
        [DataRow("a@a.com", false)] // Adicionar diversas linhas
        [DataRow("andre@balta.io", true)] // Adicionar diversas linhas
        public void ShouldValidateGravatar(string email, bool status)
        {
            var result = "http://www.gravatar.com/avatar/8d9f6b0ffc9150878f1ae9e3ae9bfb07";
            
            Assert.AreEqual(email.ToGravatar() == result, status);
        }
    }
}
