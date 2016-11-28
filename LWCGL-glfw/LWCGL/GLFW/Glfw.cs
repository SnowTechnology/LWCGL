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

namespace LWCGL.GLFW
{
    public static unsafe class Glfw
    {
        public const int TRUE = 0x1;
        public const int FALSE = 0x0;

#pragma warning disable 0414

        public static bool Init()
        {
            return GlfwDelegates.glfwInit() == TRUE;
        }

        public static void Terminate()
        {
            GlfwDelegates.glfwTerminate();
        }

        public static void GetVersion(out int major, out int minor, out int rev)
        {
            GlfwDelegates.glfwGetVersion(out major, out minor, out rev);
        }

        public static string GetVersionString()
        {
            return new string(GlfwDelegates.glfwGetVersionString());
        }

        public static GlfwMonitor[] GetMonitors()
        {
            int count;
            GlfwMonitor* array = GlfwDelegates.glfwGetMonitors(out count);
            GlfwMonitor[] result = new GlfwMonitor[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = array[i];
            }
            return result;
        }

        public static GlfwMonitor GetPrimaryMonitor()
        {
            return GlfwDelegates.glfwGetPrimaryMonitor();
        }

#pragma warning restore 0414
    }
}
