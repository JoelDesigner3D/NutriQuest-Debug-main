using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GravityValueTest
{
    [Test]
    public void GravityValueTestSimplePasses()
    {

      Assert.AreEqual(Physics.gravity,  new Vector3(0, -9.81f, 0) );

    }

}
