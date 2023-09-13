using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

namespace Artifact.SdkToolkit.Editor.Tests
{
    class EditorExampleTest
    {
        [Test]
        public void EditorSampleTestSimplePasses()
        {
            var expected = 4;
            var actual = 2 + 2;
            Assert.AreEqual(expected, actual);
        }

        [UnityTest]
        public IEnumerator EditorSampleTestWithEnumeratorPasses()
        {
            yield return null;
        }
    }
}
