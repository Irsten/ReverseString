using Microsoft.AspNetCore.Mvc;

namespace ReverseString.Controllers
{
    public class ReverseStringController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string ReverseString(string givenStr, string reversedStr, int index)
        {
            reversedStr += givenStr[index];
            index--;

            if (index >= 0)
            {
                return ReverseString(givenStr, reversedStr, index);
            }
            else
            {
                return reversedStr;
            }
        }
        [HttpPost]
        public string GetString(string givenStr)
        {
            if (givenStr == null)
            {
                return "";
            }
            else
            {
                var reversedString = "";
                var index = givenStr.Length - 1;
                var reversedStr = ReverseString(givenStr, reversedString, index);

                return reversedStr;
            }
            
        }
    }
}
