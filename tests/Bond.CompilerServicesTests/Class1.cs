using Xunit;

namespace Bond.CompilerServicesTests
{
    public class LexerTests
    {
        [Fact]
        public void Identifiers()
        {
            var input = @"namespace";
            var lexer = new Lexer(input);

            var token = lexer.Match(SyntaxKind.NamespaceToken);
            Assert.NotNull(token);
            Assert.Equal();
        }
        
    }

}
