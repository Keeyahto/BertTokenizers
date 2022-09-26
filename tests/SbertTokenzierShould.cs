using BERTTokenizers;
using System.Collections.Generic;
using Xunit;

namespace BERTTokenizersTests
{
    public class SbertTokenizerShould
    {
        private SbertTokenizer _tokenizer;

        public SbertTokenizerShould()
        {
            _tokenizer = new SbertTokenizer();
        }

        [Fact]
        public void Tokenize_sentence()
        {
            var sentence = "Я тебя люблю";

            var tokens = _tokenizer.Tokenize(sentence);
            Assert.Equal(5, tokens.Count);
            Assert.Equal(("[CLS]", 101, 0), tokens[0]);
            Assert.Equal(("Я", 119, 0), tokens[1]);
            Assert.Equal(("тебя", 1679, 0), tokens[2]);
            Assert.Equal(("люблю", 7355, 0), tokens[3]);
            Assert.Equal(("[SEP]", 102, 0), tokens[4]);

        }

        [Fact]
        public void Encode_sentence()
        {
            var sentence = "Я тебя люблю";

            var encoded = _tokenizer.Encode(6, sentence);
            Assert.Equal(5, encoded.Count);
            Assert.Equal((101, 0, 1), encoded[0]);
            Assert.Equal((119, 0, 1), encoded[1]);
            Assert.Equal((1679, 0, 1), encoded[2]);
            Assert.Equal((7355, 0, 1), encoded[3]);
            Assert.Equal((102, 0, 1), encoded[4]);
        }
    }
}
