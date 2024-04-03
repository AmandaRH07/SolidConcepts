# SOLID
Resumo e exemplo dos conceitos SOLID

## S - Single Responsability Principle (SRP)
- Uma classe deve ter apenas um motivo para ser modificada
- No Exemplo:
	- Não devemos colocar o método de notificação na classe  com os métodos responsáveis pelas alterações básicas dos dados no banco

## O - Open/Close Principle (OCP)
- As classes devem ser abertas para extensão e fechadas para modificação
- No Exemplo:
	- Ao invés de colocar todos os métodos dos juntos, separar por "categoria" e usar a interface para estender apenas os métodos básicos para cada veículo. Isso deixa a implementação muito mais abstraída e parametrizável

## L - Liskov Substitution Principle (LSP)
- Deve ser possível substituir uma classe derivada por uma classe base sem quebrar a aplicação
- No exemplo:
	- Caso surgir uma demanda de criação de um programa de pontos no cartão, a solução seria chamar diretamente a classe responsável pelo programa de pontos. Essa classe implementa a interface utilizada nas classes de crédito e débito, ao invés de apenas implementar a abstração de cartão. O resultado é a implementação dos pontos tanto para crédito quanto para débito sem quebrar a lógica já utilizada

## I - Interface Segregation Principle(ISP)
- Uma classe não deveria ser forçada a implementar métodos que ela não precisa usar
- No Exemplo:
	- Os veículos implementam classes apenas que fazem sentido para a categoria em que eles se encaixam. Nesse caso um dos parâmetros que não se encaixa em uma moto é "Porta", desse modo, podemos criar uma interfaces específicas que podem estender de uma interface padrão.

## D - Dependency Inversion Principle (DIP)
- Um módulo de alto nível (negócio) não pode depender de um módulo de baixo nível (técnico) e ambos devem depender apenas das abstrações
- No Exemplo:
	- Não devemos deixar o acesso ao banco de dados no mesmo lugar que vai fazer a busca e trazer os dados do banco,. Outro problema que pode aparecer futuramente é a troca do banco o que poderia gerar problemas na aplicação. Nesse caso, foi criado um Factory que lida com as opções de bancos disponíveis e depois parte para o resto do processamento.
