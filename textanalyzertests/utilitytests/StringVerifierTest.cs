﻿using NUnit.Framework.Legacy;
using TextAnalyzer.Utility;

namespace TextAnalyzer.utilitytests
{
    public class StringVerifierTest
    {
        private StringVerifier strVerfier;

        [SetUp]
        public void Setup()
        {
            strVerfier = new StringVerifier();
        }

        [Test]
        public void checkIfStringVerfierCanBeCreated()
        {
            ClassicAssert.NotNull(strVerfier);
        }

        [Test]
        public void checkCountOneWordInGivenString()
        {
            int countedWords = 1;
            String givenInput = "test";
            ClassicAssert.AreEqual(countedWords, strVerfier.count_words_in_string(givenInput));
        }


        [Test]
        public void checkCountManyWordsInGivenString()
        {
            int countedWords = 5;
            String givenInput = "testALikeManyWords";
            ClassicAssert.AreEqual(countedWords, strVerfier.count_words_in_string(givenInput));
        }

        [Test]
        public void checkCountManyWordsSeparatedByComaInAString()
        {
            int countedWords = 5;
            String givenInput = "test,A,Like,Many,Words";
            ClassicAssert.AreEqual(countedWords, strVerfier.count_words_in_string(givenInput));
        }

        [Test]
        public void checkCountManyWordsSeparatedBySemicolonInAString()
        {
            int countedWords = 5;
            String givenInput = "test;A;Like;Many;Words";
            ClassicAssert.AreEqual(countedWords, strVerfier.count_words_in_string(givenInput));
        }

        [Test]
        public void checkCountManyWordsSeparatedByQuestionMarkInAString()
        {
            int countedWords = 5;
            String givenInput = "test?A?Like?Many?Words";
            ClassicAssert.AreEqual(countedWords, strVerfier.count_words_in_string(givenInput));
        }

        [Test]
        public void checkCountManyWordsSeparatedByExclamationMarkInAString()
        {
            int countedWords = 5;
            String givenInput = "test!A!Like!Many!Words";
            ClassicAssert.AreEqual(countedWords, strVerfier.count_words_in_string(givenInput));
        }


        [Test]
        public void checkCountManyWordsSeparatedByDifferentSignsInAString()
        {
            int countedWords = 6;
            String givenInput = "test'A;Like!Many?Words Test2";
            ClassicAssert.AreEqual(countedWords, strVerfier.count_words_in_string(givenInput));
        }

        [Test]
        public void checkCountOneLetterInGivenWord()
        {
            int countedletters = 1;
            Char letter = 'T';
            String givenInput = "Transformers";
            ClassicAssert.AreEqual(countedletters, strVerfier.count_letter_in_word(letter,givenInput));
        }

        [Test]
        public void checkCountOneLetterNotAppearInGivenWord()
        {
            int countedletters = 0;
            Char letter = 'B';
            String givenInput = "Transformers";
            ClassicAssert.AreEqual(countedletters, strVerfier.count_letter_in_word(letter, givenInput));
        }

        [Test]
        public void checkCountManyLettersInGivenWord()
        {
            String result = "T: 2, s: 1, e: 1, found: 3 letters!";
            String letters = "T,s,e";
            String givenInput = "Testopia";
            ClassicAssert.AreEqual(result, strVerfier.count_many_letter_in_word(letters, givenInput));
        }

        [Test]
        public void checkForErrorMessageIfCountManyLettersInGivenEmptyWord()
        {
            String result = "Invalid input!";
            String letters = "T,s,e";
            String givenInput = "";
            ClassicAssert.AreEqual(result, strVerfier.count_many_letter_in_word(letters, givenInput));
        }

        [Test]
        public void checkIfGivenStringAB64Code()
        {
            String giveInput = "d7UTz8x29Xny7GyQqy2fUQ==";
            ClassicAssert.True(strVerfier.isBase64Str(giveInput));
        }

        [Test]
        public void checkIfGivenStringNotAB64Code()
        {
            String giveInput = "I am not 64bit coded string!";
            ClassicAssert.False(strVerfier.isBase64Str(giveInput));
        }

        [Test]
        public void checkIfGivenEmailIsValid()
        {
            String validEmail = "valid@gmail.com";

            ClassicAssert.True(strVerfier.isValidEmail(validEmail));
        }

        [Test]
        public void checkIfGivenEmailIsNonValid()
        {
            String validEmail = "valid@faker.com";

            ClassicAssert.False(strVerfier.isValidEmail(validEmail));
        }

        [Test]
        public void checkIfGivenEmailEmptyValid()
        {
            String validEmail = "";

            ClassicAssert.False(strVerfier.isValidEmail(validEmail));
        }
    }
}
