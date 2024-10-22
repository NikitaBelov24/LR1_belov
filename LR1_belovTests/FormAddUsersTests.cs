using Microsoft.VisualStudio.TestTools.UnitTesting;
using LR1_belov;
using System;
using Moq;

namespace LR1_belov.Tests
{
    [TestClass()]
    public class FormAddUsersTests
    {
        [TestMethod()]
        public void ButtonBack_Click_CallsCloseMethod()
        {
            // Action
            var form = new Mock<FormAddUsers>();
            form.CallBase = true; // Нужно для того, чтобы вызывать базовый метод кнопки

            // Assertion
            form.Object.buttonBack_Click(this, EventArgs.Empty); // Вызов метода с передачей аргументов

            // Arrangement
            form.Verify(f => f.Close(), Times.Once); // Проверяем, что метод Close был вызван один раз
        }
    }
}
