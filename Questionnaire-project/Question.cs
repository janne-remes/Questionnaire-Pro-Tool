using System;
using System.Collections.Generic;
using System.Text;

namespace Questionnaire_project
{
    class Question
    {
        private string wholeQuestion;
        private bool answer;

        public Question()
        {

        }

        public Question(string wholeQuestion, bool answer)
        {
            this.wholeQuestion = wholeQuestion;
            this.answer = answer;
        }

        public string WholeQuestion
        {
            get
            {
                return wholeQuestion;
            }

            set
            {
                if (value != "")
                {
                    wholeQuestion = value;
                }
            }
        }

        public bool Answer
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }
    }
}
