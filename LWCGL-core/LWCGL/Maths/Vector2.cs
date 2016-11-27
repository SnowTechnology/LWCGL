#region License
// Copyright (c) 2016 Mark Rienstra
// <p>
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

namespace LWCGL.Maths
{
    public class Vector2
    {
        public float x, y;

        public Vector2()
        {
            this.x = 0.0f;
            this.y = 0.0f;
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2 Add(Vector2 other)
        {
            this.x += other.x;
            this.y += other.y;

            return this;
        }

        public Vector2 Subtract(Vector2 other)
        {
            this.x -= other.x;
            this.y -= other.y;

            return this;
        }

        public Vector2 Multiply(Vector2 other)
        {
            this.x *= other.x;
            this.y *= other.y;

            return this;
        }

        public Vector2 Divide(Vector2 other)
        {
            this.x /= other.x;
            this.y /= other.y;

            return this;
        }

        public Vector2 Add(float x, float y)
        {
            this.x += x;
            this.y += y;

            return this;
        }

        public Vector2 Subtract(float x, float y)
        {
            this.x -= x;
            this.y -= y;

            return this;
        }

        public Vector2 Multiply(float x, float y)
        {
            this.x *= x;
            this.y *= y;

            return this;
        }

        public Vector2 Divide(float x, float y)
        {
            this.x /= x;
            this.y /= y;

            return this;
        }

        public Vector2 Add(float value)
        {
            this.x += value;
            this.y += value;

            return this;
        }

        public Vector2 Subtract(float value)
        {
            this.x -= value;
            this.y -= value;

            return this;
        }

        public Vector2 Multiply(float value)
        {
            this.x *= value;
            this.y *= value;

            return this;
        }

        public Vector2 Divide(float value)
        {
            this.x /= value;
            this.y /= value;

            return this;
        }

        public Vector2 Lerp(Vector2 destination, float lerpFactor)
        {
            return ((destination - this) * lerpFactor) + this;
        }

        public Vector2 Copy()
        {
            return new Vector2(this.x, this.y);
        }

        public Vector2 Normalize()
        {
            return this.Divide(this.Length());
        }

        public Vector2 Normal()
        {
            return this.Copy().Normalize();
        }

        public float LengthSquared()
        {
            return (this.x * this.x) + (this.y * this.y);
        }

        public float Length()
        {
            return Mathf.Sqrt(this.LengthSquared());
        }

        public float GetX()
        {
            return this.x;
        }

        public float GetY()
        {
            return this.y;
        }

        override public int GetHashCode()
        {
            return base.GetHashCode();
        }

        override public bool Equals(object obj)
        {
            if (obj is Vector2)
            {
                Vector2 other = (Vector2) obj;
                return (this.x == other.x) && (this.y == other.y);
            }
            return base.Equals(obj);
        }

        override public string ToString()
        {
            return "Vector2(" + this.x + ", " + this.y + ")";
        }

        public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            return left.Copy().Add(right);
        }

        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            return left.Copy().Subtract(right);
        }

        public static Vector2 operator *(Vector2 left, Vector2 right)
        {
            return left.Copy().Multiply(right);
        }

        public static Vector2 operator /(Vector2 left, Vector2 right)
        {
            return left.Copy().Divide(right);
        }

        public static Vector2 operator +(Vector2 left, float right)
        {
            return left.Copy().Add(right);
        }

        public static Vector2 operator -(Vector2 left, float right)
        {
            return left.Copy().Subtract(right);
        }

        public static Vector2 operator *(Vector2 left, float right)
        {
            return left.Copy().Multiply(right);
        }

        public static Vector2 operator /(Vector2 left, float right)
        {
            return left.Copy().Divide(right);
        }

        public static Vector2 operator ++(Vector2 vector)
        {
            return vector.Add(1);
        }

        public static float operator ~(Vector2 vector)
        {
            return vector.Length();
        }

        public static Vector2 operator --(Vector2 vector)
        {
            return vector.Subtract(1);
        }

        public static bool operator !(Vector2 vector)
        {
            return vector != null;
        }

        public static bool operator ==(Vector2 left, Vector2 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector2 left, Vector2 right)
        {
            return !left.Equals(right);
        }
    }
}
