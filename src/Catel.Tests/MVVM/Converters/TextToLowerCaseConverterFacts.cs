﻿namespace Catel.Tests.MVVM.Converters
{
    using System.Diagnostics;
    using System.Globalization;
    using Catel.MVVM.Converters;

    using NUnit.Framework;

    public class TextToLowerCaseConverterFacts
    {
        #region Nested type: TheConvertMethod
        [TestFixture]
        public class TheConvertMethod
        {
            #region Methods
            [TestCase]
            public void ReturnsLowerCaseString()
            {
                var converter = new TextToLowerCaseConverter();
                var actualValue = converter.Convert("LoWeRcAsE", typeof(string), null, (CultureInfo)null);

                Assert.That(actualValue, Is.EqualTo("lowercase"));
            }

            [TestCase]
            public void SecondCallRunsFasterThanFirstOne()
            {
                var converter = new TextToLowerCaseConverter();

                var stopwatch1 = new Stopwatch();
                stopwatch1.Start();
                converter.Convert("LoWeRcAsE", typeof(string), null, (CultureInfo)null);
                stopwatch1.Stop();

                var stopwatch2 = new Stopwatch();
                stopwatch2.Start();
                converter.Convert("LoWeRcAsE", typeof(string), null, (CultureInfo)null);
                stopwatch2.Stop();

                Assert.That(stopwatch2.Elapsed, Is.LessThan(stopwatch1.Elapsed));
            }

            [TestCase]
            public void ReturnsNullForNullValue()
            {
                var converter = new TextToLowerCaseConverter();

                Assert.That(converter.Convert(null, typeof(string), null, (CultureInfo)null), Is.EqualTo(null));
            }
            #endregion
        }
        #endregion
    }
}
