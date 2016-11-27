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
    public class Vector4
    {
        public float x, y, z, w;

        public Vector4()
        {
            this.x = 0.0f;
            this.y = 0.0f;
            this.z = 0.0f;
            this.w = 0.0f;
        }

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public Vector4 Add(Vector4 other)
        {
            this.x += other.x;
            this.y += other.y;
            this.z += other.z;
            this.w += other.w;

            return this;
        }

        public Vector4 Subtract(Vector4 other)
        {
            this.x -= other.x;
            this.y -= other.y;
            this.z -= other.z;
            this.w -= other.w;

            return this;
        }

        public Vector4 Multiply(Vector4 other)
        {
            this.x *= other.x;
            this.y *= other.y;
            this.z *= other.z;
            this.w *= other.w;

            return this;
        }

        public Vector4 Divide(Vector4 other)
        {
            this.x /= other.x;
            this.y /= other.y;
            this.z /= other.z;
            this.w /= other.w;

            return this;
        }

        public Vector4 Add(float x, float y, float z, float w)
        {
            this.x += x;
            this.y += y;
            this.z += z;
            this.w += w;

            return this;
        }

        public Vector4 Subtract(float x, float y, float z, float w)
        {
            this.x -= x;
            this.y -= y;
            this.z -= z;
            this.w -= w;

            return this;
        }

        public Vector4 Multiply(float x, float y, float z, float w)
        {
            this.x *= x;
            this.y *= y;
            this.z *= z;
            this.w *= w;

            return this;
        }

        public Vector4 Divide(float x, float y, float z, float w)
        {
            this.x /= x;
            this.y /= y;
            this.z /= z;
            this.w /= w;

            return this;
        }

        public Vector4 Add(float value)
        {
            this.x += value;
            this.y += value;
            this.z += value;
            this.w += value;

            return this;
        }

        public Vector4 Subtract(float value)
        {
            this.x -= value;
            this.y -= value;
            this.z -= value;
            this.w -= value;

            return this;
        }

        public Vector4 Multiply(float value)
        {
            this.x *= value;
            this.y *= value;
            this.z *= value;
            this.w *= value;
            
            return this;
        }

        public Vector4 Divide(float value)
        {
            this.x /= value;
            this.y /= value;
            this.z /= value;
            this.w /= value;

            return this;
        }

        public Vector4 Lerp(Vector4 destination, float lerpFactor)
        {
            return ((destination - this) * lerpFactor) + this;
        }

        public Vector4 Copy()
        {
            return new Vector4(this.x, this.y, this.z, this.w);
        }

        public Vector4 Normalize()
        {
            return this.Divide(this.Length());
        }

        public Vector4 Normal()
        {
            return this.Copy().Normalize();
        }

        public float LengthSquared()
        {
            return (this.x * this.x) + (this.y * this.y) + (this.z * this.z) + (this.w * this.w);
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

        public float GetZ()
        {
            return this.z;
        }

        public float GetW()
        {
            return this.w;
        }

        override public int GetHashCode()
        {
            return base.GetHashCode();
        }

        override public bool Equals(object obj)
        {
            if (obj is Vector4)
            {
                Vector4 other = (Vector4) obj;
                return (this.x == other.x) && (this.y == other.y) && (this.z == other.z) && (this.w == other.w);
            }
            return base.Equals(obj);
        }

        override public string ToString()
        {
            return "Vector4(" + this.x + ", " + this.y + ", " + this.z + ", " + this.w + ")";
        }

        public static Vector4 operator +(Vector4 left, Vector4 right)
        {
            return left.Copy().Add(right);
        }

        public static Vector4 operator -(Vector4 left, Vector4 right)
        {
            return left.Copy().Subtract(right);
        }

        public static Vector4 operator *(Vector4 left, Vector4 right)
        {
            return left.Copy().Multiply(right);
        }

        public static Vector4 operator /(Vector4 left, Vector4 right)
        {
            return left.Copy().Divide(right);
        }

        public static Vector4 operator +(Vector4 left, float right)
        {
            return left.Copy().Add(right);
        }

        public static Vector4 operator -(Vector4 left, float right)
        {
            return left.Copy().Subtract(right);
        }

        public static Vector4 operator *(Vector4 left, float right)
        {
            return left.Copy().Multiply(right);
        }

        public static Vector4 operator /(Vector4 left, float right)
        {
            return left.Copy().Divide(right);
        }

        public static float operator ~(Vector4 vector)
        {
            return vector.Length();
        }

        public static Vector4 operator ++(Vector4 vector)
        {
            return vector.Add(1);
        }

        public static Vector4 operator --(Vector4 vector)
        {
            return vector.Subtract(1);
        }

        public static bool operator !(Vector4 vector)
        {
            return vector != null;
        }

        public static bool operator ==(Vector4 left, Vector4 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector4 left, Vector4 right)
        {
            return !left.Equals(right);
        }
    }
}
