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
    public class Matrix4
    {
        private float[] m_Elements;

        public Matrix4()
        {
            m_Elements = new float[16];
        }

        public Matrix4(float diagonal)
        {
            m_Elements = new float[16];

            m_Elements[0 + 0 * 4] = diagonal;
            m_Elements[1 + 1 * 4] = diagonal;
            m_Elements[2 + 2 * 4] = diagonal;
            m_Elements[3 + 3 * 4] = diagonal;
        }

        public Matrix4 Multiply(Matrix4 other)
        {
            return this;
        }

        public Matrix4 Copy()
        {
            Matrix4 result = new Matrix4();
            for (int i = 0; i < 16; i++)
            {
                result.m_Elements[i] = m_Elements[i];
            }
            return result;
        }

        public float[] GetElements()
        {
            float[] result = new float[16];
            for (int i = 0; i < 16; i++)
            {
                result[i] = m_Elements[i];
            }
            return result;
        }

        override public string ToString()
        {
            string result = "Matrix4 {";
            
            for (int row = 0; row < 4; row++)
            {
                result += " { ";
                for (int col = 0; col < 4; col++)
                {
                    result += m_Elements[row + col * 4] + ", ";
                }
                result = result.Substring(0, result.Length - 2);
                result += " }, ";
            }

            result = result.Substring(0, result.Length - 2);
            result += " }";

            return result;
        }

        public static Matrix4 Orthographic(float left, float right, float bottom, float top, float near, float far)
        {
            Matrix4 result = new Matrix4(1.0f);

            float width = right - left;
            float height = top - bottom;
            float range = far - near;

            result.m_Elements[0 + 0 * 4] = 2.0f / width;
            result.m_Elements[1 + 1 * 4] = 2.0f / height;
            result.m_Elements[2 + 2 * 4] =-2.0f / range;

            result.m_Elements[0 + 3 * 4] = (-right - left) / width;

            result.m_Elements[1 + 3 * 4] = (-top - bottom) / height;

            result.m_Elements[2 + 3 * 4] = (-far - near) / range;

            return result;
        }

        public static Matrix4 Perspective(float fieldOfView, float aspectRatio, float near, float far)
        {
            Matrix4 result = new Matrix4();

            float tanHalfFov = Mathf.Tan(Mathf.ToRadians(fieldOfView / 2.0f));
            float range = far - near;

            result.m_Elements[0 + 0 * 4] = 1.0f / (aspectRatio * tanHalfFov);
            result.m_Elements[1 + 1 * 4] = 1.0f / tanHalfFov;
            result.m_Elements[2 + 2 * 4] = (-far - near) / range;
            result.m_Elements[2 + 3 * 4] = (-2 * far * near) / range;
            result.m_Elements[3 + 2 * 4] = -1.0f;

            return result;
        }

        public static Matrix4 Translate(Vector3 position)
        {
            Matrix4 result = new Matrix4(1.0f);

            result.m_Elements[0 + 3 * 4] = position.GetX();
            result.m_Elements[1 + 3 * 4] = position.GetY();
            result.m_Elements[2 + 3 * 4] = position.GetZ();

            return result;
        }

        public static Matrix4 Rotate(Vector3 rotation)
        {
            Matrix4 rotX = new Matrix4(1.0f);
            Matrix4 rotY = new Matrix4(1.0f);
            Matrix4 rotZ = new Matrix4(1.0f);

            float x = rotation.GetX();
            float y = rotation.GetY();
            float z = rotation.GetZ();

            float sinX = Mathf.Sin(x);
            float sinY = Mathf.Sin(y);
            float sinZ = Mathf.Sin(z);

            float cosX = Mathf.Cos(x);
            float cosY = Mathf.Cos(y);
            float cosZ = Mathf.Cos(z);

            rotX.m_Elements[1 + 1 * 4] = cosX;
            rotX.m_Elements[1 + 2 * 4] =-sinX;
            rotX.m_Elements[2 + 1 * 4] = sinX;
            rotX.m_Elements[2 + 2 * 4] = cosX;

            rotY.m_Elements[0 + 0 * 4] = cosY;
            rotY.m_Elements[0 + 2 * 4] = sinY;
            rotY.m_Elements[2 + 0 * 4] =-sinY;
            rotY.m_Elements[2 + 2 * 4] = cosY;

            rotZ.m_Elements[0 + 0 * 4] = cosZ;
            rotZ.m_Elements[0 + 1 * 4] =-sinZ;
            rotZ.m_Elements[1 + 0 * 4] = sinZ;
            rotZ.m_Elements[1 + 1 * 4] = cosZ;

            return rotZ * rotY * rotX;
        }

        public static Matrix4 Scale(Vector3 scale)
        {
            Matrix4 result = new Matrix4(1.0f);

            result.m_Elements[0 + 0 * 4] = scale.GetX();
            result.m_Elements[1 + 1 * 4] = scale.GetY();
            result.m_Elements[2 + 2 * 4] = scale.GetZ();

            return result;
        }

        public static Matrix4 operator *(Matrix4 left, Matrix4 right)
        {
            return left.Copy().Multiply(right);
        }

        public static bool operator !(Matrix4 matrix)
        {
            return matrix != null;
        }
    }
}
