using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetEvaluationFor_GetEvaluationFor()
        {

            //AAA
            //1. Arrange => on instancie
            Pupil p = new Pupil("Quentin", 10);
            Activity a = new Activity("env dev", true);

            //2. Act => on utilise le système
            p.AddActivity(a);
            p.AddEvaluation(a.Title, 'd');

            //3. Assert => on compare le résultat obtenu et attendu
            var eval = p.GetEvaluationFor("env dev");
            Assert.AreEqual('d', eval);

        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void GetEvaluationFor_ThrowsExceptionForUnknowActivity()
        {

            //AAA
            //1. Arrange => on instancie
            Pupil p = new Pupil("Quentin", 10);

            //3. Assert => on compare le résultat obtenu et attendu
            var eval = p.GetEvaluationFor("env dev");
            Assert.AreEqual('d', eval);

        }
    }
}
