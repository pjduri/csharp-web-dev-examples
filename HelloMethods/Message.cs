using System;

namespace HelloMethods
{
    public class Message
    {
        public static string GetMessage(string lang, string name)
        {
            if (name.Equals(null))
            {
                {
                    if (lang.Equals("sp"))
                    {
                        return "Hola Mundo";
                    }
                    else if (lang.Equals("fr"))
                    {
                        return "Bonjour le monde";
                    }
                    else if (lang.Equals("tg"))
                    {
                        return "Mabuhay Mundo";
                    }
                    else
                    {
                        return "Hello World";
                    }
                }
            }
            else
            {
                if (lang.Equals("sp"))
                {
                    return "Hola " + name;
                }
                else if (lang.Equals("fr"))
                {
                    return "Bonjour " + name;
                }
                else if (lang.Equals("tg"))
                {
                    return "Mabuhay " + name;
                }
                else
                {
                    return "Hello " + name;
                }
            }
        }
    }
}

