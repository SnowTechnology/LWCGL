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
using System;

namespace LWCGL.Maths
{
    public static class Mathf
    {
        public const float PI = (float) Math.PI;

        public static float ToRadians(float a)
        {
            return (a * Mathf.PI) / 180.0f;
        }

        public static float ToDegrees(float a)
        {
            return (a / Mathf.PI) * 180.0f;
        }

        public static float Sqrt(float a)
        {
            return (float) Math.Sqrt(a);
        }

        public static float Sin(float a)
        {
            return (float) Math.Sin(a);
        }

        public static float Cos(float a)
        {
            return (float) Math.Cos(a);
        }

        public static float Tan(float a)
        {
            return (float) Math.Tan(a);
        }
    }
}
