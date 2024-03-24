using System;
using System.Linq;
using System.Text.RegularExpressions;

var inputText = "nhoJ (Griffith) nodnoL saw (an) (American) ,tsilevon ,tsilanruoj (and) laicos .tsivitca ((A) reenoip (of) laicremmoc noitcif (and) naciremA ,senizagam (he) saw eno (of) (the) tsrif (American) srohtua (to) emoceb (an) lanoitanretni ytirbelec (and) nrae a egral enutrof (from) ).gnitirw";
var correctAnswer = "John Griffith London was an American novelist, journalist, and social activist. (A pioneer of commercial fiction and American magazines, he was one of the first American authors to become an international celebrity and earn a large fortune from writing.)";


string ReverseText(string input)
{
    var words = Regex.Matches(input, @"\((.*?)\)|[^\s]+")
                         .Cast<Match>()
                         .Select(m => m.Groups[1].Success ? m.Groups[1].Value : new string(m.Value.Reverse().ToArray()))
                         .ToArray();

    return string.Join(" ", words);
}

Console.WriteLine(ReverseText(inputText));
Console.WriteLine(ReverseText(inputText) == correctAnswer ? "Correct !!!" : "Wrong answer...!");