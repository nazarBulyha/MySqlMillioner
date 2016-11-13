using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace MSSql_CSharp
{
    internal class QuestionAnswers
    {
        public List<QuestionAnswers> QA { get; set; }
        public string Question { get; set; }

        public string GoodAnswer { get; set; }

        public string Answer2 { get; set; }

        public string Answer3 { get; set; }

        public string Answer4 { get; set; }

        public void addQA(QuestionAnswers qa)
        {
            QA.Add(qa);
        }

        public void addAllQA(List<QuestionAnswers> qaList)
        {
            QA.AddRange(qaList);
        }

    }
}