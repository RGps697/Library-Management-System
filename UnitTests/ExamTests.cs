using LogicLibrary;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTests
{
    internal class ExamTests
    {
        ExamProcessor ExamProcessor;

        [SetUp]
        public void Setup()
        {
            Exam testExam = new Exam();
            ExamProcessor = new ExamProcessor(testExam);
            SingleChoiceQuestion testQuestion = new SingleChoiceQuestion();
            ExamProcessor.AddQuestion(testQuestion);
        }

        //Unit
        [Test]
        public void ExamProcessorSetName()
        {
            string testName = "test";
            ExamProcessor.SetName = testName;
            Assert.That(ExamProcessor.GetName, Is.EqualTo(testName));
        }

        [Test]
        public void ExamProcessorAddSingleChoiceQuestion()
        {
            SingleChoiceQuestion testQuestion = new SingleChoiceQuestion();
            ExamProcessor.AddQuestion(testQuestion);
            Assert.Contains(testQuestion, ExamProcessor.Exam.Questions);

            string[] testNames = ExamProcessor.GetAllQuestionNames();
            Assert.That(testNames[0], Is.EqualTo("1. Jednokrotny wybór"));
            Assert.That(testNames[1], Is.EqualTo("2. Jednokrotny wybór"));
        }

        [Test]
        public void ExamProcessorAddMultiChoiceQuestion()
        {
            MultiChoiceQuestion testQuestion = new MultiChoiceQuestion();
            ExamProcessor.AddQuestion(testQuestion);
            Assert.Contains(testQuestion, ExamProcessor.Exam.Questions);

            string[] testNames = ExamProcessor.GetAllQuestionNames();
            Assert.That(testNames[0], Is.EqualTo("1. Jednokrotny wybór"));
            Assert.That(testNames[1], Is.EqualTo("2. Wielokrotny wybór"));
        }

        [Test]
        public void ExamProcessorGetQuestionControl()
        {
            IQuestion question = ExamProcessor.GetQuestion(0);
            Assert.IsNotNull(question);
        }

        [Test]
        public void ExamProcessorQuestionAmountPerSession()
        {
            ushort result = ExamProcessor.QuestionAmountPerSession(-1);
            Assert.That(result, Is.EqualTo(1));
            result = ExamProcessor.QuestionAmountPerSession(ushort.MaxValue+1);
            Assert.That(result, Is.EqualTo(1));

            MultiChoiceQuestion testQuestion = new MultiChoiceQuestion();
            ExamProcessor.AddQuestion(testQuestion);
            result = ExamProcessor.QuestionAmountPerSession(2);
            Assert.That(result, Is.EqualTo(0));
            result = ExamProcessor.QuestionAmountPerSession(1);
            Assert.That(result, Is.EqualTo(0));
        }


        [Test]
        public void ExamProcessorDeleteQuestion()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ExamProcessor.DeleteQuestion(255));
            Assert.Throws<ArgumentOutOfRangeException>(() => ExamProcessor.DeleteQuestion(-1));
            ExamProcessor.DeleteQuestion(0);
            Assert.That(ExamProcessor.Exam.Questions.Count, Is.EqualTo(0));
        }

        //QuestionProcessor

        [Test]
        public void ExamProcessorAddQuestionAnswer()
        {
            SingleChoiceQuestion question = new SingleChoiceQuestion();
            ExamProcessor.AddQuestion(question);
            QuestionAnswer testAnswer = ExamProcessor.questionProcessor.AddAnswer(question, "test1");
            Assert.NotNull(testAnswer);
        }

        [Test]
        public void ExamProcessorQuestionAnswerLimit()
        {
            SingleChoiceQuestion question = new SingleChoiceQuestion();
            ExamProcessor.AddQuestion(question);
            for (int i = 0; i < 20; i++) { 
                ExamProcessor.questionProcessor.AddAnswer(question, $"test{i}");
            }
            QuestionAnswer testAnswer = ExamProcessor.questionProcessor.AddAnswer(question, "test20");
            Assert.Null(testAnswer);
        }

        [Test]
        public void ExamProcessorMarkCorrectAnswer()
        {
            SingleChoiceQuestion question = new SingleChoiceQuestion();

            ExamProcessor.AddQuestion(question);
            QuestionAnswer testAnswer = ExamProcessor.questionProcessor.AddAnswer(question, "test1");
            bool result = ExamProcessor.questionProcessor.MarkCorrectAnswer(question, testAnswer);
            Assert.IsTrue(result);

            QuestionAnswer testAnswer2 = ExamProcessor.questionProcessor.AddAnswer(question, "test2");
            bool result2 = ExamProcessor.questionProcessor.MarkCorrectAnswer(question, testAnswer2);
            Assert.IsFalse(result2);
        }

        [Test]
        public void ExamProcessorSetDescription()
        {
            SingleChoiceQuestion question = new SingleChoiceQuestion();
            ExamProcessor.AddQuestion(question);
            string testDescription = "test";
            ExamProcessor.questionProcessor.SetDescription(question, testDescription);
            Assert.That(question.Description, Is.EqualTo(testDescription));
        }

        [Test]
        public void ExamProcessorSetPoints()
        {
            SingleChoiceQuestion question = new SingleChoiceQuestion();
            ExamProcessor.AddQuestion(question);
            byte testPoints = 255;
            ExamProcessor.questionProcessor.SetPoints(question, testPoints);
            Assert.That(question.Points, Is.EqualTo(testPoints));
            testPoints = 0;
            ExamProcessor.questionProcessor.SetPoints(question, testPoints);
            Assert.That(question.Points, Is.EqualTo(255));
        }

        [Test]
        public void ExamEvaluatorScoreTest()
        {
            //Question 1, Expected points: 1

            //Create new question object
            SingleChoiceQuestion question1 = new SingleChoiceQuestion() { CorrectAnswerAmount = 1, Points = 1 };

            //Create QuestionAnswers for that question object and set property IsCorrectAnswer to state corectness of answer
            QuestionAnswer questionAnswer11 = new QuestionAnswer("Answer1") { IsCorrectAnswer = true};
            QuestionAnswer questionAnswer12 = new QuestionAnswer("Answer2") { IsCorrectAnswer = false };
            QuestionAnswer questionAnswer13 = new QuestionAnswer("Answer3") { IsCorrectAnswer = false };

            //Create AnsweredQuestionAnswers based on previous objects and set property IsSelected to simulate if question was selected by user during session
            AnsweredQuestionAnswer answeredQuestionAnswer11 = new AnsweredQuestionAnswer(questionAnswer11) { IsSelected = true };
            AnsweredQuestionAnswer answeredQuestionAnswer12 = new AnsweredQuestionAnswer(questionAnswer12) { IsSelected = false };
            AnsweredQuestionAnswer answeredQuestionAnswer13 = new AnsweredQuestionAnswer(questionAnswer13) { IsSelected = false };

            //Add answers to list of AnsweredQuestionAnswer
            List<AnsweredQuestionAnswer> answeredQuestionAnswers1 = new List<AnsweredQuestionAnswer>();
            answeredQuestionAnswers1.Add(answeredQuestionAnswer11);
            answeredQuestionAnswers1.Add(answeredQuestionAnswer12);
            answeredQuestionAnswers1.Add(answeredQuestionAnswer13);

            //Pass previously created list along with ChoiceQuestion to create AnsweredChoiceQuestion which will be used in evaluating score
            AnsweredChoiceQuestion answeredQuestion1 = new AnsweredChoiceQuestion(question1, answeredQuestionAnswers1);

            //Question 2, Expected points: 0,5

            MultiChoiceQuestion question2 = new MultiChoiceQuestion() { CorrectAnswerAmount = 2, Points = 1 };

            QuestionAnswer questionAnswer21 = new QuestionAnswer("Answer1") { IsCorrectAnswer = true };
            AnsweredQuestionAnswer answeredQuestionAnswer21 = new AnsweredQuestionAnswer(questionAnswer21) { IsSelected = true };
            QuestionAnswer questionAnswer22 = new QuestionAnswer("Answer2") { IsCorrectAnswer = true };
            AnsweredQuestionAnswer answeredQuestionAnswer22 = new AnsweredQuestionAnswer(questionAnswer22) { IsSelected = false };
            QuestionAnswer questionAnswer23 = new QuestionAnswer("Answer3") { IsCorrectAnswer = false };
            AnsweredQuestionAnswer answeredQuestionAnswer23 = new AnsweredQuestionAnswer(questionAnswer23) { IsSelected = false };

            List<AnsweredQuestionAnswer> answeredQuestionAnswers2 = new List<AnsweredQuestionAnswer>();
            answeredQuestionAnswers2.Add(answeredQuestionAnswer21);
            answeredQuestionAnswers2.Add(answeredQuestionAnswer22);
            answeredQuestionAnswers2.Add(answeredQuestionAnswer23);

            AnsweredChoiceQuestion answeredQuestion2 = new AnsweredChoiceQuestion(question2, answeredQuestionAnswers2);

            //Question 3, Expected points: 0

            SingleChoiceQuestion question3 = new SingleChoiceQuestion() { CorrectAnswerAmount = 1, Points = 1 };

            QuestionAnswer questionAnswer31 = new QuestionAnswer("Answer1") { IsCorrectAnswer = true };
            AnsweredQuestionAnswer answeredQuestionAnswer31 = new AnsweredQuestionAnswer(questionAnswer31) { IsSelected = false };
            QuestionAnswer questionAnswer32 = new QuestionAnswer("Answer2") { IsCorrectAnswer = false };
            AnsweredQuestionAnswer answeredQuestionAnswer32 = new AnsweredQuestionAnswer(questionAnswer32) { IsSelected = true };

            List<AnsweredQuestionAnswer> answeredQuestionAnswers3 = new List<AnsweredQuestionAnswer>();
            answeredQuestionAnswers3.Add(answeredQuestionAnswer31);
            answeredQuestionAnswers3.Add(answeredQuestionAnswer32);

            AnsweredChoiceQuestion answeredQuestion3 = new AnsweredChoiceQuestion(question3, answeredQuestionAnswers3);

            //Question 4, Expected points: 0.1(6)

            MultiChoiceQuestion question4 = new MultiChoiceQuestion() { CorrectAnswerAmount = 2, Points = 1 };

            QuestionAnswer questionAnswer41 = new QuestionAnswer("Answer1") { IsCorrectAnswer = true };
            AnsweredQuestionAnswer answeredQuestionAnswer41 = new AnsweredQuestionAnswer(questionAnswer41) { IsSelected = true };
            QuestionAnswer questionAnswer42 = new QuestionAnswer("Answer2") { IsCorrectAnswer = false };
            AnsweredQuestionAnswer answeredQuestionAnswer42 = new AnsweredQuestionAnswer(questionAnswer42) { IsSelected = false };
            QuestionAnswer questionAnswer43 = new QuestionAnswer("Answer3") { IsCorrectAnswer = true };
            AnsweredQuestionAnswer answeredQuestionAnswer43 = new AnsweredQuestionAnswer(questionAnswer43) { IsSelected = false };
            QuestionAnswer questionAnswer44 = new QuestionAnswer("Answer4") { IsCorrectAnswer = false };
            AnsweredQuestionAnswer answeredQuestionAnswer44 = new AnsweredQuestionAnswer(questionAnswer44) { IsSelected = false };
            QuestionAnswer questionAnswer45 = new QuestionAnswer("Answer4") { IsCorrectAnswer = false };
            AnsweredQuestionAnswer answeredQuestionAnswer45 = new AnsweredQuestionAnswer(questionAnswer45) { IsSelected = true };

            List<AnsweredQuestionAnswer> answeredQuestionAnswers4 = new List<AnsweredQuestionAnswer>();
            answeredQuestionAnswers4.Add(answeredQuestionAnswer41);
            answeredQuestionAnswers4.Add(answeredQuestionAnswer42);
            answeredQuestionAnswers4.Add(answeredQuestionAnswer43);
            answeredQuestionAnswers4.Add(answeredQuestionAnswer44);
            answeredQuestionAnswers4.Add(answeredQuestionAnswer45);

            AnsweredChoiceQuestion answeredQuestion4 = new AnsweredChoiceQuestion(question4, answeredQuestionAnswers4);

            List<AnsweredChoiceQuestion> sessionQuestions = new List<AnsweredChoiceQuestion>();
            sessionQuestions.Add(answeredQuestion1);
            sessionQuestions.Add(answeredQuestion2);
            sessionQuestions.Add(answeredQuestion3);
            sessionQuestions.Add(answeredQuestion4);

            ExamEvaluator examEvaluator = new ExamEvaluator(sessionQuestions);
            //
            decimal result = examEvaluator.EvaluateAttempt();
            decimal expectedResult = Math.Round(((decimal)(1.67 / 4) * 100), 1);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
