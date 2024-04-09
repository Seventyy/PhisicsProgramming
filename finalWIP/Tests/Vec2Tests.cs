using System;
using GXPEngine;

[TestClass]
public class Vec2Tests
{
    [TestMethod]
    public void TestLength()
    {
        Vec2 v = new Vec2(3, 4);
        Assert.AreEqual(5, v.Length());
    }

    [TestMethod]
    public void TestLengthSquared()
    {
        Vec2 v = new Vec2(3, 4);
        Assert.AreEqual(25, v.LengthSquared());
    }

    [TestMethod]
    public void TestNormalized()
    {
        Vec2 v = new Vec2(3, 4);
        Vec2 normalized = v.Normalized();
        Assert.AreEqual(0.6, normalized.x, 0.01);
        Assert.AreEqual(0.8, normalized.y, 0.01);
    }

    [TestMethod]
    public void TestAdditionOperator()
    {
        Vec2 v1 = new Vec2(1, 2);
        Vec2 v2 = new Vec2(3, 4);
        Vec2 result = v1 + v2;
        Assert.AreEqual(4, result.x);
        Assert.AreEqual(6, result.y);
    }

    [TestMethod]
    public void TestSubtractionOperator()
    {
        Vec2 v1 = new Vec2(1, 2);
        Vec2 v2 = new Vec2(3, 4);
        Vec2 result = v1 - v2;
        Assert.AreEqual(-2, result.x);
        Assert.AreEqual(-2, result.y);
    }

    [TestMethod]
    public void TestMultiplicationOperator()
    {
        Vec2 v = new Vec2(3, 4);
        Vec2 result = v * 2;
        Assert.AreEqual(6, result.x);
        Assert.AreEqual(8, result.y);
    }

    [TestMethod]
    public void TestDivisionOperator()
    {
        Vec2 v = new Vec2(3, 4);
        Vec2 result = v / 2;
        Assert.AreEqual(1.5, result.x, 0.01);
        Assert.AreEqual(2, result.y, 0.01);
    }

    [TestMethod]
    public void TestToString()
    {
        Vec2 v = new Vec2(3, 4);
        Assert.AreEqual("(3,4)", v.ToString());
    }
}
