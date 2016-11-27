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
    public class Vector3
    {
        public float x, y, z;

        public Vector3()
        {
            this.x = 0.0f;
            this.y = 0.0f;
            this.z = 0.0f;
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3 Add(Vector3 other)
        {
            this.x += other.x;
            this.y += other.y;
            this.z += other.z;

            return this;
        }

        public Vector3 Subtract(Vector3 other)
        {
            this.x -= other.x;
            this.y -= other.y;
            this.z -= other.z;

            return this;
        }

        public Vector3 Multiply(Vector3 other)
        {
            this.x *= other.x;
            this.y *= other.y;
            this.z *= other.z;

            return this;
        }

        public Vector3 Divide(Vector3 other)
        {
            this.x /= other.x;
            this.y /= other.y;
            this.z /= other.z;

            return this;
        }

        public Vector3 Add(float x, float y, float z)
        {
            this.x += x;
            this.y += y;
            this.z += z;

            return this;
        }

        public Vector3 Subtract(float x, float y, float z)
        {
            this.x -= x;
            this.y -= y;
            this.z -= z;

            return this;
        }

        public Vector3 Multiply(float x, float y, float z)
        {
            this.x *= x;
            this.y *= y;
            this.z *= z;

            return this;
        }

        public Vector3 Divide(float x, float y, float z)
        {
            this.x /= x;
            this.y /= y;
            this.z /= z;

            return this;
        }

        public Vector3 Add(float value)
        {
            this.x += value;
            this.y += value;
            this.z += value;

            return this;
        }

        public Vector3 Subtract(float value)
        {
            this.x -= value;
            this.y -= value;
            this.z -= value;

            return this;
        }

        public Vector3 Multiply(float value)
        {
            this.x *= value;
            this.y *= value;
            this.z *= value;

            return this;
        }

        public Vector3 Divide(float value)
        {
            this.x /= value;
            this.y /= value;
            this.z /= value;

            return this;
        }

        public Vector3 Lerp(Vector3 destination, float lerpFactor)
        {
            return ((destination - this) * lerpFactor) + this;
        }

        public Vector3 Copy()
        {
            return new Vector3(this.x, this.y, this.z);
        }

        public Vector3 Normalize()
        {
            return this.Divide(this.Length());
        }

        public Vector3 Normal()
        {
            return this.Copy().Normalize();
        }

        public float LengthSquared()
        {
            return (this.x * this.x) + (this.y * this.y) + (this.z * this.z);
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

        override public int GetHashCode()
        {
            return base.GetHashCode();
        }

        override public bool Equals(object obj)
        {
            if (obj is Vector3)
            {
                Vector3 other = (Vector3) obj;
                return (this.x == other.x) && (this.y == other.y) && (this.z == other.z);
            }
            return base.Equals(obj);
        }

        override public string ToString()
        {
            return "Vector3(" + this.x + ", " + this.y + ", " + this.z + ")";
        }

        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            return left.Copy().Add(right);
        }

        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            return left.Copy().Subtract(right);
        }

        public static Vector3 operator *(Vector3 left, Vector3 right)
        {
            return left.Copy().Multiply(right);
        }

        public static Vector3 operator /(Vector3 left, Vector3 right)
        {
            return left.Copy().Divide(right);
        }

        public static Vector3 operator +(Vector3 left, float right)
        {
            return left.Copy().Add(right);
        }

        public static Vector3 operator -(Vector3 left, float right)
        {
            return left.Copy().Subtract(right);
        }

        public static Vector3 operator *(Vector3 left, float right)
        {
            return left.Copy().Multiply(right);
        }

        public static Vector3 operator /(Vector3 left, float right)
        {
            return left.Copy().Divide(right);
        }

        public static float operator ~(Vector3 vector)
        {
            return vector.Length();
        }

        public static Vector3 operator ++(Vector3 vector)
        {
            return vector.Add(1);
        }

        public static Vector3 operator --(Vector3 vector)
        {
            return vector.Subtract(1);
        }

        public static Vector3 operator +(Vector3 vector)
        {
            float x = vector.x;
            float y = vector.y;
            float z = vector.z;

            if (x < 0)
            {
                x = -x;
            }

            if (y < 0)
            {
                y = -y;
            }

            if (z < 0)
            {
                z = -z;
            }

            return new Vector3(x, y, z);
        }

        public static Vector3 operator -(Vector3 vector)
        {
            float x = vector.x;
            float y = vector.y;
            float z = vector.z;

            if (x > 0)
            {
                x = -x;
            }

            if (y > 0)
            {
                y = -y;
            }

            if (z > 0)
            {
                z = -z;
            }

            return new Vector3(x, y, z);
        }

        public static bool operator !(Vector3 vector)
        {
            return vector != null;
        }

        public static bool operator ==(Vector3 left, Vector3 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector3 left, Vector3 right)
        {
            return !left.Equals(right);
        }
        
    }
}
