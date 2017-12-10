using Microsoft.AspNetCore.Mvc;
using Vocabulary.Models;

namespace Vocabulary.Controllers
{
    [Route("api/MyWords")]
    public class MyWordsController : Controller
    {
        private WordsDatabaseContext _wordsContext;

        public MyWordsController(WordsDatabaseContext wordsContext)
        {
            _wordsContext = wordsContext;
        }

        public IActionResult GetMyWords()
        {
            return Ok(_wordsContext.MyWords);
        }
    }
}