using System;
using System.Net;
using VMProtect;

namespace js_obfuscator
{
    class Auth
    {
        private const string version = "1.8";

        public static void authorize()
        {
            WebClient httpClient = new WebClient(); WebRequest.DefaultWebProxy = new WebProxy();
            bool _checked = false;
            string hwid = SDK.GetCurrentHWID();

            Console.WriteLine("[*] Authorizing client: " + hwid);

            httpClient.Headers.Add("Hotline-Services", "list_access");
            if (httpClient.DownloadString("https://badtools.000webhostapp.com/obf/list.txt").Contains(hwid))
            {
                _checked = true;
            }

            if (!_checked)
            {
                Console.WriteLine("[*] Failed to authorize");
                throw new Exception("Authorization failed");
            }
            Console.WriteLine("[*] Authorized successfully");
        }

        public static void check_version()
        {
            WebClient httpClient = new WebClient(); WebRequest.DefaultWebProxy = new WebProxy();

            httpClient.Headers.Add("Hotline-Services", "list_access");
            if (httpClient.DownloadString("https://badtools.000webhostapp.com/obf/ver.txt") == version)
            {
                Console.Title = $"JS Obfuscator by hotline#1337 | {version}";
                Console.WriteLine("[*] Using newest obfuscator");
            }
            else
            {
                Console.WriteLine("[*] Obfuscator is outdated");
                throw new Exception("Outdated obfuscator");
            }

        }
    }
}
