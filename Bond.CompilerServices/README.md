# Lexer

## Lexems:
```
identifiers     := [a-zA-Z_]([a-zA-Z0-9_])*
numbers         :=
string literals := ".*?"
other           := [:;<>.=,\[\]()]

```
___

## Keywords:

```
namespace
using
struct
enum
nothing
value
```


### Intrinsic types:*
*Basic:*
```

bool, 
uint8, uint16, uint32, uint64, 
int8, int16, int32, int64, 
float, double, 
string, wstring
```

*Container*
```
blob, list<T>, vector<T>, set<T>, map<K, T>, nullable<T>
```



# Parser
```
Compilation          := ImportDeclaration* NamespaceDeclaration* TypeDeclaration*
ImportDeclaration    := 'import' StringLiteral
NamespaceDeclaration := 'namespace' QualifiedName
TypeDeclaration      := StructDeclaration 
                      | EnumDeclaration 
(later)               | ServiceDeclaration
                      | ForwardDeclaration
EnumDeclaration      := 'enum' SimpleName '{' (EnumAttributeDeclaration (',' EnumAttributeDeclaration))* '}'
StructDeclaration    := 'struct' GenericName '{'
```