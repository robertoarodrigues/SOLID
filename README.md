# SOLID

É um acrônimo dos cinco primeiros princípios da programação orientada a objetos e design de código identificados por Robert C. Martin (ou Uncle Bob) por volta do ano 2000.

## Os princípios SOLID devem ser aplicados para se obter os benefícios da orientação a objetos, tais como:

- Seja fácil de se manter, adaptar e se ajustar às alterações de escopo;
- Seja testável e de fácil entendimento;
- Seja extensível para alterações com o menor esforço necessário;
- Que forneça o máximo de reaproveitamento;
- Que permaneça o máximo de tempo possível em utilização.

## Utilizando os princípios SOLID é possível evitar problemas muito comuns:

- Dificuldade na testabilidade/criação de testes de unidade;
- Código macarrônico, sem estrutura ou padrão;
- Dificuldades de isolar funcionalidades;
- Duplicação de código, uma alteração precisa ser feita N pontos;
- Fragilidade, o código quebra facilmente em vários pontos após alguma mudança.

## SRP - Single Responsability Principle
- "A class should have one, and only one, reason to change"
    - "Uma classe deve ter um, e apenas um, motivo para ser modificada".

## OCP - Open Closed Principle

- "Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification".
    - "Entidades de software (classes, módulos, funções, etc) devem estar abertas para extensão, mas fechadas para modificação".

## LSP - Liskov Substitution Principle

- "Let q(x) be a property provable about objects x of type T. Then q(y) should be provable for objects Y of type S, where S is a subtype of R"
    - "Se q(x) é uma propriedade demonstrável dos objetos x de tipo T. Então q(y) deve ser verdadeiro para objetos y de tipo S onde S é um subtipo de T."
    - "Subclasses devem ser substituíveis por suas Superclasses".

## ISP - Interface Segregation Principle

- "States that no client should be forced to depend on methods it does not use"
    - "Clientes não devem ser forçados a depender de métodos que não usam".
    - Muitas interfaces específicas são melhores do que uma interface única.
    

## DIP - Dependency Inversion Principle

- "High-level modules should not depend on low-level modules. Both should depend on abstractions.
    
    Abstractions should not depend on details. Details should depend on abstractions."
    
- "Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações;
    
    Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações".
    
    Dependa de uma abstração e não de uma implementação.