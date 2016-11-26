namespace Bond.CompilerServices
{
    public partial class SyntaxNode
    {
        public SyntaxKind Kind { get; }

        public SyntaxNode(SyntaxKind kind)
        {
            this.Kind = kind;
        }

        
    }
}
