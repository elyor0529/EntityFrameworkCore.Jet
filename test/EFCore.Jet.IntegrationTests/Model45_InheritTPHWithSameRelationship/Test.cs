﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFrameworkCore.Jet.IntegrationTests.Model45_InheritTPHWithSameRelationship
{
    public abstract class Test : TestBase<Context>
    {
        // Actually this test does not work
        [TestMethod]
        /*[ExpectedException(typeof(ModelValidationException))]*/
        public void Run()
        {
            Context.M1s.FirstOrDefault();
        }
    }
}
