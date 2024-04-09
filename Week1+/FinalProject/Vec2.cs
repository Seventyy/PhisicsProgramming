using System;
using GXPEngine; // Allows using Mathf functions

public struct Vec2
{
    public float x;
    public float y;

    public Vec2(float pX = 0, float pY = 0)
    {
        x = pX;
        y = pY;
    }

    public float Length()
    {
        return Mathf.Sqrt(x * x + y * y);
    }

    public float LengthSquared()
    {
        return x * x + y * y;
    }

    public Vec2 Normalized()
    {
        float length = Length();
        if (length == 0)
        {
            return new Vec2(0, 0);
        }
        return new Vec2(x / length, y / length);
    }

    public static Vec2 operator +(Vec2 left, Vec2 right)
    {
        return new Vec2(left.x + right.x, left.y + right.y);
    }

    public static Vec2 operator -(Vec2 left, Vec2 right)
    {
        return new Vec2(left.x - right.x, left.y - right.y);
    }

    public static Vec2 operator *(Vec2 left, float right)
    {
        return new Vec2(left.x * right, left.y * right);
    }

    public static Vec2 operator /(Vec2 left, float right)
    {
        return new Vec2(left.x / right, left.y / right);
    }

    public override string ToString()
    {
        return String.Format("({0},{1})", x, y);
    }
}

